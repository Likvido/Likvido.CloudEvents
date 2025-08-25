using System;
using System.Collections.Generic;

namespace Likvido.CloudEvents
{
    /// <summary>
    /// Implementation of a cloud event, using v1.0
    /// Spec: https://github.com/cloudevents/spec/blob/v1.0/spec.md
    /// </summary>
    public class CloudEvent
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Source { get; set; }
        public string Type { get; set; }
        public DateTime? Time { get; set; }
        public string SpecVersion { get; set; } = "1.0";

        // Custom optional attribute extensions (only string, bool, byte, int, Uri, DateTime, or DateTimeOffset are allowed)
        public LikvidoPriority? LikvidoPriority { get; set; }
        public string LikvidoUserClaimsString { get; set; }
    }

    public class CloudEvent<TMessage> : CloudEvent
    {
        public TMessage Data { get; set; }
    }
}
