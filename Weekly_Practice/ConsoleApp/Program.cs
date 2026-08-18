using ConsoleApp_PaintType.Enum;
using ConsoleApp_Order.Models;
using ConsoleApp_PaintProduct.Models;
using ConsoleApp_PaintSpecification.Models;
using ConsoleApp_Brand.Models;
using ConsoleApp_PaintStore.Models;
using ConsoleApp_User.Models;
using ConsoleApp_Payment.Models;
using System.Security;
using ConsoleApp_PaymentStatus.Enum;
using ConsoleApp_PaymentMethod.Enum;


PaintSpecification paintSpecification1 = new PaintSpecification("yellow", 1);
PaintSpecification paintSpecification2 = new PaintSpecification("white", 2);
PaintSpecification paintSpecification3 = new PaintSpecification("black", 3);
PaintSpecification paintSpecification4 = new PaintSpecification("green", 4);

Brand luxury = new Brand("Luxury");
Brand normal = new Brand("Normal");


PaintProduct product1 = new PaintProduct("Name1", PaintType.BaseCoat, paintSpecification1, 10m, luxury);
PaintProduct product2 = new PaintProduct("Name2", PaintType.Glossy, paintSpecification2, 20m, normal);
PaintProduct product3 = new PaintProduct("Name3", PaintType.WhiteOnWhite, paintSpecification3, 30m, normal);
PaintProduct product4 = new PaintProduct("Name4", PaintType.Matte, paintSpecification4, 40m, luxury);

product1.DisplayInfo();
product2.DisplayInfo();
product3.DisplayInfo();
product4.DisplayInfo();



List<PaintProduct> storeProducts = new List<PaintProduct>
{
  product1, 
  product2,
  product3, 
  product4
};
PaintStore store = new PaintStore(storeProducts);

store.StoreAvailability();


List<PaintProduct> products1 = new List<PaintProduct>
{
  product1, 
  product2
};

List<PaintProduct> products2 = new List<PaintProduct>
{
  product3, 
  product4
};

Order order1 = new Order(products1, 3);
Order order2 = new Order(products2, 4);

order1.GetTotalOrderPrice();
order2.GetTotalOrderPrice();

order1.DisPlay();
order2.DisPlay();

order1.GetMostExpensiveProduct();
order2.GetMostExpensiveProduct();

order1.FindProduct(5, 50);
order2.TypeTotalPrice();

User user1 = new User("stella", "123@163.com");
User user2 = new User("Adrian", "321@gmail.com");

user1.Orders.Add(order1);
user2.Orders.Add(order2);


Payment payment1 = new Payment(PaymentStatus.Pending, PaymentMethod.Alipay, order1, user1);
Payment payment2 = new Payment(PaymentStatus.Success, PaymentMethod.CreditCard, order2, user2);

user1.Payments.Add(payment1);
user2.Payments.Add(payment2);

user1.FindMostExpensiveOrder();
user1.FindLatestOrder();
user2.FindCheapestPayment();
user2.FindPaymentOver10();
user2.FindLatestPayment();