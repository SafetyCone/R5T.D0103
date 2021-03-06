using System;
using System.Diagnostics;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0103.I001
{
    [ServiceImplementationMarker]
    public class CurrentProcessStartTimeProvider : ICurrentProcessStartTimeProvider, IServiceImplementation
    {
        public Task<DateTime> GetCurrentProcessStartTime()
        {
            var currentProcess = Process.GetCurrentProcess();

            var currentProcessStartTime = currentProcess.StartTime;

            return Task.FromResult(currentProcessStartTime);
        }
    }
}
