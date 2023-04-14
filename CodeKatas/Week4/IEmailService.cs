namespace CodeKatas.Week4;

public interface IEmailService
{
    void SendUnusualPaymentEmail(long userId, IEnumerable<GroupedPayments> payment);
}