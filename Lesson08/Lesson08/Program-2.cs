using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Task08
{
	class Program
	{

		static void Main(string[] args)
		{
			
			Character character = new Character();
            character.OnDead += OnDead;
			Thread.Sleep(120000);
		}
        public static void OnDead(string s)
        {
			//Console.WriteLine(s);
			MessageBox.Show(s);
        }



	}
}
