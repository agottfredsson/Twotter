using System;
namespace Twotter.Utils
{
    public class XamarinEssentials : IXamarinEssentials
    {
        public double BatteryLevel { get => BatteryLevel.ChargeLevel; }
    }
}
