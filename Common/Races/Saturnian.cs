using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using RacesOfMyrasyl.Content.Buffs;
using MrPlagueRaces.Common.Races;
using static MrPlagueRaces.MrPlagueRacesPlayer;
using static Terraria.ModLoader.ModContent;

namespace RacesOfMyrasyl.Common.Races.Saturnian
{
	public class Saturnian : Race
	{
		public override void Load()
        {
			Description = "A moth species that lives in sky cities above the planet Myrasyl. Most Saturnians are from the city Solalei. They practice a form of light manipulating magic";
			AbilitiesDescription = $"-Immune to fall damage. Holding down [c/34EB93:Jump] slows your fall as if you had wings. Gains extra flight time when using wings.";
			//Character colors, in RGB
			HairColor = new Color(196, 196, 196);
			SkinColor = new Color(196, 92, 102); 
			DetailColor = new Color(90, 90, 90); 
			EyeColor = new Color(89, 213, 224); 

			ClothStyle = 4;
			CensorClothing = false;
			StarterShirt = false;
			StarterPants = false;
			
			//Clothes colors, in RGB
			ShirtColor = new Color(93, 159, 187); 
			UnderShirtColor = new Color(150, 50, 150); 
			PantsColor = new Color(141, 112, 14); 
			ShoeColor = new Color(110, 93, 89); 
		}

		public override void ResetEffects(Player player) //Put stats changes here
		{	
			//Damage
			player.GetDamage(DamageClass.Summon) += 0.15f;
			player.GetDamage(DamageClass.Magic) += 0.15f;

			//General stat
			player.statManaMax2 += 25; //+25 Mana
			player.statDefense -= 4;
			player.wingTimeMax += 100;

			//Misc

			player.noFallDmg = true; //No fall damage

		}

		public override void ProcessTriggers(Player player, TriggersSet triggersSet) //Put the hotkey things here
		{		
			if (!player.dead) // Check if the player is alive
			{
				if ((player.wingsLogic == 0) && player.velocity.Y != 0)
				{
					if (player.controlJump)
					{
						if (player.velocity.Y != 0)
						{
							if (!(player.velocity.Y < 2))
							{
								player.velocity.Y -= 1;
								player.moveSpeed += 1f;
							}
						}
					}
				}
				if (MrPlagueRaces.MrPlagueRaces.RaceAbilityKeybind1.Current){//Check if the Racial Ability 1 hotkey is Pressed (There's four Racial Ability hotkey)

					if (!player.HasBuff(BuffType<Cooldown>())){ //Check if the player have the Cooldown debuff

						SoundEngine.PlaySound(SoundID.PlayerHit, player.Center); //Sound IDs are available on internet
						player.AddBuff(BuffType<Cooldown>(), 60); //Give the Cooldown debuff to the player for 60 tick (1s)
					}
				}
			}
		}
	}
}
