

using Sample.Didar.Api.Model;

namespace Sample.Didar.Model
{
    public class WebhookMessage 
    {
        public CallNotificationEventType EventType { get; set; }
        public string CallId { get; set; }
        public string CallerNumber { get; set; }
        public string CalleeExtension { get; set; }
        public DateTime DateTime { get; set; }
        public string? TransferredToNumber { get; set; }
        public bool Result { get; set; } = true;
        public string? ClientReferenceId { get; set; }

    }
}
