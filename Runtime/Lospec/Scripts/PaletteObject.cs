using System.Collections.Generic;
using UnityEngine;

namespace DarkFantasia.Lospec
{
	public class PaletteObject : ScriptableObject
	{
		public string Author;
		public List<Color> colors = new List<Color>();


		public void SetUp(PaletteInformation paletteInformation)
		{
			Author = paletteInformation.author;
			name = paletteInformation.name;
			colors = paletteInformation.GetColors();
		}
	
	}
}
