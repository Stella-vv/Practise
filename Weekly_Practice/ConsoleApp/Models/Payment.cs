using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_PaintProduct.Models;
using ConsoleApp_PaintType.Enum;
using ConsoleApp_PaymentStatus.Enum;
using ConsoleApp_PaymentMethod.Enum;
using ConsoleApp_Order.Models;
using ConsoleApp_User.Models;

namespace ConsoleApp_Payment.Models
{
    public class Payment
    {
      public int PaymentId { get; set; }
      public decimal PaymentAmount { get; set; }
      public PaymentStatus Status { get; set; }
      public PaymentMethod Method { get; set; }

      public readonly DateTime CreatedAt = DateTime.Now;

      private static int nextId = 1;

      public Order Order { get; set; }
      public User User { get; set; }

      public Payment( PaymentStatus status, PaymentMethod method, Order order, User user)
      {
        PaymentId = nextId;
        nextId++;
        Status = status;
        Method = method;
        Order = order;
        User = user;
        PaymentAmount = order.TotalPrice;
      }
    }
}

