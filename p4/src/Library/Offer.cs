using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Offer
    {
        public DateTime EndDate { get; set; }

        public IReadOnlyCollection<IOfferItem> Items
        {
            get
            {
                return new ReadOnlyCollection<IOfferItem>(this.items);
            }
        }

        public double Total
        {
            get
            {
                double result = 0;
                foreach (IOfferItem item in this.items)
                {
                    result = result + item.SubTotal;
                }

                return result;
            }
        }

        private IList<OfferItem> items = new List<OfferItem>();

        public Offer(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public  IOfferItem AddItem(Residue Residue, int quantity, int price)
        {
            OfferItem item = new OfferItem(Residue, quantity, price);
            this.items.Add(item);
            return item;
        }

        public void RemoveItem(OfferItem item)
        {
            this.items.Remove(item);
        }
        public IOfferItem AddDiscount(double discount)
        {
            IOfferItem item = new OfferItem(discount);
            this.items.Add(item);
            return item;
        }
    }
}