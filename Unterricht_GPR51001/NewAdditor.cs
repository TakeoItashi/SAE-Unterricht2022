using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unterricht_GPR51001
{
	public class NewAdditor : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private ObservableCollection<string> m_listing;
		public ObservableCollection<string> Listing
		{
			get => m_listing;
			set => m_listing = value;
		}
	}
}
