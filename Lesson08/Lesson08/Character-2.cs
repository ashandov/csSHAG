using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Timers;
using System.Threading;

namespace Task08
{
    public enum Requests
    {
        Feed, Walk, Sleep, Treat, Play
    }

    class Character
    {
        public delegate void RequestDelegate();
        public delegate void DeadDelegate(string s);
        public delegate void IllDelegate(string s);
        public event DeadDelegate OnDead;
        public event RequestDelegate OnRequest;
        public event IllDelegate OnIllness;
        private int ignoreRequestsTimerCount;
        private Dictionary<Requests, String> requestDictionary;
        private string[] requestsArray;
        private int previousRequestNumber;
		private int requestNumber;
		private Random random;
        private System.Timers.Timer lifeTimer;
        private System.Timers.Timer requestTimer;
        public Character()
        {
			Thread.Sleep(1000);
			requestTimer = new System.Timers.Timer();
            lifeTimer = new System.Timers.Timer();
            previousRequestNumber = -1;
            ignoreRequestsTimerCount = 0;
            random = new Random();
            requestsArray = new string[5];
            requestsArray[0] = "I want to eat.\nCan u feed me?\n";
            requestsArray[1] = "I want to go for a walk.\nCan go for a walk with me?\n";
            requestsArray[2] = "I want to sleep.\nCan u bring me to bed?\n";
            requestsArray[3] = "I'm ill.\nCan u treat me?\n";
            requestsArray[4] = "I want to play.\nCan u play with me?\n";

			requestDictionary = new Dictionary<Requests, string>();
			requestDictionary.Add(Requests.Feed, "I want to eat.\nCan u feed me?\n");
			requestDictionary.Add(Requests.Play, "I want to go for a walk.\nCan go for a walk with me?\n");
			requestDictionary.Add(Requests.Sleep, "I want to sleep.\nCan u bring me to bed?\n");
			requestDictionary.Add(Requests.Treat, "I'm ill.\nCan u treat me?\n");
			requestDictionary.Add(Requests.Walk, "I want to play.\nCan u play with me?\n");



			lifeTimer.Interval = 119000;
            lifeTimer.Enabled = true;
            lifeTimer.Elapsed += OnElapsedLifeTimer;
            lifeTimer.Start();

			OnRequest += OnRequests;
            requestTimer.Interval = 1000;
            requestTimer.Enabled = true;
            requestTimer.Elapsed += OnElapsedRequestTimer;
            requestTimer.Start();

			OnIllness += OnIll;

        }
        private void CheckMessageBoxResult(DialogResult result)
        {
            if (result == DialogResult.No)
            {
                ignoreRequestsTimerCount++;
            }
			if (ignoreRequestsTimerCount >= 3)
			{
				OnIll("I'm ill");
			}
        }
        private void CheckConsoleResult(string result)
        {
            if (result.ToLower() != "yes" && result.ToLower() != "y")
            {
                ignoreRequestsTimerCount++;
            }
			if (ignoreRequestsTimerCount>=3)
			{
				OnIll(requestsArray[3]);
			}
        }

		private void MessageBoxRequest()
		{
		
			
			DialogResult result;
			int requestNumber;
			requestNumber = random.Next(0, 4);
			if (requestNumber != previousRequestNumber)
			{
				switch (requestNumber)
				{
					case 0:
						result = Show(requestNumber);
						CheckMessageBoxResult(result);
						previousRequestNumber = requestNumber;
						break;
					case 1:
						result = Show(requestNumber);
						CheckMessageBoxResult(result);
						previousRequestNumber = requestNumber;
						break;
					case 2:
						result = Show(requestNumber);
						CheckMessageBoxResult(result);
						previousRequestNumber = requestNumber;
						break;
					case 3:
						result = Show(requestNumber);
						CheckMessageBoxResult(result);
						previousRequestNumber = requestNumber;
						break;
					case 4:
						result = Show(requestNumber);
						CheckMessageBoxResult(result);
						previousRequestNumber = requestNumber;
						break;

				}
			}
			
		}
		private DialogResult Show(int id)

		{
			MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNoCancel;
			return MessageBox.Show(requestDictionary[(Requests)id], $"{id}", messageBoxButtons);
		}
		private void ConsoleRequest()
        {
            string answer;
            requestNumber = random.Next(0, 4);
            if (requestNumber != previousRequestNumber)
            {
                switch (requestNumber)
                {
                    case 0:
                        Console.WriteLine(requestsArray[requestNumber]);
                        answer = Console.ReadLine();
                        CheckConsoleResult(answer);
						previousRequestNumber = requestNumber;
						break;
                    case 1:
                        Console.WriteLine(requestsArray[requestNumber]);
                        answer = Console.ReadLine();
                        CheckConsoleResult(answer);
						previousRequestNumber = requestNumber;
						break;
                    case 2:
                        Console.WriteLine(requestsArray[requestNumber]);
                        answer = Console.ReadLine();
                        CheckConsoleResult(answer);
						previousRequestNumber = requestNumber;
						break;
                    case 3:
                        Console.WriteLine(requestsArray[requestNumber]);
                        answer = Console.ReadLine();
                        CheckConsoleResult(answer);
						previousRequestNumber = requestNumber;
						break;
                    case 4:
                        Console.WriteLine(requestsArray[requestNumber]);
                        answer = Console.ReadLine();
                        CheckConsoleResult(answer);
						previousRequestNumber = requestNumber;
						break;
					default:
						throw new InvalidOperationException("There is no such request");
						break;
                }
            }
        }

        private  void OnElapsedLifeTimer(object sender, ElapsedEventArgs e)
        {
			if (OnDead != null)
				requestTimer.Stop();
				OnDead("I'm dead!");
				lifeTimer.Stop();
			
			//Thread thread = new Thread(new ThreadStart(() => Console.WriteLine("")));
			//thread.Abort();
			////thread.Join();
		}

		private void OnIll(string s)
        {
			requestTimer.Stop();
			if (OnIllness != null)
            {
				string answer = Console.ReadLine().ToLower();
				if (answer!="y"&& answer != "yes")
				{
					
					OnDead("I'm dead!");
				}
				else
				{
					requestTimer.Start();
				}
            }
        }
        private void OnElapsedRequestTimer(object sender, ElapsedEventArgs e)
        {
            if (OnRequest != null)
            {
				MessageBoxRequest();
            }
        }
		private static void OnRequests()
		{

		}


	}
}


