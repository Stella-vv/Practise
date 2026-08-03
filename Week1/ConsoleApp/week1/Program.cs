using ConsoleApp.Enum;
using ConsoleApp_Order.Models;
using ConsoleApp_PaintProduct.Models;
using ConsoleApp_PaintSpecification.Models;
using ConsoleApp_Brand.Models;


PaintSpecification paintSpecification1 = new PaintSpecification( "yellow", 2);
PaintSpecification paintSpecification2 = new PaintSpecification("white", 2);

Brand luxury = new Brand("Luxury");
Brand normal = new Brand("Normal");


PaintProduct product1 = new PaintProduct( "Name1", PaintType.BaseCoat, paintSpecification1, 50m , luxury);
PaintProduct product2 = new PaintProduct("Name2", PaintType.Glossy, paintSpecification2, 60m, normal);

product1.DisplayInfo();
product2.DisplayInfo();

Order order1 = new Order(product1, 3);
Order order2 = new Order(product2, 4);

order1.DisPlay();
order2.DisPlay();