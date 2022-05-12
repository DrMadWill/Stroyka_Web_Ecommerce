using System;

namespace Stroyka.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string Description { get; set; }

        public int StatusCode { get; set; }
    }
}
