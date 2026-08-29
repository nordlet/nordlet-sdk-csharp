using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;
using OneOf;

namespace NordletApi;

[Serializable]
public record PostV1ProductionWorkCentersListRequestFilterItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("field")]
    public required string Field { get; set; }

    [JsonPropertyName("op")]
    public required PostV1ProductionWorkCentersListRequestFilterItemOp Op { get; set; }

    [JsonPropertyName("value")]
    public required OneOf<
        string,
        double,
        bool,
        IEnumerable<OneOf<string, double>>
    > Value { get; set; }

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
