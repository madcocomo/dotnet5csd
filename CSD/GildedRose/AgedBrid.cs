using System;
namespace CSD.GildedRose
{
    public class AgedBrid : Item
    {
        public override void UpdateItem()
        {
            RaiseQuality();

            PassOneDay();

            if (IsExpired)
            {
                RaiseQuality();
            }
        }

    }

}

