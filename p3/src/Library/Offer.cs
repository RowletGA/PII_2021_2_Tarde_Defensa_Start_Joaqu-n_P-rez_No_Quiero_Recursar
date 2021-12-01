using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    /// <summary>
    /// Por Expert y Srp esta clase es la que conoce la información necesaria para dicha responsabilidad.
    /// </summary>
    public class Offer
    {
        public DateTime EndDate { get; set; }
        public int Total {get; set;}
        public IReadOnlyCollection<OfferItem> Items
        {
            get
            {
                return new ReadOnlyCollection<OfferItem>(this.items);
            }
        }

        private IList<OfferItem> items = new List<OfferItem>();

        public Offer(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        /// <summary>
        /// cuando se agrega un item, el mismo se suma al total y este lo calcula con el precio y la cantidad
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(OfferItem item) 
        {
            this.items.Add(item);
            this.Total += item.Price * item.Quantity;
        }

        public void RemoveItem(OfferItem item)
        {
            this.items.Remove(item);
        }
    }
}