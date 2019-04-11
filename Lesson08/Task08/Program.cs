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
            character.OnRequest += OnRequest;
            character.OnIllness += OnIllness;
            while (true)
            {

            }

        }
        public static void OnDead(string s)
        {
            Console.WriteLine(s);
            Environment.Exit(0);
            Application.Exit();
        }
        public static bool  OnRequest(string s)
        {
            Console.WriteLine(s);
            //DialogResult dialogResult = MessageBox.Show(s, "Request", MessageBoxButtons.YesNo);
            //if (dialogResult != DialogResult.Yes && dialogResult != DialogResult.OK)
            //{
            //    return false;
            //}
            //else { return true; }
            string result=Console.ReadLine();
            if(result.ToLower() != "yes" && result.ToLower() != "y")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool  OnIllness(string s)
        {
            Console.WriteLine(s);
            string result = Console.ReadLine();
            if (result.ToLower() == "y" || result.ToLower() == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
