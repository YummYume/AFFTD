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
			item.useTime = 30;
			item.useAnimation = 30;
			item.shoot = mod.ProjectileType("MidnightProjectile");
			item.shootSpeed = 35;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 7.5f;
			item.rare = ItemRarityID.Green;
			item.value = Item.sellPrice(silver: 10);
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		//Code to spawn projectile from sky to mouse position (from ModExample)
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
			float ceilingLimit = target.Y;
			if (ceilingLimit > player.Center.Y - 200f)
			{
				ceilingLimit = player.Center.Y - 200f;
			}
			for (int i = 0; i < 3; i++)
			{
				position = player.Center + new Vector2((-(float)Main.rand.Next(0, 401) * player.direction), -600f);
				position.Y -= (100 * i);
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
				speedY = heading.Y + Main.rand.Next(-40, 41) * 0.02f;
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI, 0f, ceilingLimit);
			}
			return false;
		}
	}
}
