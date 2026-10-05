using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record CnCodesUpsertReferenceRequest
{
    [JsonPropertyName("rows")]
    public IEnumerable<CnCodesUpsertReferenceRequestRowsItem> Rows { get; set; } =
        new List<CnCodesUpsertReferenceRequestRowsItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
