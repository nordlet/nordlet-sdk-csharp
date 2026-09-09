using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1LeadsNotesCreateRequest
{
    [JsonPropertyName("leadId")]
    public required string LeadId { get; set; }

    [JsonPropertyName("body")]
    public required string Body { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
