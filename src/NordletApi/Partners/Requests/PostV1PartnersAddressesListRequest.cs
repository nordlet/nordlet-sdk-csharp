using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PartnersAddressesListRequest
{
    [JsonPropertyName("page")]
    public long? Page { get; set; }

    [JsonPropertyName("pageSize")]
    public long? PageSize { get; set; }

    [JsonPropertyName("sort")]
    public IEnumerable<PostV1PartnersAddressesListRequestSortItem>? Sort { get; set; }

    [JsonPropertyName("filter")]
    public IEnumerable<PostV1PartnersAddressesListRequestFilterItem>? Filter { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
