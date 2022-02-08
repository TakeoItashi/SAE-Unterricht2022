using Models_and_Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_and_Interfaces.Interfaces
{
	public interface ISerializer
	{
		void Serialize(Tile _tile, string _path);
	}
}
