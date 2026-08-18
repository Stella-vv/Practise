
using ConsoleApp_Order.Models;
using ConsoleApp_Payment.Models;


namespace ConsoleApp_User.Models
{
  public class User{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public User(string name, string email) {
      Name = name;
      Email = email;
      Orders = new List<Order>();
      Payments = new List<Payment>();
    }

    public List<Order> Orders {get; set;} 

    public List<Payment> Payments {get; set;} 

    public void FindMostExpensiveOrder()
    {
      Order?order = Orders.OrderByDescending(o => o.TotalPrice).FirstOrDefault();

      if(order != null)
      {
        Console.WriteLine($"User {Name}'s most expensive order is : {order.TotalPrice} dollars");
      }
    }

    public void FindLatestOrder()
    {
      Order?order = Orders.OrderByDescending(o => o.CreatedAt).FirstOrDefault();

      if(order != null)
      {
        Console.WriteLine($"User {Name}'s latest order is created at: {order.CreatedAt}");
      }

    }

    public void FindCheapestPayment()
    {
      Payment?payment = Payments.OrderBy(p => p.PaymentAmount).FirstOrDefault();

      if(payment != null)
      {
        Console.WriteLine($"User {Name}'s cheapest payment is: {payment.PaymentAmount} dollars");
      }
    }

    public void FindLatestPayment()
    {
      Payment?payment = Payments.OrderByDescending(p => p.CreatedAt).FirstOrDefault();

      if(payment != null)
      {
        Console.WriteLine($"User {Name}'s latest payment is: {payment.CreatedAt}");
      }
    }

    public void FindPaymentOver10()
    {
      var payments = Payments.Where(p => p.PaymentAmount>10);
      
      foreach(Payment payment in payments)
      {
        Console.WriteLine($"User {Name}'s payment amount over 10 is: {payment.PaymentAmount}");
      }
    }

  }
}