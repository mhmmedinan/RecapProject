using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcers.Logging
{
    public class LogDetail
    {
        public string MethodName { get; set; }
        public List<LogParameter> LogParameters { get; set; }
    }
}
