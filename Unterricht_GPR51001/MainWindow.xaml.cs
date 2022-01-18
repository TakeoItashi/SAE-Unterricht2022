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
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private Additor addClass;
		public MainWindow()
		{
			InitializeComponent();
			addClass = new Additor();
			xTestWindow.DataContext = addClass;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			addClass.Add();
		}
	}
}
