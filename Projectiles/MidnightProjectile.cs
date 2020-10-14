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

namespace AFFTD.Projectiles
{
    public class MidnightProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "Midnight's Ranged Attack";
            projectile.width = 20;
            projectile.height = 20;
            projectile.damage = 25;
            projectile.knockBack = 0; //we give a bit more damage than the sword itself, but no knockback
            projectile.penetrate = 30;
            projectile.timeLeft = 10000;
            projectile.light = 0.10f;
            projectile.extraUpdates = 1;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
        }
    }
}
