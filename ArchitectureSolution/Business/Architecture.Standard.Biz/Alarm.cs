using System;

namespace Architecture.Standard.Biz
{
    public abstract class Alarm : IAlarm
    {
        public abstract string Signiture { get; }

        public string Get()
        {
            return Signiture;
        }

        void IAlarm.Alarm()
        {
            Console.WriteLine(Signiture);
        }

    }
}
