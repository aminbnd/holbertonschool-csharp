using System;

namespace InventoryLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseClass
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime date_created { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime date_updated { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public BaseClass()
        {
            date_created = new DateTime();
            date_updated = new DateTime();
            id = generateId();
        }

        /// <summary>
        /// Method that generates new Id
        /// </summary>
        /// <returns>string: generated Id</returns>
        public string generateId()
        {
            id = Guid.NewGuid().ToString();
            return id;
        }
    }
}
