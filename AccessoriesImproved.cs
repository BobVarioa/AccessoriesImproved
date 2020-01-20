using System;
using Terraria.ModLoader;

namespace AccessoriesImproved
{
	public class AccessoriesImproved : Mod
	{
		public static ModHotKey DjinnsCurseToggle;
		public static ModHotKey WeatherToggle;
		public AccessoriesImproved()
		{

		}

		public override void Load()
		{
			DjinnsCurseToggle = RegisterHotKey("Djinn's Curse Toggle", "T");
			WeatherToggle = RegisterHotKey("Weather Toggle", "G");
		}

		public override void Unload()
		{
			DjinnsCurseToggle = null;
			WeatherToggle = null;
		}
	}
}