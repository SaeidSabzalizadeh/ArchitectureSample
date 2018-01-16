namespace Architecture.SharedLibrary.InterfaceSegregation
{
    public class Settings : ISetting
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Cooperation { get; set; }
        public string Pot { get; set; }
        public string Command { get; set; }
    }
}
