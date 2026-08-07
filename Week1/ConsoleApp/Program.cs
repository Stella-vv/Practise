using ConsoleApp.Enum;
using ConsoleApp_Order.Models;
using ConsoleApp_PaintProduct.Models;
using ConsoleApp_PaintSpecification.Models;
using ConsoleApp_Brand.Models;


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

PaintProduct[] products1 = { product1, product2 };
PaintProduct[] products2 = { product3, product4 };

Order order1 = new Order(products1, 3);
Order order2 = new Order(products2, 4);

order1.GetTotalOrderPrice();
order2.GetTotalOrderPrice();

order1.DisPlay();
order2.DisPlay();