//2、使用事件机制，模拟实现一个闹钟功能。闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。
//在闹钟走时时或者响铃时，在控制台显示提示信息。

using System;
using System.Threading;

namespace Assign2
{
    class Clock
    {
        public event Action<Clock, DateTime> TickHandler;//基于委托Action定义事件,publisher
        public event Action<Clock> AlarmHandler;

        public DateTime AlarmTime { get; set; }

        public Clock(DateTime alarmTime)
        {
            AlarmTime = alarmTime;
        }

        public void Start()
        {
            while (true)
            {
                TickHandler(this, DateTime.Now);

                //if Now is later than or equal to the AlarmTime
                if (DateTime.Compare(DateTime.Now, AlarmTime) >= 0 )
                {

                    AlarmHandler(this);
                }
                Thread.Sleep(1000);
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            DateTime targetTime = DateTime.Now.AddSeconds(3); // 3秒后响铃
            Clock clock = new Clock(targetTime);
            clock.TickHandler += HandleClick;
            clock.AlarmHandler += HandleAlarm;
            clock.Start();

        }

        static void HandleClick(Clock sender, DateTime dateTime)
        {
            Console.WriteLine($"clock {sender} ticked at {dateTime.ToString("t")}");
        }

        static void HandleAlarm(Clock sender)
        {
            Console.WriteLine($"clock {sender} ring");
            if (DateTime.Now.Subtract(sender.AlarmTime).Seconds >= 3)
            {
                sender.AlarmTime=DateTime.Now.AddMinutes(1);//一分钟后响铃
            }
        }
    }
}