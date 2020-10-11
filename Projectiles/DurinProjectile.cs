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
    public class DurinProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "Durin's Staff";
            projectile.width = 20;
            projectile.height = 20;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.penetrate = 30;
            projectile.timeLeft = 200;
            projectile.light = 0.75f;
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }
    }
}