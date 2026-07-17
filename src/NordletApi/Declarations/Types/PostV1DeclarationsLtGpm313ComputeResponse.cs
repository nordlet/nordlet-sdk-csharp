using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtGpm313ComputeResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("declarationYear")]
    public required long DeclarationYear { get; set; }

    [JsonPropertyName("declarationMonth")]
    public required long DeclarationMonth { get; set; }

    [JsonPropertyName("runPeriod")]
    public PostV1DeclarationsLtGpm313ComputeResponseRunPeriod? RunPeriod { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<PostV1DeclarationsLtGpm313ComputeResponseFieldsItem> Fields { get; set; } =
        new List<PostV1DeclarationsLtGpm313ComputeResponseFieldsItem>();

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

    [JsonPropertyName("notes")]
    public IEnumerable<string> Notes { get; set; } = new List<string>();

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
