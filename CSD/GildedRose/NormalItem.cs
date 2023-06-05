using System;
namespace CSD.GildedRose
{
    public class NormalItem : Item
    {
        public override void UpdateItem()
        {
            DecreaseQuality();

            PassOneDay();

            if (IsExpired)
            {
                DecreaseQuality();
            }
        }

    }

}

