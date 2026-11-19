using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

/// <summary>
/// What the bank gave the company for payment files from this account: the Bacs service user number for a UK account, the ACH Immediate Origin and Company Identification for a US account
/// </summary>
[Serializable]
public record AccountsUpdateBankRequestPaymentFileSettings : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Bacs: the service user number (SUN) of the company for this account
    /// </summary>
    [JsonPropertyName("serviceUserNumber")]
    public string? ServiceUserNumber { get; set; }

    /// <summary>
    /// Bacs: the service user's short name; defaults to the company name
    /// </summary>
    [JsonPropertyName("serviceUserName")]
    public string? ServiceUserName { get; set; }

    /// <summary>
    /// Nacha: the routing number of the bank that receives the file; defaults to the account's bankCode
    /// </summary>
    [JsonPropertyName("odfiRoutingNumber")]
    public string? OdfiRoutingNumber { get; set; }

    /// <summary>
    /// Nacha: the Immediate Origin the bank gave the company
    /// </summary>
    [JsonPropertyName("immediateOrigin")]
    public string? ImmediateOrigin { get; set; }

    /// <summary>
    /// Nacha: the name of the bank that receives the file
    /// </summary>
    [JsonPropertyName("immediateDestinationName")]
    public string? ImmediateDestinationName { get; set; }

    /// <summary>
    /// Nacha: the Company Identification the bank gave the company
    /// </summary>
    [JsonPropertyName("companyIdentification")]
    public string? CompanyIdentification { get; set; }

    /// <summary>
    /// Nacha: the company name shown to the receiver; defaults to the company name
    /// </summary>
    [JsonPropertyName("companyName")]
    public string? CompanyName { get; set; }

    /// <summary>
    /// Nacha: the Company Discretionary Data the bank asks for
    /// </summary>
    [JsonPropertyName("companyDiscretionaryData")]
    public string? CompanyDiscretionaryData { get; set; }

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
