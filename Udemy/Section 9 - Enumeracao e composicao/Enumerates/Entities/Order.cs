using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// para utilizar propriedades de outros namespaces eh preciso citar eles
using Enumerates.Entities.Enums;

namespace Enumerates.Entities
{
    internal class Order
    {
        public int ID { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return ID 
                + ", " 
                + Moment 
                + ", " 
                + Status;
        }
    }
}
