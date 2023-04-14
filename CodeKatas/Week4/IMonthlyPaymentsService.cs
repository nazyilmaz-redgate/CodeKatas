namespace CodeKatas.Week4;

public interface IMonthlyPaymentsService
{
    IEnumerable<Payment> GetCurrentMonthsPayments(long userId);
    IEnumerable<Payment> GetPreviousMonthsPayments(long userId);
}