namespace SOLID.S.Solution; 
interface INotificationService
{
    public bool EmailInvoice(Invoice order); 
}

class NotificationService : INotificationService
{
    public bool EmailInvoice(Invoice order)
    {
        return true; 
    }
}