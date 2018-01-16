namespace Architecture.SharedLibrary.DependencyInversion
{
    public class SaddnessService : ISaddness
    {
        public string GetState()
        {
            return "Sadness State!";
        }
    }
}
