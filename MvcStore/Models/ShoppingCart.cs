namespace MvcStore.Models
{
    public class ShoppingCart
    {
        public int ItemId {get; set;}
        public int ItemType {get; set;}
        public int Quantity {get; set;}
        public ShoppingCart()
        {
            this.Quantity = 1;
        }
        public void add_Quantity(int x)
        {
            this.Quantity += x;
        } 
        public void sub_Quantity(int x)
        {
            this.Quantity -= x;
        }
    }
}