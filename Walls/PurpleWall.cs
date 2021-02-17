using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TestMod.Walls
{
	public class PurpleWall : ModWall
	{
		public override void SetDefaults() {
			Main.wallHouse[Type] = true;
			drop = ModContent.ItemType<Items.Placeable.PurpleWall>();
			AddMapEntry(new Color(150, 150, 150));
		}
		
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) {
			r = 0.4f;
			g = 0.4f;
			b = 0.4f;
		}
	}
}