namespace OrdersCS
{
    public interface IOrderCore
    {
        public long OrderId { get; }
        public long Username { get; }
        public long SecurityId { get; }
    }
}