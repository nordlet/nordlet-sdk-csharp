using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1OperationTypesGetResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("invoiceType")]
    public PostV1OperationTypesGetResponseInvoiceType? InvoiceType { get; set; }

    [JsonPropertyName("payerPartnerId")]
    public string? PayerPartnerId { get; set; }

    [JsonPropertyName("debitAccountCode")]
    public string? DebitAccountCode { get; set; }

    [JsonPropertyName("creditAccountCode")]
    public string? CreditAccountCode { get; set; }

    [JsonPropertyName("vatAccountCode")]
    public string? VatAccountCode { get; set; }

    [JsonPropertyName("expenseAccountCode")]
    public string? ExpenseAccountCode { get; set; }

    [JsonPropertyName("advanceAccountCode")]
    public string? AdvanceAccountCode { get; set; }

    [JsonPropertyName("incomeAccountCode")]
    public string? IncomeAccountCode { get; set; }

    [JsonPropertyName("isPurchase")]
    public required bool IsPurchase { get; set; }

    [JsonPropertyName("isSale")]
    public required bool IsSale { get; set; }

    [JsonPropertyName("isWriteOff")]
    public required bool IsWriteOff { get; set; }

    [JsonPropertyName("isInternalMovement")]
    public required bool IsInternalMovement { get; set; }

    [JsonPropertyName("isPurchaseReturn")]
    public required bool IsPurchaseReturn { get; set; }

    [JsonPropertyName("isSalesReturn")]
    public required bool IsSalesReturn { get; set; }

    [JsonPropertyName("isConsignment")]
    public required bool IsConsignment { get; set; }

    [JsonPropertyName("isProduction")]
    public required bool IsProduction { get; set; }

    [JsonPropertyName("isAssetIn")]
    public required bool IsAssetIn { get; set; }

    [JsonPropertyName("isAssetOut")]
    public required bool IsAssetOut { get; set; }

    [JsonPropertyName("isCashRegisterSale")]
    public required bool IsCashRegisterSale { get; set; }

    [JsonPropertyName("includeInVatRegister")]
    public required bool IncludeInVatRegister { get; set; }

    [JsonPropertyName("includeInSaft")]
    public required bool IncludeInSaft { get; set; }

    [JsonPropertyName("isActive")]
    public required bool IsActive { get; set; }

    [JsonPropertyName("sortOrder")]
    public required long SortOrder { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required string UpdatedAt { get; set; }

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
