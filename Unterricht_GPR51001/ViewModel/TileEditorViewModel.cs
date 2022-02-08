using Models_and_Interfaces.Interfaces;
using Models_and_Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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

		public ICommand AddCommand { get; set; }
		public ICommand RemoveCommand { get; set; }
		public ICommand SaveCommand { get; set; }

		private ISerializer m_serializer;

		public TileEditorViewModel(ISerializer _serializer)
		{
			mTiles = new ObservableCollection<Tile>()
			{
				new Tile() { Name = "First Tile" },
				new Tile() { Name = "Second Tile" },
			};

			AddCommand = new Kommando(AddTile);
			RemoveCommand = new Kommando(RemoveSelectedTile);
			SaveCommand = new Kommando(SaveTile);
			m_serializer = _serializer;
		}

		private void SaveTile()
		{
			string pathToSave = Path.Combine(Directory.GetCurrentDirectory(), "save");
			m_serializer.Serialize(SelectedTile, pathToSave);
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
