using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class Item : BaseClass
    {
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<string> tags = new List<string>();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        /// <param name="tags"></param>
        public Item(string name, string description, float price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
}
