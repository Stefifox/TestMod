using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Tiles
{
    public class TileViola : ModTile
    {
        public override void SetDefaults()
        {
            drop = mod.ItemType("myblock");
            AddMapEntry(new Color(444, 222, 435));
        }
    }
}