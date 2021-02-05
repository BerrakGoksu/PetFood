using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Basket : BaseEntity
    {
        public string BuyerId { get; set; }
        private List<BasketItem> Items { get; set; }
    }
}
