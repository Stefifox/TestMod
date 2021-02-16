using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Items
{
    public class myitem : ModItem
    {

        /*
        * Imposta i valori di default che non possono cambiare
        */
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Woow Esisto?");
            Tooltip.SetDefault("Sono un item inutile, forse faccio volare via la gente");
        }

        /*
        * Imposta i valori di default che possono cambiare
        */
        public override void SetDefaults()
        {
            item.damage = 1;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 1;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.crit = 90;
        }

        /*
        * Ricetta per ottenere l'item
        */
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddIngredient(ItemID.Wood, 5);
            //recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        /*
        * Imposta cosa accade quando un npc viene colpito
        */
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            int[] lista = {BuffID.Gravitation, BuffID.HeartLamp};
            int lunghezza = lista.Length;

            if(crit){
                target.AddBuff(BuffID.Gravitation, 5 * 60);
            }else{
                player.AddBuff(BuffID.Gravitation, 5* 60);
            }
            
        }
    }
}
