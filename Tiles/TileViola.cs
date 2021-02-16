using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TestMod.Tiles
{
    public class TileViola : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = false;
            Main.tileLighted[Type] = false;
        
            drop = mod.ItemType("myblock");
            AddMapEntry(new Color(444, 222, 435));
        }
    }
}