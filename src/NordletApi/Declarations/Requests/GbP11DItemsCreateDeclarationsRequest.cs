using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbP11DItemsCreateDeclarationsRequest
{
    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("taxYear")]
    public required long TaxYear { get; set; }

    [JsonPropertyName("item")]
    public required GbP11DItemsCreateDeclarationsRequestItem Item { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
