internal class OrderService
{
    public void SaveOrder(Order order)
    {
        try
        {
            this.InsertOrder(order); 
            var invoice = this.CreateInvoice(order); 
            this.EmailInvoice(invoice); 
            File.WriteAllText(@"Error.txt", "");
        }
        catch (System.Exception)
        {
            File.WriteAllText(@"Error.txt", "");
        }
    }    

    public bool InsertOrder(Order order)
    {
        return true; 
    }

    public Invoice CreateInvoice(Order order)
    {
        return new Invoice(); 
    }

    public bool EmailInvoice(Invoice invoice)
    {
        return true; 
    }
}


public record Order(); 
public record Invoice(); 