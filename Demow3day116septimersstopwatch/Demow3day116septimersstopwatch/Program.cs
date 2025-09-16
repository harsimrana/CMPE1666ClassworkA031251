using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demow3day116septimersstopwatch
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}


/*
 *Timer component
 * The timer has one event - Tick event
 *  which occurs once for every time period if the timer is ENABLED : Make sure it is enabled
 *  Need to specify the time in milliseconds
 *  Timers are required to implement animation or periodic events
 *  Timer is not visible on form
 *  
 *  
 *  Stopwatch  allows us to start stopwatch so as to track time.
 *  
 *  Stopwatch myStopWatch = new System.Diagnostics.Stopwatch();
 *  Properties : EllapsedMilliseconds - The number of milliseconds that have 
 *                                      passed since the stopwatch started
 *  Methods:  start(), stop()
 *  
 *  
 */