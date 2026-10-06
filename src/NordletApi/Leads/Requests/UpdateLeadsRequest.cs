using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UpdateLeadsRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("contactName")]
    public string? ContactName { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("website")]
    public string? Website { get; set; }

    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    [JsonPropertyName("sourceId")]
    public string? SourceId { get; set; }

    [JsonPropertyName("typeId")]
    public string? TypeId { get; set; }

    [JsonPropertyName("status")]
    public UpdateLeadsRequestStatus? Status { get; set; }

    [JsonPropertyName("estimatedValue")]
    public string? EstimatedValue { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("assignedUserId")]
    public string? AssignedUserId { get; set; }

    [JsonPropertyName("documents")]
    public IEnumerable<UpdateLeadsRequestDocumentsItem>? Documents { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
