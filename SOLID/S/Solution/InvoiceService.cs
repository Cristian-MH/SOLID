namespace SOLID.S.Solution; 
interface IInvoiceService
{
    public Invoice CreateInvoice(Order order); 
}

class InvoiceService : IInvoiceService
{
    public Invoice CreateInvoice(Order order)
    {
        return new Invoice(); 
    }
}