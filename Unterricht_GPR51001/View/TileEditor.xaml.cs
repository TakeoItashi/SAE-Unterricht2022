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
using System.Windows.Shapes;
using Unterricht_GPR51001.ViewModel;

namespace Unterricht_GPR51001.View
{
	/// <summary>
	/// Interaction logic for TileEditor.xaml
	/// </summary>
	public partial class TileEditor : Window
	{
		public TileEditor(TileEditorViewModel _viewModel)
		{
			InitializeComponent();
			DataContext = _viewModel;
		}
	}
}
