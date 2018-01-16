using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.SharedLibrary.InterfaceSegregation
{
    public class UseSettings
    {

        private readonly IAppliedSetting _appliedSetting;
        private readonly IConfigSetting _configSetting;

        public UseSettings(IAppliedSetting appliedSetting, IConfigSetting configSetting)
        {

            _appliedSetting = appliedSetting;
            _configSetting = configSetting;
        }


        public string GetJobValue()
        {

            return $"Age: {_appliedSetting.Age}, Cooperation: {_appliedSetting.Cooperation} - Pot: {_configSetting.Pot}, Command: {_configSetting.Command}";
        }


    }


    public class TestUseSettings
    {

        public class AppliedSetting : IAppliedSetting
        {
            public string Age { get; set; }
            public string Cooperation { get; set; }
        }


        public static void Test()
        {
            var settings1 = new Settings() { Age = "125", Command = "Command1", Pot = "Pot123", Cooperation = "My Co.", Name = "LOL" };
            var settings2 = new Settings() { Age = "478", Command = "Command2", Pot = "Pot456", Cooperation = "Your Co.", Name = "NON" };
            var settings3 = new AppliedSetting() { Age = "798", Cooperation = "Our Co." };

            var use1 = new UseSettings(settings1, settings1);
            Console.WriteLine(use1.GetJobValue());


            var use2 = new UseSettings(settings1, settings2);
            Console.WriteLine(use2.GetJobValue());


            var use3 = new UseSettings(settings3, settings2);
            Console.WriteLine(use3.GetJobValue());

        }





    }



}
