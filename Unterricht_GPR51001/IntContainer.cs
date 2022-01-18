using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unterricht_GPR51001
{
	public class IntContainer : INotifyPropertyChanged
	{
		private int mValue;
		public int Value
		{
			get => mValue;
			set
			{
				mValue = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
