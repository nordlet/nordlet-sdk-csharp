using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1OfficersUpdateRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("role")]
    public required PostV1OfficersUpdateRequestRole Role { get; set; }

    [JsonPropertyName("personalCode")]
    public string? PersonalCode { get; set; }

    [JsonPropertyName("birthDate")]
    public string? BirthDate { get; set; }

    [JsonPropertyName("appointedOn")]
    public string? AppointedOn { get; set; }

    [JsonPropertyName("powerNotary")]
    public string? PowerNotary { get; set; }

    [JsonPropertyName("resignedOn")]
    public string? ResignedOn { get; set; }

    [JsonPropertyName("signsAccounts")]
    public bool? SignsAccounts { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
