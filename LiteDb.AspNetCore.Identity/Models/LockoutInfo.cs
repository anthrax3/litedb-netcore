﻿using Newtonsoft.Json;
using System;

namespace LiteDb.AspNetCore.Identity.Models
{
    public class LockoutInfo
    {
        public DateTimeOffset? EndDate { get; internal set; }
        public bool Enabled { get; internal set; }
        public int AccessFailedCount { get; internal set; }

        [JsonIgnore]
        public bool AllPropertiesAreSetToDefaults =>
            EndDate == null &&
            Enabled == false &&
            AccessFailedCount == 0;
    }
}