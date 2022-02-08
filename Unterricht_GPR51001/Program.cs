using Models_and_Interfaces.Interfaces;
using Serialization;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unterricht_GPR51001.View;
using Unterricht_GPR51001.ViewModel;

namespace Unterricht_GPR51001
{
	public class Program
	{
		static Container m_zentralerPunkt;
		[STAThread]
		static void Main()
		{
			m_zentralerPunkt = new Container();
			m_zentralerPunkt.Register<ISerializer, XMLSerializerClass>();
			//m_zentralerPunkt.Register<ISerializer, JSONSerializerClass>();

			m_zentralerPunkt.Register<TileEditorViewModel>();

			m_zentralerPunkt.Register<TileEditor>();

			m_zentralerPunkt.Verify();

			App application = new App();
			TileEditor mainWindow = m_zentralerPunkt.GetInstance<TileEditor>();

			application.Run(mainWindow);
		}
	}
}
