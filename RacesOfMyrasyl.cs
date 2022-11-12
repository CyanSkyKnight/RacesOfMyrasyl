using Microsoft.Xna.Framework;
using System.Collections.Generic;
using RacesOfMyrasyl.Common.Races;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;

namespace RacesOfMyrasyl
{
    public class RacesOfMyrasyl : Mod
    {

        public static RacesOfMyrasyl Instance { get; private set; }
        public override void Unload()
        {
            //this is essential, unloads this mod's custom races
            MrPlagueRaces.Common.Races.RaceLoader.Races.Clear();
            MrPlagueRaces.Common.Races.RaceLoader.RacesByFullNames.Clear();
        }
    }
}