using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PartnersValidateVatRequest
{
    [JsonPropertyName("vatCode")]
    public string? VatCode { get; set; }

    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
