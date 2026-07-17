using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1HrEmployeesRecordsUpdateResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("type")]
    public required PostV1HrEmployeesRecordsUpdateResponseType Type { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("institution")]
    public string? Institution { get; set; }

    [JsonPropertyName("issuedAt")]
    public string? IssuedAt { get; set; }

    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }

    [JsonPropertyName("fileId")]
    public string? FileId { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
