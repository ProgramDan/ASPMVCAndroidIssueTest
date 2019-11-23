using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AndroidIssueTest.Models
{
    public class BasketItem
    {
        public int BasketItemID { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}