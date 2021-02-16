using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Items.Placeable
{
    public class myblock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Un blocco viola");
            Tooltip.SetDefault("Sono un blocco viola");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useStyle = 15;
            item.consumable = true;
            item.createTile = mod.TileType("TileViola");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}