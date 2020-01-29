using Reinforced.Typings.Attributes;
using System;

namespace RTBuildError.Models
{
    [TsInterface]
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
