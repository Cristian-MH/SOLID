namespace SOLID.S.Solution; 
interface IOrderRepository
{
    public bool InsertOrder(Order order); 
}

class OrderRepository : IOrderRepository
{
    public bool InsertOrder(Order order)
    {
        return true; 
    }
}