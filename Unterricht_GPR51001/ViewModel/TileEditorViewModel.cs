using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unterricht_GPR51001.Models;
using Unterricht_GPR51001.Utils;

namespace Unterricht_GPR51001.ViewModel
{
	public class TileEditorViewModel : BaseViewModel
	{
		private ObservableCollection<Tile> mTiles;
		public ObservableCollection<Tile> Tiles
		{
			get => mTiles;
			set => SetProperty(ref mTiles, value, nameof(Tiles));
		}

		public Tile SelectedTile
		{
			get;
			set;
		}

		public Kommando AddCommand { get; set; }
		public Kommando RemoveCommand { get; set; }

		public TileEditorViewModel()
		{
			mTiles = new ObservableCollection<Tile>()
			{
				new Tile() { Name = "First Tile" },
				new Tile() { Name = "Second Tile" },
			};

			AddCommand = new Kommando(AddTile);
			RemoveCommand = new Kommando(RemoveSelectedTile);
		}

		private void RemoveSelectedTile()
		{
			Tiles.Remove(SelectedTile);
		}

		private void AddTile()
		{
			//Tiles.Add(new Tile() { Name = "new Tile" });

			Tiles = new ObservableCollection<Tile>()
			{
				new Tile(){Name = "newTile"}
			};
		}
	}
}
