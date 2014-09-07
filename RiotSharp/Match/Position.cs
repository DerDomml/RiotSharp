﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RiotSharp
{
    /// <summary>
    /// Participant's position (Match API).
    /// </summary>
    [Serializable]
    public class Position
    {
        internal Position() { }

        /// <summary>
        /// Participant's X coordinate.
        /// </summary>
        [JsonProperty("x")]
        public int X { get; set; }

        /// <summary>
        /// Participant's Y coordinate.
        /// </summary>
        [JsonProperty("y")]
        public int Y { get; set; }
    }
}
