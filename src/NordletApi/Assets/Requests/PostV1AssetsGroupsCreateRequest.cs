using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AssetsGroupsCreateRequest
{
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("defaultUsefulLifeMonths")]
    public long? DefaultUsefulLifeMonths { get; set; }

    [JsonPropertyName("assetAccountCode")]
    public required string AssetAccountCode { get; set; }

    [JsonPropertyName("depreciationAccountCode")]
    public required string DepreciationAccountCode { get; set; }

    [JsonPropertyName("expenseAccountCode")]
    public string? ExpenseAccountCode { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
