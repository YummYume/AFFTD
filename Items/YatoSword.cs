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
	public class YatoSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Yato's Sword");
			Tooltip.SetDefault("Are you the one for me to protect?");
		}

		public override void SetDefaults() 
		{
			item.damage = 10;
			item.crit = 7;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = Item.sellPrice(copper: 50);
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBroadsword, 1);
			recipe.AddIngredient(ItemID.TinBar, 6);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}