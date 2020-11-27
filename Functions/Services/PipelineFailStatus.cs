﻿using System;
using System.Collections.Generic;
using System.Text;

namespace mrpaulandrew.azure.procfwk.Services
{
    public class PipelineFailStatus : PipelineRunStatus
    {
        public PipelineFailStatus()
        {
            Errors = new List<FailedActivity>();
        }
        public int ResponseCount { get; set; }
        public int ResponseErrorCount
        {
            get
            {
                return Errors.Count;
            }
        }
        public List<FailedActivity> Errors { get; }
    }

    public class FailedActivity
    {
        public string ActivityRunId { get; internal set; }
        public string ActivityName { get; internal set; }
        public string ActivityType { get; internal set; }
        public string ErrorCode { get; internal set; }
        public string ErrorType { get; internal set; }
        public string ErrorMessage { get; internal set; }
    }
}
