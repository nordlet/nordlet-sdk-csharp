using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbP45GetDeclarationsResponseEmployee : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("nino")]
    public string? Nino { get; set; }

    [JsonPropertyName("surname")]
    public required string Surname { get; set; }

    [JsonPropertyName("firstNames")]
    public required string FirstNames { get; set; }

    [JsonPropertyName("leavingDate")]
    public required DateOnly LeavingDate { get; set; }

    [JsonPropertyName("payrollNumber")]
    public string? PayrollNumber { get; set; }

    [JsonPropertyName("gender")]
    public GbP45GetDeclarationsResponseEmployeeGender? Gender { get; set; }

    [JsonPropertyName("dateOfBirth")]
    public string? DateOfBirth { get; set; }

    [JsonPropertyName("address")]
    public IEnumerable<string> Address { get; set; } = new List<string>();

    [JsonPropertyName("postcode")]
    public string? Postcode { get; set; }

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
