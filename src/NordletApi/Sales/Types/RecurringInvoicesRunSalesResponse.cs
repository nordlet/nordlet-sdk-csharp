using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record RecurringInvoicesRunSalesResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("generated")]
    public IEnumerable<RecurringInvoicesRunSalesResponseGeneratedItem> Generated { get; set; } =
        new List<RecurringInvoicesRunSalesResponseGeneratedItem>();

    [JsonPropertyName("errors")]
    public IEnumerable<RecurringInvoicesRunSalesResponseErrorsItem> Errors { get; set; } =
        new List<RecurringInvoicesRunSalesResponseErrorsItem>();

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
