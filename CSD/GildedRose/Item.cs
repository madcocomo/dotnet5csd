using System;
namespace CSD.GildedRose
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public abstract void UpdateItem();

        protected void RaiseQuality()
        {
            if (Quality < 50)
            {
                Quality = Quality + 1;
            }
        }

        protected void DecreaseQuality()
        {
            if (Quality > 0)
            {
                Quality = Quality - 1;
            }
        }

        protected void ClearQuality()
        {
            Quality = 0;
        }

        protected void PassOneDay()
        {
            SellIn = SellIn - 1;
        }

        protected bool IsExpired => SellIn < 0;
    }

}

