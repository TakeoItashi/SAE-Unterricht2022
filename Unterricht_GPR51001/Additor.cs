using System;
using System.Collections.Generic;
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
		private string mEnteredText;
		public string EnteredText
		{
			get => mEnteredText;
			set => mEnteredText = value;
		}

		public Additor()
		{
			Number = new IntContainer();
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void Add()
		{
			Number.Value += 1;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Number)));

			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EnteredText)));
		}
	}
}
