using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace PAK_Command_Editor.HardwareInteractionModule
{
    public class COMTimer: IDisposable
    {
        public Timer tmrComm = new Timer();
        public bool timedout = false;

        public COMTimer()
        {
            timedout = false;
            tmrComm.AutoReset = false;
            tmrComm.Enabled = false;
            tmrComm.Interval = 1000; //default to 1 second
            tmrComm.Elapsed += new ElapsedEventHandler(OnTimedCommEvent);
        }

        public void OnTimedCommEvent(object source, ElapsedEventArgs e)
        {
            timedout = true;
            tmrComm.Stop();
        }

        public void Start(double timeoutperiod)
        {
            tmrComm.Interval = timeoutperiod; //time to time out in milliseconds
            tmrComm.Stop();
            timedout = false;
            tmrComm.Start();
        }

        #region IDisposable Implementation

        public void Dispose()
        {
            this.tmrComm.Dispose();
        }

        #endregion
    }
}
