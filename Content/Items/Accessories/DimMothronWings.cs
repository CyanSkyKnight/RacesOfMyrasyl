using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace RacesOfMyrasyl.Content.Items.Accessories
{
	[AutoloadEquip(EquipType.Wings)]
	public class DimMothronWings : ModItem
	{

		public override void SetStaticDefaults() {
			Tooltip.SetDefault("'Also known as 'Mothroff' wings.'");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;


			ArmorIDs.Wing.Sets.Stats[Item.wingSlot] = new WingStats(180, 9f, 2.5f);
		}

		public override void SetDefaults() {
			Item.width = 22;
			Item.height = 20;
			Item.value = 10000;
			Item.vanity = true;
			Item.rare = ItemRarityID.Green;
			Item.accessory = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.wingsLogic = 0;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend) {
			ascentWhenFalling = 0.85f; // Falling glide speed
			ascentWhenRising = 0.15f; // Rising speed
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddIngredient(ItemID.Daybloom);
			recipe.AddIngredient(ItemID.Moonglow);
			recipe.AddTile(TileID.Loom);
			recipe.Register();
		}
		
	}
}
