using System;
namespace StopWatch
{
    public class StopWatchFunctions
    {

        private DateTime _startTime;
        private DateTime _endTime;

        public void ChangeState(ref Boolean state)
        {
            if (state)
            {
                StartStopWatch();
                state = !state;
            }
            else
            {
                StopStopWatch();
                state = !state;
            }
        }

        void StartStopWatch()
        {
            Console.WriteLine("Starting stop watch. Press any key except x / X to stop. \n");
            this._startTime = DateTime.Now;
        }

        void StopStopWatch()
        {
            this._endTime = DateTime.Now;
            var totalTime = this._endTime.Subtract(this._startTime);
            Console.WriteLine("Stop watch stopped, total time : " + totalTime.Seconds.ToString() + " seconds. \n");
        }

    }
}
