using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record VatClassifiersUpsertReferenceRequest
{
    [JsonPropertyName("rows")]
    public IEnumerable<VatClassifiersUpsertReferenceRequestRowsItem> Rows { get; set; } =
        new List<VatClassifiersUpsertReferenceRequestRowsItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
