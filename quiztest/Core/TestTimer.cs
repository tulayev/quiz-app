
namespace quiztest.Core
{
    public class TestTimer
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public int Secs { get; set; }
        public bool IsRunning { get; set; }

        public TestTimer(int seconds, bool isRunning)
        {
            Seconds = seconds;
            IsRunning = isRunning;
        }

        public void TimerRun()
        {
            Hours = Seconds / 3600;
            Minutes = (Seconds % 3600) / 60;
            Secs = Seconds % 60;

            if (IsRunning)
                Seconds--;
        }
    }
}
