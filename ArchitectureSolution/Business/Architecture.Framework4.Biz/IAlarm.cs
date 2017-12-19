namespace Architecture.Framework4.Biz
{
    public interface IAlarm
    {
        string Signiture { get; }
        void Alarm();
        string Get();
    }
}
