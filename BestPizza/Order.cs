using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPizza
{
    public enum OrderType
    {
       Dinein,
       Takeout,
       Delivery
    }
    /// <summary>
    /// This is about online ordering for a pizza place
    /// </summary>
    class Order
    {
        #region Variables
        private static int lastOrderNumber = 0;
        #endregion
        #region properties
        /// <summary>
        ///  order number for the order placed
        /// </summary>
        public int OrderNumber { get; private set; }
        /// <summary>
        /// Customer name for order
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// Customer Phone number
        /// </summary>
        public int CustomerPhone { get; set; }
        /// <summary>
        /// Customer Address
        /// </summary>
        public string CustomerAddress { get; set; }
        /// <summary>
        /// Customer CreditCard details
        /// </summary>
        public double CreditCard { get; set; }

        public OrderType TypeOfOrder { get; set; }

        #endregion

        #region Constructor
        public Order()
        {
            OrderNumber = ++lastOrderNumber;
        }
        #endregion

        #region Methods

        #endregion
    }
}
