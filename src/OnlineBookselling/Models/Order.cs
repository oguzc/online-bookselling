using System;

namespace OnlineBookselling.Models
{
    public sealed class Order
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public int ProductId { get; private set; }
        public DateTime OrderPlacedDate { get; private set; }
        public PaymentMethodType PaymentMethod { get; private set; }

        public void SetUserId(int userId)
        {
            UserId = userId;
        }

        public void SetProductId(int userId)
        {
            UserId = userId;
        }

        public void SetOrderPlacedDate()
        {
            OrderPlacedDate = DateTime.Now;
        }

        public enum PaymentMethodType
        {
            Cash,
            CreditCard,
            MoneyTransfer
        }

        public enum DeliveryMethod
        {
            Ptt,
            Yurtici,
            Aras
        }
    }
}
