using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Unterricht_GPR51001
{
	/// <summary>
	/// Interaction logic for SpecialButton.xaml
	/// </summary>
	public partial class SpecialButton : UserControl
	{
		public static readonly DependencyProperty PathProperty = DependencyProperty.Register(nameof(Path), 
																							 typeof(string), 
																							 typeof(SpecialButton), 
																							 new PropertyMetadata(
																								@"C:\Users\SAE\source\repos\Unterricht_GPR51001\Unterricht_GPR51001\bin\Debug\error.bmp"));

		public string Path
		{
			get=>(string)GetValue(PathProperty);
			set=> SetValue(PathProperty, value);
		}

		public SpecialButton()
		{
			InitializeComponent();
		}
	}
}
