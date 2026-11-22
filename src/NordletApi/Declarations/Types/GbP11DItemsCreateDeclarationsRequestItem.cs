// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(GbP11DItemsCreateDeclarationsRequestItem.JsonConverter))]
[Serializable]
public record GbP11DItemsCreateDeclarationsRequestItem
{
    internal GbP11DItemsCreateDeclarationsRequestItem(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.AssetTransferred"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.AssetTransferred value
    )
    {
        Type = "asset-transferred";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.Payment"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.Payment value
    )
    {
        Type = "payment";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.TaxOnNotionalPayments"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.TaxOnNotionalPayments value
    )
    {
        Type = "tax-on-notional-payments";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.VouchersOrCreditCards"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.VouchersOrCreditCards value
    )
    {
        Type = "vouchers-or-credit-cards";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.LivingAccommodation"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.LivingAccommodation value
    )
    {
        Type = "living-accommodation";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.MileageAllowance"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.MileageAllowance value
    )
    {
        Type = "mileage-allowance";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.Car"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.Car value
    )
    {
        Type = "car";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.Vans"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.Vans value
    )
    {
        Type = "vans";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.Loan"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.Loan value
    )
    {
        Type = "loan";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.Medical"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.Medical value
    )
    {
        Type = "medical";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.Relocation"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.Relocation value
    )
    {
        Type = "relocation";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.Services"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.Services value
    )
    {
        Type = "services";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.AssetAvailable"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.AssetAvailable value
    )
    {
        Type = "asset-available";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.OtherClass1A"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.OtherClass1A value
    )
    {
        Type = "other-class-1a";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.OtherNonClass1A"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.OtherNonClass1A value
    )
    {
        Type = "other-non-class-1a";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.TaxPaidNotDeducted"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.TaxPaidNotDeducted value
    )
    {
        Type = "tax-paid-not-deducted";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.ExpensesTravelAndSubsistence"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.ExpensesTravelAndSubsistence value
    )
    {
        Type = "expenses-travel-and-subsistence";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.ExpensesEntertainment"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.ExpensesEntertainment value
    )
    {
        Type = "expenses-entertainment";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.ExpensesHomeTelephone"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.ExpensesHomeTelephone value
    )
    {
        Type = "expenses-home-telephone";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.ExpensesNonQualifyingRelocation"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.ExpensesNonQualifyingRelocation value
    )
    {
        Type = "expenses-non-qualifying-relocation";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsRequestItem with <see cref="GbP11DItemsCreateDeclarationsRequestItem.ExpensesOther"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.ExpensesOther value
    )
    {
        Type = "expenses-other";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="Type"/> is "asset-transferred"
    /// </summary>
    public bool IsAssetTransferred => Type == "asset-transferred";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "payment"
    /// </summary>
    public bool IsPayment => Type == "payment";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "tax-on-notional-payments"
    /// </summary>
    public bool IsTaxOnNotionalPayments => Type == "tax-on-notional-payments";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "vouchers-or-credit-cards"
    /// </summary>
    public bool IsVouchersOrCreditCards => Type == "vouchers-or-credit-cards";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "living-accommodation"
    /// </summary>
    public bool IsLivingAccommodation => Type == "living-accommodation";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "mileage-allowance"
    /// </summary>
    public bool IsMileageAllowance => Type == "mileage-allowance";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "car"
    /// </summary>
    public bool IsCar => Type == "car";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "vans"
    /// </summary>
    public bool IsVans => Type == "vans";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "loan"
    /// </summary>
    public bool IsLoan => Type == "loan";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "medical"
    /// </summary>
    public bool IsMedical => Type == "medical";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "relocation"
    /// </summary>
    public bool IsRelocation => Type == "relocation";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "services"
    /// </summary>
    public bool IsServices => Type == "services";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "asset-available"
    /// </summary>
    public bool IsAssetAvailable => Type == "asset-available";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "other-class-1a"
    /// </summary>
    public bool IsOtherClass1A => Type == "other-class-1a";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "other-non-class-1a"
    /// </summary>
    public bool IsOtherNonClass1A => Type == "other-non-class-1a";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "tax-paid-not-deducted"
    /// </summary>
    public bool IsTaxPaidNotDeducted => Type == "tax-paid-not-deducted";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "expenses-travel-and-subsistence"
    /// </summary>
    public bool IsExpensesTravelAndSubsistence => Type == "expenses-travel-and-subsistence";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "expenses-entertainment"
    /// </summary>
    public bool IsExpensesEntertainment => Type == "expenses-entertainment";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "expenses-home-telephone"
    /// </summary>
    public bool IsExpensesHomeTelephone => Type == "expenses-home-telephone";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "expenses-non-qualifying-relocation"
    /// </summary>
    public bool IsExpensesNonQualifyingRelocation => Type == "expenses-non-qualifying-relocation";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "expenses-other"
    /// </summary>
    public bool IsExpensesOther => Type == "expenses-other";

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetTransferred"/> if <see cref="Type"/> is 'asset-transferred', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'asset-transferred'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetTransferred AsAssetTransferred() =>
        IsAssetTransferred
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetTransferred)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'asset-transferred'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemPayment"/> if <see cref="Type"/> is 'payment', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'payment'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemPayment AsPayment() =>
        IsPayment
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemPayment)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'payment'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxOnNotionalPayments"/> if <see cref="Type"/> is 'tax-on-notional-payments', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'tax-on-notional-payments'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxOnNotionalPayments AsTaxOnNotionalPayments() =>
        IsTaxOnNotionalPayments
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxOnNotionalPayments)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'tax-on-notional-payments'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemVouchersOrCreditCards"/> if <see cref="Type"/> is 'vouchers-or-credit-cards', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'vouchers-or-credit-cards'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemVouchersOrCreditCards AsVouchersOrCreditCards() =>
        IsVouchersOrCreditCards
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemVouchersOrCreditCards)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'vouchers-or-credit-cards'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemLivingAccommodation"/> if <see cref="Type"/> is 'living-accommodation', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'living-accommodation'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemLivingAccommodation AsLivingAccommodation() =>
        IsLivingAccommodation
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemLivingAccommodation)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'living-accommodation'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemMileageAllowance"/> if <see cref="Type"/> is 'mileage-allowance', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'mileage-allowance'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemMileageAllowance AsMileageAllowance() =>
        IsMileageAllowance
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemMileageAllowance)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'mileage-allowance'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemCar"/> if <see cref="Type"/> is 'car', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'car'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemCar AsCar() =>
        IsCar
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemCar)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'car'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemVans"/> if <see cref="Type"/> is 'vans', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'vans'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemVans AsVans() =>
        IsVans
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemVans)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'vans'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemLoan"/> if <see cref="Type"/> is 'loan', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'loan'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemLoan AsLoan() =>
        IsLoan
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemLoan)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'loan'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemMedical"/> if <see cref="Type"/> is 'medical', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'medical'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemMedical AsMedical() =>
        IsMedical
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemMedical)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'medical'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemRelocation"/> if <see cref="Type"/> is 'relocation', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'relocation'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemRelocation AsRelocation() =>
        IsRelocation
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemRelocation)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'relocation'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemServices"/> if <see cref="Type"/> is 'services', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'services'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemServices AsServices() =>
        IsServices
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemServices)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'services'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetAvailable"/> if <see cref="Type"/> is 'asset-available', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'asset-available'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetAvailable AsAssetAvailable() =>
        IsAssetAvailable
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetAvailable)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'asset-available'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherClass1A"/> if <see cref="Type"/> is 'other-class-1a', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'other-class-1a'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherClass1A AsOtherClass1A() =>
        IsOtherClass1A
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherClass1A)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'other-class-1a'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1A"/> if <see cref="Type"/> is 'other-non-class-1a', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'other-non-class-1a'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1A AsOtherNonClass1A() =>
        IsOtherNonClass1A
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1A)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'other-non-class-1a'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxPaidNotDeducted"/> if <see cref="Type"/> is 'tax-paid-not-deducted', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'tax-paid-not-deducted'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxPaidNotDeducted AsTaxPaidNotDeducted() =>
        IsTaxPaidNotDeducted
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxPaidNotDeducted)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'tax-paid-not-deducted'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesTravelAndSubsistence"/> if <see cref="Type"/> is 'expenses-travel-and-subsistence', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'expenses-travel-and-subsistence'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesTravelAndSubsistence AsExpensesTravelAndSubsistence() =>
        IsExpensesTravelAndSubsistence
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesTravelAndSubsistence)
                Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'expenses-travel-and-subsistence'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesEntertainment"/> if <see cref="Type"/> is 'expenses-entertainment', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'expenses-entertainment'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesEntertainment AsExpensesEntertainment() =>
        IsExpensesEntertainment
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesEntertainment)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'expenses-entertainment'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesHomeTelephone"/> if <see cref="Type"/> is 'expenses-home-telephone', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'expenses-home-telephone'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesHomeTelephone AsExpensesHomeTelephone() =>
        IsExpensesHomeTelephone
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesHomeTelephone)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'expenses-home-telephone'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesNonQualifyingRelocation"/> if <see cref="Type"/> is 'expenses-non-qualifying-relocation', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'expenses-non-qualifying-relocation'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesNonQualifyingRelocation AsExpensesNonQualifyingRelocation() =>
        IsExpensesNonQualifyingRelocation
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesNonQualifyingRelocation)
                Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'expenses-non-qualifying-relocation'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesOther"/> if <see cref="Type"/> is 'expenses-other', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'expenses-other'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesOther AsExpensesOther() =>
        IsExpensesOther
            ? (NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesOther)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsRequestItem.Type is not 'expenses-other'"
            );

    public T Match<T>(
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetTransferred,
            T
        > onAssetTransferred,
        Func<NordletApi.GbP11DItemsCreateDeclarationsRequestItemPayment, T> onPayment,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxOnNotionalPayments,
            T
        > onTaxOnNotionalPayments,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemVouchersOrCreditCards,
            T
        > onVouchersOrCreditCards,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemLivingAccommodation,
            T
        > onLivingAccommodation,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemMileageAllowance,
            T
        > onMileageAllowance,
        Func<NordletApi.GbP11DItemsCreateDeclarationsRequestItemCar, T> onCar,
        Func<NordletApi.GbP11DItemsCreateDeclarationsRequestItemVans, T> onVans,
        Func<NordletApi.GbP11DItemsCreateDeclarationsRequestItemLoan, T> onLoan,
        Func<NordletApi.GbP11DItemsCreateDeclarationsRequestItemMedical, T> onMedical,
        Func<NordletApi.GbP11DItemsCreateDeclarationsRequestItemRelocation, T> onRelocation,
        Func<NordletApi.GbP11DItemsCreateDeclarationsRequestItemServices, T> onServices,
        Func<NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetAvailable, T> onAssetAvailable,
        Func<NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherClass1A, T> onOtherClass1A,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1A,
            T
        > onOtherNonClass1A,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxPaidNotDeducted,
            T
        > onTaxPaidNotDeducted,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesTravelAndSubsistence,
            T
        > onExpensesTravelAndSubsistence,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesEntertainment,
            T
        > onExpensesEntertainment,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesHomeTelephone,
            T
        > onExpensesHomeTelephone,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesNonQualifyingRelocation,
            T
        > onExpensesNonQualifyingRelocation,
        Func<NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesOther, T> onExpensesOther,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "asset-transferred" => onAssetTransferred(AsAssetTransferred()),
            "payment" => onPayment(AsPayment()),
            "tax-on-notional-payments" => onTaxOnNotionalPayments(AsTaxOnNotionalPayments()),
            "vouchers-or-credit-cards" => onVouchersOrCreditCards(AsVouchersOrCreditCards()),
            "living-accommodation" => onLivingAccommodation(AsLivingAccommodation()),
            "mileage-allowance" => onMileageAllowance(AsMileageAllowance()),
            "car" => onCar(AsCar()),
            "vans" => onVans(AsVans()),
            "loan" => onLoan(AsLoan()),
            "medical" => onMedical(AsMedical()),
            "relocation" => onRelocation(AsRelocation()),
            "services" => onServices(AsServices()),
            "asset-available" => onAssetAvailable(AsAssetAvailable()),
            "other-class-1a" => onOtherClass1A(AsOtherClass1A()),
            "other-non-class-1a" => onOtherNonClass1A(AsOtherNonClass1A()),
            "tax-paid-not-deducted" => onTaxPaidNotDeducted(AsTaxPaidNotDeducted()),
            "expenses-travel-and-subsistence" => onExpensesTravelAndSubsistence(
                AsExpensesTravelAndSubsistence()
            ),
            "expenses-entertainment" => onExpensesEntertainment(AsExpensesEntertainment()),
            "expenses-home-telephone" => onExpensesHomeTelephone(AsExpensesHomeTelephone()),
            "expenses-non-qualifying-relocation" => onExpensesNonQualifyingRelocation(
                AsExpensesNonQualifyingRelocation()
            ),
            "expenses-other" => onExpensesOther(AsExpensesOther()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetTransferred> onAssetTransferred,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemPayment> onPayment,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxOnNotionalPayments> onTaxOnNotionalPayments,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemVouchersOrCreditCards> onVouchersOrCreditCards,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemLivingAccommodation> onLivingAccommodation,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemMileageAllowance> onMileageAllowance,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemCar> onCar,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemVans> onVans,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemLoan> onLoan,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemMedical> onMedical,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemRelocation> onRelocation,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemServices> onServices,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetAvailable> onAssetAvailable,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherClass1A> onOtherClass1A,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1A> onOtherNonClass1A,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxPaidNotDeducted> onTaxPaidNotDeducted,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesTravelAndSubsistence> onExpensesTravelAndSubsistence,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesEntertainment> onExpensesEntertainment,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesHomeTelephone> onExpensesHomeTelephone,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesNonQualifyingRelocation> onExpensesNonQualifyingRelocation,
        Action<NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesOther> onExpensesOther,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "asset-transferred":
                onAssetTransferred(AsAssetTransferred());
                break;
            case "payment":
                onPayment(AsPayment());
                break;
            case "tax-on-notional-payments":
                onTaxOnNotionalPayments(AsTaxOnNotionalPayments());
                break;
            case "vouchers-or-credit-cards":
                onVouchersOrCreditCards(AsVouchersOrCreditCards());
                break;
            case "living-accommodation":
                onLivingAccommodation(AsLivingAccommodation());
                break;
            case "mileage-allowance":
                onMileageAllowance(AsMileageAllowance());
                break;
            case "car":
                onCar(AsCar());
                break;
            case "vans":
                onVans(AsVans());
                break;
            case "loan":
                onLoan(AsLoan());
                break;
            case "medical":
                onMedical(AsMedical());
                break;
            case "relocation":
                onRelocation(AsRelocation());
                break;
            case "services":
                onServices(AsServices());
                break;
            case "asset-available":
                onAssetAvailable(AsAssetAvailable());
                break;
            case "other-class-1a":
                onOtherClass1A(AsOtherClass1A());
                break;
            case "other-non-class-1a":
                onOtherNonClass1A(AsOtherNonClass1A());
                break;
            case "tax-paid-not-deducted":
                onTaxPaidNotDeducted(AsTaxPaidNotDeducted());
                break;
            case "expenses-travel-and-subsistence":
                onExpensesTravelAndSubsistence(AsExpensesTravelAndSubsistence());
                break;
            case "expenses-entertainment":
                onExpensesEntertainment(AsExpensesEntertainment());
                break;
            case "expenses-home-telephone":
                onExpensesHomeTelephone(AsExpensesHomeTelephone());
                break;
            case "expenses-non-qualifying-relocation":
                onExpensesNonQualifyingRelocation(AsExpensesNonQualifyingRelocation());
                break;
            case "expenses-other":
                onExpensesOther(AsExpensesOther());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetTransferred"/> and returns true if successful.
    /// </summary>
    public bool TryAsAssetTransferred(
        out NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetTransferred? value
    )
    {
        if (Type == "asset-transferred")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetTransferred)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemPayment"/> and returns true if successful.
    /// </summary>
    public bool TryAsPayment(out NordletApi.GbP11DItemsCreateDeclarationsRequestItemPayment? value)
    {
        if (Type == "payment")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemPayment)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxOnNotionalPayments"/> and returns true if successful.
    /// </summary>
    public bool TryAsTaxOnNotionalPayments(
        out NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxOnNotionalPayments? value
    )
    {
        if (Type == "tax-on-notional-payments")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxOnNotionalPayments)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemVouchersOrCreditCards"/> and returns true if successful.
    /// </summary>
    public bool TryAsVouchersOrCreditCards(
        out NordletApi.GbP11DItemsCreateDeclarationsRequestItemVouchersOrCreditCards? value
    )
    {
        if (Type == "vouchers-or-credit-cards")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemVouchersOrCreditCards)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemLivingAccommodation"/> and returns true if successful.
    /// </summary>
    public bool TryAsLivingAccommodation(
        out NordletApi.GbP11DItemsCreateDeclarationsRequestItemLivingAccommodation? value
    )
    {
        if (Type == "living-accommodation")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemLivingAccommodation)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemMileageAllowance"/> and returns true if successful.
    /// </summary>
    public bool TryAsMileageAllowance(
        out NordletApi.GbP11DItemsCreateDeclarationsRequestItemMileageAllowance? value
    )
    {
        if (Type == "mileage-allowance")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemMileageAllowance)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemCar"/> and returns true if successful.
    /// </summary>
    public bool TryAsCar(out NordletApi.GbP11DItemsCreateDeclarationsRequestItemCar? value)
    {
        if (Type == "car")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemCar)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemVans"/> and returns true if successful.
    /// </summary>
    public bool TryAsVans(out NordletApi.GbP11DItemsCreateDeclarationsRequestItemVans? value)
    {
        if (Type == "vans")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemVans)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemLoan"/> and returns true if successful.
    /// </summary>
    public bool TryAsLoan(out NordletApi.GbP11DItemsCreateDeclarationsRequestItemLoan? value)
    {
        if (Type == "loan")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemLoan)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemMedical"/> and returns true if successful.
    /// </summary>
    public bool TryAsMedical(out NordletApi.GbP11DItemsCreateDeclarationsRequestItemMedical? value)
    {
        if (Type == "medical")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemMedical)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemRelocation"/> and returns true if successful.
    /// </summary>
    public bool TryAsRelocation(
        out NordletApi.GbP11DItemsCreateDeclarationsRequestItemRelocation? value
    )
    {
        if (Type == "relocation")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemRelocation)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemServices"/> and returns true if successful.
    /// </summary>
    public bool TryAsServices(
        out NordletApi.GbP11DItemsCreateDeclarationsRequestItemServices? value
    )
    {
        if (Type == "services")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemServices)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetAvailable"/> and returns true if successful.
    /// </summary>
    public bool TryAsAssetAvailable(
        out NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetAvailable? value
    )
    {
        if (Type == "asset-available")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetAvailable)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherClass1A"/> and returns true if successful.
    /// </summary>
    public bool TryAsOtherClass1A(
        out NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherClass1A? value
    )
    {
        if (Type == "other-class-1a")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherClass1A)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1A"/> and returns true if successful.
    /// </summary>
    public bool TryAsOtherNonClass1A(
        out NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1A? value
    )
    {
        if (Type == "other-non-class-1a")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1A)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxPaidNotDeducted"/> and returns true if successful.
    /// </summary>
    public bool TryAsTaxPaidNotDeducted(
        out NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxPaidNotDeducted? value
    )
    {
        if (Type == "tax-paid-not-deducted")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxPaidNotDeducted)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesTravelAndSubsistence"/> and returns true if successful.
    /// </summary>
    public bool TryAsExpensesTravelAndSubsistence(
        out NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesTravelAndSubsistence? value
    )
    {
        if (Type == "expenses-travel-and-subsistence")
        {
            value =
                (NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesTravelAndSubsistence)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesEntertainment"/> and returns true if successful.
    /// </summary>
    public bool TryAsExpensesEntertainment(
        out NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesEntertainment? value
    )
    {
        if (Type == "expenses-entertainment")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesEntertainment)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesHomeTelephone"/> and returns true if successful.
    /// </summary>
    public bool TryAsExpensesHomeTelephone(
        out NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesHomeTelephone? value
    )
    {
        if (Type == "expenses-home-telephone")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesHomeTelephone)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesNonQualifyingRelocation"/> and returns true if successful.
    /// </summary>
    public bool TryAsExpensesNonQualifyingRelocation(
        out NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesNonQualifyingRelocation? value
    )
    {
        if (Type == "expenses-non-qualifying-relocation")
        {
            value =
                (NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesNonQualifyingRelocation)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesOther"/> and returns true if successful.
    /// </summary>
    public bool TryAsExpensesOther(
        out NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesOther? value
    )
    {
        if (Type == "expenses-other")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesOther)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.AssetTransferred value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.Payment value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.TaxOnNotionalPayments value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.VouchersOrCreditCards value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.LivingAccommodation value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.MileageAllowance value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.Car value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.Vans value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.Loan value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.Medical value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.Relocation value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.Services value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.AssetAvailable value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.OtherClass1A value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.OtherNonClass1A value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.TaxPaidNotDeducted value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.ExpensesTravelAndSubsistence value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.ExpensesEntertainment value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.ExpensesHomeTelephone value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.ExpensesNonQualifyingRelocation value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsRequestItem(
        GbP11DItemsCreateDeclarationsRequestItem.ExpensesOther value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<GbP11DItemsCreateDeclarationsRequestItem>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(GbP11DItemsCreateDeclarationsRequestItem).IsAssignableFrom(typeToConvert);

        public override GbP11DItemsCreateDeclarationsRequestItem Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("type", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'type'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'type' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'type' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'type' is null");

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("type");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "asset-transferred" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetTransferred?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetTransferred"
                        ),
                "payment" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemPayment?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemPayment"
                        ),
                "tax-on-notional-payments" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxOnNotionalPayments?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxOnNotionalPayments"
                        ),
                "vouchers-or-credit-cards" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemVouchersOrCreditCards?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemVouchersOrCreditCards"
                        ),
                "living-accommodation" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemLivingAccommodation?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemLivingAccommodation"
                        ),
                "mileage-allowance" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemMileageAllowance?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemMileageAllowance"
                        ),
                "car" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemCar?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemCar"
                        ),
                "vans" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemVans?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemVans"
                        ),
                "loan" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemLoan?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemLoan"
                        ),
                "medical" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemMedical?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemMedical"
                        ),
                "relocation" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemRelocation?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemRelocation"
                        ),
                "services" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemServices?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemServices"
                        ),
                "asset-available" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetAvailable?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetAvailable"
                        ),
                "other-class-1a" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherClass1A?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherClass1A"
                        ),
                "other-non-class-1a" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1A?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1A"
                        ),
                "tax-paid-not-deducted" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxPaidNotDeducted?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxPaidNotDeducted"
                        ),
                "expenses-travel-and-subsistence" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesTravelAndSubsistence?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesTravelAndSubsistence"
                        ),
                "expenses-entertainment" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesEntertainment?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesEntertainment"
                        ),
                "expenses-home-telephone" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesHomeTelephone?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesHomeTelephone"
                        ),
                "expenses-non-qualifying-relocation" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesNonQualifyingRelocation?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesNonQualifyingRelocation"
                        ),
                "expenses-other" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesOther?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesOther"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new GbP11DItemsCreateDeclarationsRequestItem(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GbP11DItemsCreateDeclarationsRequestItem value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "asset-transferred" => JsonSerializer.SerializeToNode(value.Value, options),
                    "payment" => JsonSerializer.SerializeToNode(value.Value, options),
                    "tax-on-notional-payments" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "vouchers-or-credit-cards" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "living-accommodation" => JsonSerializer.SerializeToNode(value.Value, options),
                    "mileage-allowance" => JsonSerializer.SerializeToNode(value.Value, options),
                    "car" => JsonSerializer.SerializeToNode(value.Value, options),
                    "vans" => JsonSerializer.SerializeToNode(value.Value, options),
                    "loan" => JsonSerializer.SerializeToNode(value.Value, options),
                    "medical" => JsonSerializer.SerializeToNode(value.Value, options),
                    "relocation" => JsonSerializer.SerializeToNode(value.Value, options),
                    "services" => JsonSerializer.SerializeToNode(value.Value, options),
                    "asset-available" => JsonSerializer.SerializeToNode(value.Value, options),
                    "other-class-1a" => JsonSerializer.SerializeToNode(value.Value, options),
                    "other-non-class-1a" => JsonSerializer.SerializeToNode(value.Value, options),
                    "tax-paid-not-deducted" => JsonSerializer.SerializeToNode(value.Value, options),
                    "expenses-travel-and-subsistence" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "expenses-entertainment" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "expenses-home-telephone" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "expenses-non-qualifying-relocation" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "expenses-other" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }

        public override GbP11DItemsCreateDeclarationsRequestItem ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new GbP11DItemsCreateDeclarationsRequestItem(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GbP11DItemsCreateDeclarationsRequestItem value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Type);
        }
    }

    /// <summary>
    /// Discriminated union type for asset-transferred
    /// </summary>
    [Serializable]
    public struct AssetTransferred
    {
        public AssetTransferred(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetTransferred value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetTransferred Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.AssetTransferred(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetTransferred value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for payment
    /// </summary>
    [Serializable]
    public struct Payment
    {
        public Payment(NordletApi.GbP11DItemsCreateDeclarationsRequestItemPayment value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemPayment Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.Payment(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemPayment value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for tax-on-notional-payments
    /// </summary>
    [Serializable]
    public struct TaxOnNotionalPayments
    {
        public TaxOnNotionalPayments(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxOnNotionalPayments value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxOnNotionalPayments Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.TaxOnNotionalPayments(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxOnNotionalPayments value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for vouchers-or-credit-cards
    /// </summary>
    [Serializable]
    public struct VouchersOrCreditCards
    {
        public VouchersOrCreditCards(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemVouchersOrCreditCards value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemVouchersOrCreditCards Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.VouchersOrCreditCards(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemVouchersOrCreditCards value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for living-accommodation
    /// </summary>
    [Serializable]
    public struct LivingAccommodation
    {
        public LivingAccommodation(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemLivingAccommodation value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemLivingAccommodation Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.LivingAccommodation(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemLivingAccommodation value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for mileage-allowance
    /// </summary>
    [Serializable]
    public struct MileageAllowance
    {
        public MileageAllowance(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemMileageAllowance value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemMileageAllowance Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.MileageAllowance(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemMileageAllowance value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for car
    /// </summary>
    [Serializable]
    public struct Car
    {
        public Car(NordletApi.GbP11DItemsCreateDeclarationsRequestItemCar value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemCar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.Car(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemCar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for vans
    /// </summary>
    [Serializable]
    public struct Vans
    {
        public Vans(NordletApi.GbP11DItemsCreateDeclarationsRequestItemVans value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemVans Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.Vans(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemVans value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for loan
    /// </summary>
    [Serializable]
    public struct Loan
    {
        public Loan(NordletApi.GbP11DItemsCreateDeclarationsRequestItemLoan value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemLoan Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.Loan(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemLoan value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for medical
    /// </summary>
    [Serializable]
    public struct Medical
    {
        public Medical(NordletApi.GbP11DItemsCreateDeclarationsRequestItemMedical value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemMedical Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.Medical(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemMedical value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for relocation
    /// </summary>
    [Serializable]
    public struct Relocation
    {
        public Relocation(NordletApi.GbP11DItemsCreateDeclarationsRequestItemRelocation value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemRelocation Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.Relocation(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemRelocation value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for services
    /// </summary>
    [Serializable]
    public struct Services
    {
        public Services(NordletApi.GbP11DItemsCreateDeclarationsRequestItemServices value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemServices Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.Services(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemServices value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for asset-available
    /// </summary>
    [Serializable]
    public struct AssetAvailable
    {
        public AssetAvailable(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetAvailable value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetAvailable Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.AssetAvailable(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemAssetAvailable value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for other-class-1a
    /// </summary>
    [Serializable]
    public struct OtherClass1A
    {
        public OtherClass1A(NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherClass1A value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherClass1A Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.OtherClass1A(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherClass1A value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for other-non-class-1a
    /// </summary>
    [Serializable]
    public struct OtherNonClass1A
    {
        public OtherNonClass1A(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1A value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1A Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.OtherNonClass1A(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1A value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for tax-paid-not-deducted
    /// </summary>
    [Serializable]
    public struct TaxPaidNotDeducted
    {
        public TaxPaidNotDeducted(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxPaidNotDeducted value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxPaidNotDeducted Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.TaxPaidNotDeducted(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemTaxPaidNotDeducted value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for expenses-travel-and-subsistence
    /// </summary>
    [Serializable]
    public struct ExpensesTravelAndSubsistence
    {
        public ExpensesTravelAndSubsistence(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesTravelAndSubsistence value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesTravelAndSubsistence Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.ExpensesTravelAndSubsistence(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesTravelAndSubsistence value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for expenses-entertainment
    /// </summary>
    [Serializable]
    public struct ExpensesEntertainment
    {
        public ExpensesEntertainment(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesEntertainment value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesEntertainment Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.ExpensesEntertainment(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesEntertainment value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for expenses-home-telephone
    /// </summary>
    [Serializable]
    public struct ExpensesHomeTelephone
    {
        public ExpensesHomeTelephone(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesHomeTelephone value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesHomeTelephone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.ExpensesHomeTelephone(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesHomeTelephone value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for expenses-non-qualifying-relocation
    /// </summary>
    [Serializable]
    public struct ExpensesNonQualifyingRelocation
    {
        public ExpensesNonQualifyingRelocation(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesNonQualifyingRelocation value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesNonQualifyingRelocation Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.ExpensesNonQualifyingRelocation(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesNonQualifyingRelocation value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for expenses-other
    /// </summary>
    [Serializable]
    public struct ExpensesOther
    {
        public ExpensesOther(NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesOther value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesOther Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsRequestItem.ExpensesOther(
            NordletApi.GbP11DItemsCreateDeclarationsRequestItemExpensesOther value
        ) => new(value);
    }
}
