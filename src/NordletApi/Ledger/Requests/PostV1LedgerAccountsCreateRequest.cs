using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1LedgerAccountsCreateRequest
{
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("translations")]
    public PostV1LedgerAccountsCreateRequestTranslations? Translations { get; set; }

    [JsonPropertyName("type")]
    public required PostV1LedgerAccountsCreateRequestType Type { get; set; }

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
