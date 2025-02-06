using MPOS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPOS
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		//public static Views.MPOS mPOS;
		public static Views.Login login;
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//mPOS = new Views.MPOS();
			//Application.Run(mPOS);
			login = new Views.Login();
			Application.Run(login);

		}
	}
}
