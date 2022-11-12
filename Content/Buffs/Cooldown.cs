using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace RacesOfMyrasyl.Content.Buffs
{
    public class Cooldown : ModBuff
    {

        public override void SetStaticDefaults() {
        DisplayName.SetDefault("Cooldown");
        Description.SetDefault("Your ability is on cooldown");
        Main.debuff[Type] = true;
		Main.pvpBuff[Type] = true;
		Main.buffNoSave[Type] = true;
		BuffID.Sets.LongerExpertDebuff[Type] = true;
        }
    }
}