namespace Architecture.SharedLibrary.DependencyInversion
{
    public class HappinessService : IHappiness
    {
        public string GetStatus()
        {
            return "Happy Status!";
        }
    }
}
