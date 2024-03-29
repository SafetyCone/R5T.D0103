﻿using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0103
{
    [ServiceImplementationMarker]
    public class StaticValuedProcessStartTimeProvider : IProcessStartTimeProvider, IServiceImplementation
    {
        public static DateTime ProcessStartTime { get; set; }


        public Task<DateTime> GetProcessStartTime()
        {
            return Task.FromResult(StaticValuedProcessStartTimeProvider.ProcessStartTime);
        }
    }
}
