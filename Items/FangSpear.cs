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
    public class FangSpear : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fang's Spear");
			Tooltip.SetDefault("My team and I will do our best to serve Rhodes Island.");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 20;
			item.useTime = 25;
			item.shootSpeed = 5;
			item.knockBack = 6.5f;
			item.width = 30;
			item.height = 30;
			item.scale = 1f;
			item.rare = ItemRarityID.Green;
			item.value = Item.sellPrice(silver: 10);
			item.melee = true;
			item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
			item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
			item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType("FangProjectile");
		}

		public override bool CanUseItem(Player player)
		{
			// Ensures no more than one spear can be thrown out, use this when using autoReuse
			return player.ownedProjectileCounts[item.shoot] < 1;
		}
	}
}
