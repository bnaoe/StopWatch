using System;

namespace StopWatch
{
    public class Calculator
    {
        private String _executionInput;
        public DateTime Start;
        public DateTime End;

        private TimeSpan _duration;

        public Boolean ValidateInput(String input)
        {
            if (input.ToLower() == "start" && string.IsNullOrWhiteSpace(_executionInput)) return true;
            else if (input.ToLower() == "stop" && _executionInput.ToLower() == "start") return true;
            else if (_executionInput.ToLower() == "start" && input.ToLower() == "start") return false;
            else return false;

        }

        public void SetStartEndDuration(DateTime datetime, String input)
        {
            _executionInput = input;

            if (_executionInput.ToLower() == "start")
            {
                Start = datetime;
                _executionInput = "start";
            }
            else if (_executionInput.ToLower() == "stop")
            {
                End = datetime;
                _duration = End-Start;
                _executionInput = "";
            }
        }

        public TimeSpan GetDuration()
        {
            return _duration;
        }
        
    }
}