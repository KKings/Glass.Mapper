﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glass.Mapper.Pipelines
{
    /// <summary>
    /// Abstract class that acts as the base class for all arguments passed in pipelines
    /// </summary>
    public abstract class AbstractPipelineArgs
    {
        public Context Context { get; set; }

        public bool IsAborted { get; private set; }

        public bool AbortPipeline ()
        {
            IsAborted = true;
            return IsAborted;
        }
    }
}
