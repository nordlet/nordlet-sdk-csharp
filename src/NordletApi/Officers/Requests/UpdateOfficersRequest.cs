using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UpdateOfficersRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("role")]
    public required UpdateOfficersRequestRole Role { get; set; }

    [JsonPropertyName("personalCode")]
    public string? PersonalCode { get; set; }

    [JsonPropertyName("birthDate")]
    public DateOnly? BirthDate { get; set; }

    [JsonPropertyName("appointedOn")]
    public DateOnly? AppointedOn { get; set; }

    [JsonPropertyName("powerNotary")]
    public string? PowerNotary { get; set; }

    [JsonPropertyName("resignedOn")]
    public DateOnly? ResignedOn { get; set; }

    [JsonPropertyName("signsAccounts")]
    public bool? SignsAccounts { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
