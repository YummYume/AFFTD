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
    public class RangersBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ranger's Bow");
            Tooltip.SetDefault("Call whenever you need me.");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 38;
            item.rare = ItemRarityID.White;
            item.value = Item.sellPrice(copper: 50);
            item.useTime = 40;
            item.useAnimation = 35;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item5;
            item.noMelee = true;
            item.ranged = true;
            item.damage = 12;
            item.crit = 2;
            item.useAmmo = AmmoID.Arrow;
            item.shoot = 1;
            item.shootSpeed = 7.5f;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TinBow, 1);
            recipe.AddIngredient(ItemID.TinBar, 6);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
