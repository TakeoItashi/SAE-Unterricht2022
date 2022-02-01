using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unterricht_GPR51001.Models
{
	public class Tile
	{
		public string ImagePath;
		public string Name
		{
			get;
			set;
		}
		public TileType Type;
	}

	public enum TileType
	{
		standard,
		special
	}
}
