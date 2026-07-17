using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AuditListResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required long Id { get; set; }

    [JsonPropertyName("actorType")]
    public required PostV1AuditListResponseRowsItemActorType ActorType { get; set; }

    [JsonPropertyName("actorId")]
    public string? ActorId { get; set; }

    [JsonPropertyName("action")]
    public required string Action { get; set; }

    [JsonPropertyName("entity")]
    public required string Entity { get; set; }

    [JsonPropertyName("entityId")]
    public string? EntityId { get; set; }

    [JsonPropertyName("diff")]
    public object? Diff { get; set; }

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
