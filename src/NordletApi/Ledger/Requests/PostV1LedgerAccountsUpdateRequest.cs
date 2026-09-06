using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1LedgerAccountsUpdateRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("translations")]
    public PostV1LedgerAccountsUpdateRequestTranslations? Translations { get; set; }

    [JsonPropertyName("parentId")]
    public string? ParentId { get; set; }

    [JsonPropertyName("isPostable")]
    public bool? IsPostable { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
