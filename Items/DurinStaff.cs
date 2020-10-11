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
    public class DurinStaff : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Durin's Staff");
			Tooltip.SetDefault("Bow, boooooow.");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 18;
			item.magic = true;
			item.mana = 14;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = Item.sellPrice(copper: 50);
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item20;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType("DurinProjectile");
			item.shootSpeed = 8f;
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
