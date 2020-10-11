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
    public class TwelveFStaff : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("12F's Staff");
			Tooltip.SetDefault("You have my thanks for allowing me to join you.");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 14;
			item.magic = true;
			item.mana = 10;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = Item.sellPrice(copper: 50);
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item15;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType("TwelveFProjectile");
			item.shootSpeed = 10f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 12);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
