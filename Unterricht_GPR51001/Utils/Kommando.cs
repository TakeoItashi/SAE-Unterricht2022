using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Unterricht_GPR51001.Utils
{
	public class Kommando : ICommand
	{
		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return true;//throw new NotImplementedException();
		}

		public void Execute(object parameter)
		{
			m_action.Invoke();
		}

		private Action m_action;

		public Kommando(Action _action)
		{
			m_action = _action;
		}
	}
}
