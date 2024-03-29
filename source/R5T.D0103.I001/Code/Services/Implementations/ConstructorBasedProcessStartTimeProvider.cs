﻿using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0103
{
    [ServiceImplementationMarker]
    public class ConstructorBasedProcessStartTimeProvider : IProcessStartTimeProvider, IServiceImplementation
    {
        private DateTime ProcessStartTime { get; }


        public ConstructorBasedProcessStartTimeProvider(
            [NotServiceComponent] DateTime processStartTime)
        {
            this.ProcessStartTime = processStartTime;
        }

        public Task<DateTime> GetProcessStartTime()
        {
            return Task.FromResult(this.ProcessStartTime);
        }
    }
}
