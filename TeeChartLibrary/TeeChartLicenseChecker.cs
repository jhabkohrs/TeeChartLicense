using Steema.TeeChart;

namespace TeeChartLibrary
{
    public class TeeChartLicenseChecker
    {
        public bool IsLicensed()
        {
            return new TChart().Chart.IsLicensed();
        }
    }
}
