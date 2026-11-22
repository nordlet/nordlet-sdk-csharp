using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsFlsaRecordsListDeclarationsResponseEmployeesItemPayPeriodsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("runId")]
    public required string RunId { get; set; }

    [JsonPropertyName("periodStart")]
    public required string PeriodStart { get; set; }

    [JsonPropertyName("periodEnd")]
    public required string PeriodEnd { get; set; }

    [JsonPropertyName("payDate")]
    public required DateOnly PayDate { get; set; }

    [JsonPropertyName("basisOfPay")]
    public UsFlsaRecordsListDeclarationsResponseEmployeesItemPayPeriodsItemBasisOfPay? BasisOfPay { get; set; }

    [JsonPropertyName("hoursWorked")]
    public string? HoursWorked { get; set; }

    [JsonPropertyName("regularPay")]
    public required string RegularPay { get; set; }

    [JsonPropertyName("overtimePay")]
    public required string OvertimePay { get; set; }

    [JsonPropertyName("overtimeHours")]
    public required string OvertimeHours { get; set; }

    [JsonPropertyName("straightTimeEarnings")]
    public string? StraightTimeEarnings { get; set; }

    [JsonPropertyName("overtimePremium")]
    public string? OvertimePremium { get; set; }

    [JsonPropertyName("additions")]
    public IEnumerable<UsFlsaRecordsListDeclarationsResponseEmployeesItemPayPeriodsItemAdditionsItem> Additions { get; set; } =
        new List<UsFlsaRecordsListDeclarationsResponseEmployeesItemPayPeriodsItemAdditionsItem>();

    [JsonPropertyName("deductions")]
    public IEnumerable<UsFlsaRecordsListDeclarationsResponseEmployeesItemPayPeriodsItemDeductionsItem> Deductions { get; set; } =
        new List<UsFlsaRecordsListDeclarationsResponseEmployeesItemPayPeriodsItemDeductionsItem>();

    [JsonPropertyName("totalWages")]
    public required string TotalWages { get; set; }

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
