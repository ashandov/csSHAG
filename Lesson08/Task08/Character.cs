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

    class Character
    {
        public delegate bool RequestDelegate(string s);
        public delegate void DeadDelegate(string s);
        public delegate bool IllDelegate(string s);
        public event DeadDelegate OnDead;
        public event RequestDelegate OnRequest;
        public event IllDelegate OnIllness;
        private int ignoreRequestsTimerCount;
        private int previousRequestNumber;
		private int requestNumber;
		private Random random;
        private readonly System.Timers.Timer lifeTimer;
        private readonly System.Timers.Timer requestTimer;
        public Character()
        {
			requestTimer = new System.Timers.Timer();
            lifeTimer = new System.Timers.Timer();
            previousRequestNumber = -1;
            ignoreRequestsTimerCount = 0;
            random = new Random();

			lifeTimer.Interval = 119000;
            lifeTimer.Enabled = true;
            lifeTimer.Elapsed += OnElapsedLifeTimer;
         

            requestTimer.Interval = 3000;
            requestTimer.Enabled = true;
            requestTimer.Elapsed += OnElapsedRequestTimer;
            StartTimers();
           

        }
        private void StartTimers()
        {
            lifeTimer.Start(); 
            requestTimer.Start();

        }
        private void StopTimers()
        {
            lifeTimer.Stop();
            requestTimer.Stop();

        }
        private void CheckResult(bool result)
        {
            requestTimer.Stop();
            if (!result)
            {
                ignoreRequestsTimerCount++;
            }
			if (ignoreRequestsTimerCount>=3&&OnIllness!=null)
			{
                if(!OnIllness("I'm ill.\nCan u treat me?\n"))
                {
                    OnDead("I'm dead!");
                    StopTimers();

                }
                else
                {
                    requestTimer.Start();
                }
            }
            else
            {
                requestTimer.Start();
            }

        }
		private string Request()
        {
            requestTimer.Stop();
            requestNumber = random.Next(0, 4);
            if (requestNumber != previousRequestNumber)
            {
                switch (requestNumber)
                {
                    case 0:
                        previousRequestNumber = requestNumber;
                        return "I want to eat.\nCan u feed me?\n";
                    case 1:
                        previousRequestNumber = requestNumber;
                        return "I want to go for a walk.\nCan go for a walk with me?\n";
                    case 2:
                        previousRequestNumber = requestNumber;
                        return "I want to sleep.\nCan u bring me to bed?\n";
                    case 3:
                        previousRequestNumber = requestNumber;
                        return "I'm ill.\nCan u treat me?\n";
                    case 4:
                        previousRequestNumber = requestNumber;
                        return "I want to play.\nCan u play with me?\n";
                    default:
                        return "There is no such request";
                        throw new InvalidOperationException();
                }
            }
            else { return null; }
        }

        private  void OnElapsedLifeTimer(object sender, ElapsedEventArgs e)
        {
            if (OnDead != null)
                StopTimers();
				OnDead("I'm dead!");
				lifeTimer.Stop();
		}

        private void OnElapsedRequestTimer(object sender, ElapsedEventArgs e)
        {
            if (OnRequest != null)
            {
                bool result = OnRequest(Request());
                CheckResult(result);
            }
        }

	}
}


