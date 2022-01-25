using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unterricht_GPR51001
{
	public class SubClass : INotifyPropertyChanged
	{
		private string m_path;
		public string Path
		{
			get => m_path;
			set
			{
				m_path = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Path)));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public SubClass()
		{
			Path = @"C:\Users\SAE\source\repos\Unterricht_GPR51001\Unterricht_GPR51001\bin\Debug\dirt.png";
		}
	}
}
