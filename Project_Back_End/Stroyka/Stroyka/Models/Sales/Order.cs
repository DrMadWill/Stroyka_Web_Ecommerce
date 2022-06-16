using Stroyka.Models.Users;
using System;
using System.Collections.Generic;

namespace Stroyka.Models.Sales
{
    public class Order
    {

        public int Id { get; set; }
        // User Table | One To Many
        public User User { get; set; }
        public int UserId { get; set; }

        // Payment Table | One To Many
        public Payment Payment { get; set; }
        public int PaymentId { get; set; }
        
        public  float Total { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
