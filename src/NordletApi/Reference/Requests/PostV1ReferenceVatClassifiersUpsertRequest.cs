using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReferenceVatClassifiersUpsertRequest
{
    [JsonPropertyName("rows")]
    public IEnumerable<PostV1ReferenceVatClassifiersUpsertRequestRowsItem> Rows { get; set; } =
        new List<PostV1ReferenceVatClassifiersUpsertRequestRowsItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
