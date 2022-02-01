using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unterricht_GPR51001.ViewModel
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected void SetProperty<T>(ref T _property, object _newValue, string _propertyName)
		{
			_property = (T)_newValue;
			OnPropertyChanged(_propertyName);
		}

		protected void OnPropertyChanged(string _nameOfProperty)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_nameOfProperty));
		}
	}
}
