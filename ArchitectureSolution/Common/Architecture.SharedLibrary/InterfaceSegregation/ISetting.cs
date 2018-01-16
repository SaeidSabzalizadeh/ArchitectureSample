using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.SharedLibrary.InterfaceSegregation
{
    public interface ISetting : IAppliedSetting, IConfigSetting
    {
        string Name { get; set; }
    }

    public interface IAppliedSetting
    {
        string Age { get; set; }
        string Cooperation { get; set; }
    }

    public interface IConfigSetting
    {

        string Pot { get; set; }
        string Command { get; set; }
    }
}
