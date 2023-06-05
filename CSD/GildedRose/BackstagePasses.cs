using System;
namespace CSD.GildedRose
{
    public class BackstagePasses : Item
    {
        public override void UpdateItem()
        {
            RaiseQuality();

            if (SellIn < 11)
            {
                RaiseQuality();
            }

            if (SellIn < 6)
            {
                RaiseQuality();
            }

            PassOneDay();

            if (IsExpired)
            {
                ClearQuality();
            }
        }

    }

}

