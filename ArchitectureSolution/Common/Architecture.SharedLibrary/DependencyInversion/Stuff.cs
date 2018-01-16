namespace Architecture.SharedLibrary.DependencyInversion
{
    public class Stuff
    {
        private readonly IHappiness _happiness;
        private readonly ISaddness _saddness;

        public Stuff(IHappiness happiness, ISaddness saddness)
        {
            _happiness = happiness;
            _saddness = saddness;
        }


        public string DoStuffJob()
        {
            return $"{_happiness.GetStatus()}, {_saddness.GetState()}";
        }

    }
}
