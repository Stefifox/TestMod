using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace TestMod.Items.Placeable
{
	public class PurpleWall : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Purple Wall");
			Tooltip.SetDefault("Purple Wall");
		}

		public override void SetDefaults() {
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.createWall = ModContent.WallType<Walls.PurpleWall>();
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<purpleblock>());
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}