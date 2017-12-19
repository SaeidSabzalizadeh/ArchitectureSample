namespace Architecture.Standard.Biz
{
    public interface IAlarm
    {
        string Signiture { get; }
        void Alarm();
        string Get();
    }
}
