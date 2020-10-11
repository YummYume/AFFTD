using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace AFFTD.Items
{
    public class MidnightSword : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Midnight's Sword");
			Tooltip.SetDefault("Show me your brightest smile, esteemed customer!");
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.crit = 10;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 7.5f;
			item.rare = ItemRarityID.Green;
			item.value = Item.sellPrice(silver: 10);
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}
