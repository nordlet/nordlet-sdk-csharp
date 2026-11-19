using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record CompaniesHouseGetPartnersRequest
{
    [JsonPropertyName("companyNumber")]
    public required string CompanyNumber { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
