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
			item.useTime = 35;
			item.useAnimation = 35;
			item.shoot = mod.ProjectileType("MidnightProjectile");
			item.shootSpeed = 20;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 7.5f;
			item.rare = ItemRarityID.Green;
			item.value = Item.sellPrice(silver: 10);
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		//Code to spawn projectile from sky to mouse position (from ModExample)
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			position = player.Center + new Vector2(player.direction, -600f);
			Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
			float ceilingLimit = target.Y;
			if (ceilingLimit > player.Center.Y - 200f)
			{
				ceilingLimit = player.Center.Y - 200f;
			}
			Vector2 heading = target - position;
			if (heading.Y < 0f)
			{
				heading.Y *= -1f;
			}
			if (heading.Y < 20f)
			{
				heading.Y = 20f;
			}
			heading.Normalize();
			heading *= new Vector2(speedX, speedY).Length();
			speedX = heading.X;
			speedY = heading.Y;
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage * 2, knockBack, player.whoAmI, 0f, ceilingLimit);
			return false;
		}
	}
}
