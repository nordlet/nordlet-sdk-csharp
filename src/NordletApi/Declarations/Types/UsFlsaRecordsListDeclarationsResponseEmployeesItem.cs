using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsFlsaRecordsListDeclarationsResponseEmployeesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("firstName")]
    public required string FirstName { get; set; }

    [JsonPropertyName("lastName")]
    public required string LastName { get; set; }

    [JsonPropertyName("address")]
    public required UsFlsaRecordsListDeclarationsResponseEmployeesItemAddress Address { get; set; }

    [JsonPropertyName("birthDate")]
    public DateOnly? BirthDate { get; set; }

    [JsonPropertyName("sex")]
    public UsFlsaRecordsListDeclarationsResponseEmployeesItemSex? Sex { get; set; }

    [JsonPropertyName("occupation")]
    public string? Occupation { get; set; }

    [JsonPropertyName("workweekStart")]
    public required UsFlsaRecordsListDeclarationsResponseEmployeesItemWorkweekStart WorkweekStart { get; set; }

    [JsonPropertyName("exempt")]
    public required bool Exempt { get; set; }

    [JsonPropertyName("workweeks")]
    public IEnumerable<UsFlsaRecordsListDeclarationsResponseEmployeesItemWorkweeksItem> Workweeks { get; set; } =
        new List<UsFlsaRecordsListDeclarationsResponseEmployeesItemWorkweeksItem>();

    [JsonPropertyName("payPeriods")]
    public IEnumerable<UsFlsaRecordsListDeclarationsResponseEmployeesItemPayPeriodsItem> PayPeriods { get; set; } =
        new List<UsFlsaRecordsListDeclarationsResponseEmployeesItemPayPeriodsItem>();

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
