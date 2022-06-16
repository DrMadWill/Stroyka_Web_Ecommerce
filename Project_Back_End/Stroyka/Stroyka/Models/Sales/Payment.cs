using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stroyka.Models.Sales
{
    public class Payment
    {

        // Order Table | One To One
        [Key, ForeignKey("Order")]
        public int Id { get; set; }
        public Order Order { get; set; }
        

        // Status Table | One To Many
        public Status Status { get; set; }
        public int StatusId { get; set; }

        public float Amount { get; set; }

        public DateTime CreateAt { get; set; }
        public DateTime ModifiedAt { get; set; }

    }
}
