using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using uniteSlotSystemRemaster.AccessorySlots;

namespace uniteSlotSystemRemaster
{
	public class uniteSlotSystemRemaster : Mod
	{
		public static bool revengeMode;

		public override void Load()
		{
			RegAccSlots();
		}

		private void RegAccSlots()
		{
			AddContent(new WingsAccessorySlot());
			AddContent(new BootsAccessorySlot());
			AddContent(new GearAccessorySlot());
			AddContent(new MagiluminescenceAccessorySlot());
			AddContent(new NecklaceAccessorySlot());
			AddContent(new ScarfAccessorySlot());
			AddContent(new HealAccessorySlot());
			AddContent(new DefenseAccessorySlot());
			AddContent(new ExpAccessSlot());
			AddContent(new RevAccessSlot());
			AddContent(new BuildingAccessSlot());
			AddContent(new FishingAccessSlot());
		}
	}
}
