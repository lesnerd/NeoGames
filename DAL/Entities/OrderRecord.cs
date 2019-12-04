
using System;

namespace NeoGames.DAL.Entities
{
    public class OrderRecord
    {
        // The construstor is here so I could make some dummy data real quick
        // In real life 
        public OrderRecord(int itemNumber, decimal amount, DateTime date)
        {
            ItemNumber = itemNumber;
            Amount = amount;
            PurchaseDate = date;
        }
        private int itemNumber;
        private decimal amount;
        private DateTime purchaseDate;

        public int ItemNumber 
        { 
            get 
            {
                return itemNumber;
            } 
            set
            {
                itemNumber = value;
            } 
        }

        public decimal Amount 
        { 
            get
            {
                return amount;
            } 
            set
            {
                amount = value;
            } 
        }

        public DateTime PurchaseDate 
        { 
            get
            {
                return purchaseDate;
            }
            set
            {
                purchaseDate = value;
            }
        }

    }
}