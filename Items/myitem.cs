using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Items
{
    public class myitem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Woow Esisto?");
            Tooltip.SetDefault("Sono un item inutile");
        }

        public override void SetDefaults()
        {
            item.damage = 0;
            item.melee = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            //recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
