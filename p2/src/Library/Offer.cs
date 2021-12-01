using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Offer 
    { 
        public DateTime EndDate { get; set; }

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

        public void AddItem(OfferItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(OfferItem item)
        {
            this.items.Remove(item);
        }

        /// <summary>
        /// intenté darle el mismo formato aunque no era necesario.
        /// </summary>
        /// <returns></returns>
        public string AsText()
        {
            StringBuilder ticket = new StringBuilder();
            ticket.AppendLine($"Fecha : {this.EndDate}\n");
            foreach (OfferItem item in Items)
            {
                ticket.AppendLine($"{item.Quantity} de");
                ticket.Append(item.Residue.Name);
                ticket.AppendLine($"a {item.Price} de");
            }
            return ticket.ToString();
        }
    }
}