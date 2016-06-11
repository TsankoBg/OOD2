﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes
{
    class Pipe : Component
    {
        // a pipe has an input and an output
        Component inPutA { get; set; }
        Component outPutA { get; set; }

        private int safetyLimit;
        public int SafetyLimit
        {
            get
            {
                return safetyLimit;

            }
            set
            {
                safetyLimit = value;
            }
        }
        // constructor
        public Pipe(PointP loc) : base(loc)
        {
        }
        /// <summary>
        /// returnes the  safety limit
        /// </summary>
        /// <returns></returns>
        public int GetSafetyLimit()
        {
            return SafetyLimit;
        }
        /// <summary>
        /// sets the safety limit to the given value 
        /// </summary>
        /// <param name="limit"></param>
        public void SetSafetyLimit(int limit)
        {

            this.SafetyLimit = limit;
        }
    }
}
