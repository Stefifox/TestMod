using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Items.Placeable
{
    public class purpleblock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purple Block");
            Tooltip.SetDefault("I'm a purple block");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = mod.TileType("purpletiles");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddIngredient(ItemID.StoneBlock, 1);
            recipe.SetResult(this, 15);
            recipe.AddRecipe();
        }
    }
}