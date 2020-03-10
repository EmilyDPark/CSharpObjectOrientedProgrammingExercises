using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Stopwatch
{
    class Stopwatch
    {
        public TimeSpan Duration { get; private set; }
        private DateTime _startTime;
        private bool _running;

        public void Start()
        {
            if (_running)
                throw new InvalidOperationException();

            _startTime = DateTime.Now;
            _running = true;
        }

        public void Stop()
        {
            if (!_running)
                throw new InvalidOperationException();

            Duration = DateTime.Now - _startTime;
            _running = false;
        }

    } // Stopwatch class

} // Exercise1_Stopwatch namespace

