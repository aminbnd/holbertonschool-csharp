using System;

namespace InventoryLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class Inventory : BaseClass
    {
        /// <summary>
        /// 
        /// </summary>
        public string user_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string item_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        private int _quantity = 1;
        /// <summary>
        /// 
        /// </summary>
        public int quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = Math.Clamp(value, 0, int.MaxValue);
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="user_id"></param>
        /// <param name="item_id"></param>
        /// <param name="quantity"></param>

        public Inventory(string user_id, string item_id, int quantity)
        {
            this.user_id = base.id;
            this.item_id = base.id;
            this.quantity = quantity;
        }
    }
}
