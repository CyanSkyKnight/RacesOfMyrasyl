using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace RacesofMyrasyl.Items
{
	[AutoloadEquip(EquipType.Wings)]
	public class JungleMothWings : ModItem
	{

		public override void SetStaticDefaults() {
			Tooltip.SetDefault("'It's not a butterfly!'");
		}

		public override void SetDefaults() {
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = ItemRarityID.Cyan;
			item.vanity = true;
			item.accessory = true;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.wingTimeMax = 0;
			player.wings = 0;
            player.wingsLogic = 0;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend) {
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 1f;
			constantAscend = 0f;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}