using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unterricht_GPR51001
{
	public class Additor : INotifyPropertyChanged
	{
		public IntContainer Number
		{
			get;
			set;
		}

		private ObservableCollection<string> m_listing;
		public ObservableCollection<string> Listing
		{
			get => m_listing;
			set => m_listing = value;
		}

		private string mEnteredText;
		public string EnteredText
		{
			get => mEnteredText;
			set => mEnteredText = value;
		}

		public Additor()
		{
			Number = new IntContainer();
			Listing = new ObservableCollection<string>() { "string1", "string2" };
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void Add()
		{
			Number.Value += 1;

			Listing = new ObservableCollection<string>() { "new string" };

			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Number)));

			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EnteredText)));
		}
	}
}
