using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReferenceCnCodesUpsertRequest
{
    [JsonPropertyName("rows")]
    public IEnumerable<PostV1ReferenceCnCodesUpsertRequestRowsItem> Rows { get; set; } =
        new List<PostV1ReferenceCnCodesUpsertRequestRowsItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
