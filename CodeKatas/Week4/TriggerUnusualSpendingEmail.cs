namespace CodeKatas.Week4;

public class TriggerUnusualSpendingEmail
{
    private readonly IMonthlyPaymentsService MonthlyPaymentsService;
    private readonly IEmailService EmailService;
    private readonly decimal Percentage;
    private readonly decimal Threshold;

    public TriggerUnusualSpendingEmail(IMonthlyPaymentsService monthlyPaymentsService, decimal percentage,
        IEmailService emailService)
    {
        MonthlyPaymentsService = monthlyPaymentsService;
        Percentage = percentage;
        EmailService = emailService;
        Threshold = Percentage + 1;
    }


    public void Trigger(long userId)
    {
        var payments = MonthlyPaymentsService.GetCurrentMonthsPayments(userId);

        var previousMonthPayments = MonthlyPaymentsService.GetPreviousMonthsPayments(userId).GroupBy(d => d.Category)
            .Select(g => new {Category = g.Key, Total = g.Sum(p => p.Price)});

        var unusualSpending = payments.GroupBy(d => d.Category)
            .Select(g => new GroupedPayments(g.Sum(p => p.Price), g.Key))
            .Where(g => g.Amount * Threshold >
                        previousMonthPayments.Single(d => d.Category == g.Category).Total)
            .ToList();

        if (unusualSpending.Any())
        {
            EmailService.SendUnusualPaymentEmail(userId, unusualSpending);
        }
    }
}