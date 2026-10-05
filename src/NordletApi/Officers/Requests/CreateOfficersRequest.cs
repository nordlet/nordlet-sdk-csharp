using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record CreateOfficersRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("role")]
    public required CreateOfficersRequestRole Role { get; set; }

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
