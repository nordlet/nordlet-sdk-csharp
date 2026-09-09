using global::System.Text.Json.Serialization;
using NordletApi.Core;
using OneOf;

namespace NordletApi;

[Serializable]
public record PostV1CaptureInboundEmailRequest
{
    [JsonPropertyName("To")]
    public string? PostmarkTo { get; set; }

    [JsonPropertyName("ToFull")]
    public IEnumerable<PostV1CaptureInboundEmailRequestToFullItem>? ToFull { get; set; }

    [JsonPropertyName("From")]
    public string? PostmarkFrom { get; set; }

    [JsonPropertyName("Subject")]
    public string? PostmarkSubject { get; set; }

    [JsonPropertyName("Attachments")]
    public IEnumerable<PostV1CaptureInboundEmailRequestAttachmentsItem>? PostmarkAttachments { get; set; }

    [JsonPropertyName("to")]
    public OneOf<string, IEnumerable<string>>? To { get; set; }

    [JsonPropertyName("from")]
    public string? From { get; set; }

    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    [JsonPropertyName("attachments")]
    public IEnumerable<PostV1CaptureInboundEmailRequestAttachmentsItem>? Attachments { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
