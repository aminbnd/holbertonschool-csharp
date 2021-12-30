using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class User : BaseClass
    {
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public User(string name)
        {
            this.name = name;
        }
    }
}
