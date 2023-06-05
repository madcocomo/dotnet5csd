﻿using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CSD.GildedRose
{
	public class GildedRoseTest
	{
		[Test]
		public void foo()
		{
            IList<Item> Items = new List<Item> { new NormalItem { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
			Assert.AreEqual("fixme", Items[0].Name);
        }
	}
}

