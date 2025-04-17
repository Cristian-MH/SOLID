namespace SOLID.S.Solution; 
internal class OrderService
{
    private readonly IOrderRepository _orderRepository; 
    private readonly INotificationService _notificationService; 
    private readonly IInvoiceService _invoiceService; 
    private readonly ILoggerService _loggerService; 

    public OrderService(IOrderRepository orderRepository, NotificationService notificationService,IInvoiceService invoiceService, ILoggerService loggerService)
    => (_orderRepository, _notificationService, _invoiceService, _loggerService) = (orderRepository, notificationService, invoiceService, loggerService); 
    

    public void SaveOrder(Order order)
    {
        try
        {
            _orderRepository.InsertOrder(order); 
            var invoice = _invoiceService.CreateInvoice(order); 
            _notificationService.EmailInvoice(invoice); 
            _loggerService.Info("The order has been complete");
        }
        catch (System.Exception e)
        {
            _loggerService.Error(e.Message, e); 
        }
    }

}