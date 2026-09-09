using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1OperationTypesCreateRequest
{
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("invoiceType")]
    public PostV1OperationTypesCreateRequestInvoiceType? InvoiceType { get; set; }

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
    public bool? IsPurchase { get; set; }

    [JsonPropertyName("isSale")]
    public bool? IsSale { get; set; }

    [JsonPropertyName("isWriteOff")]
    public bool? IsWriteOff { get; set; }

    [JsonPropertyName("isInternalMovement")]
    public bool? IsInternalMovement { get; set; }

    [JsonPropertyName("isPurchaseReturn")]
    public bool? IsPurchaseReturn { get; set; }

    [JsonPropertyName("isSalesReturn")]
    public bool? IsSalesReturn { get; set; }

    [JsonPropertyName("isConsignment")]
    public bool? IsConsignment { get; set; }

    [JsonPropertyName("isProduction")]
    public bool? IsProduction { get; set; }

    [JsonPropertyName("isAssetIn")]
    public bool? IsAssetIn { get; set; }

    [JsonPropertyName("isAssetOut")]
    public bool? IsAssetOut { get; set; }

    [JsonPropertyName("isCashRegisterSale")]
    public bool? IsCashRegisterSale { get; set; }

    [JsonPropertyName("includeInVatRegister")]
    public bool? IncludeInVatRegister { get; set; }

    [JsonPropertyName("includeInSaft")]
    public bool? IncludeInSaft { get; set; }

    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }

    [JsonPropertyName("sortOrder")]
    public long? SortOrder { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
