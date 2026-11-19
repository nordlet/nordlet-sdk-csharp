using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsWorkweeksListDeclarationsResponseEmployeesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("firstName")]
    public required string FirstName { get; set; }

    [JsonPropertyName("lastName")]
    public required string LastName { get; set; }

    [JsonPropertyName("workweekStart")]
    public required string WorkweekStart { get; set; }

    [JsonPropertyName("exempt")]
    public required bool Exempt { get; set; }

    [JsonPropertyName("weeks")]
    public IEnumerable<UsWorkweeksListDeclarationsResponseEmployeesItemWeeksItem> Weeks { get; set; } =
        new List<UsWorkweeksListDeclarationsResponseEmployeesItemWeeksItem>();

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
