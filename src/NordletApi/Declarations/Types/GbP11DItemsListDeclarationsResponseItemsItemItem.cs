// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(GbP11DItemsListDeclarationsResponseItemsItemItem.JsonConverter))]
[Serializable]
public record GbP11DItemsListDeclarationsResponseItemsItemItem
{
    internal GbP11DItemsListDeclarationsResponseItemsItemItem(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.AssetTransferred"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.AssetTransferred value
    )
    {
        Type = "asset-transferred";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.Payment"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.Payment value
    )
    {
        Type = "payment";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.TaxOnNotionalPayments"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.TaxOnNotionalPayments value
    )
    {
        Type = "tax-on-notional-payments";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.VouchersOrCreditCards"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.VouchersOrCreditCards value
    )
    {
        Type = "vouchers-or-credit-cards";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.LivingAccommodation"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.LivingAccommodation value
    )
    {
        Type = "living-accommodation";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.MileageAllowance"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.MileageAllowance value
    )
    {
        Type = "mileage-allowance";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.Car"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.Car value
    )
    {
        Type = "car";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.Vans"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.Vans value
    )
    {
        Type = "vans";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.Loan"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.Loan value
    )
    {
        Type = "loan";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.Medical"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.Medical value
    )
    {
        Type = "medical";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.Relocation"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.Relocation value
    )
    {
        Type = "relocation";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.Services"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.Services value
    )
    {
        Type = "services";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.AssetAvailable"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.AssetAvailable value
    )
    {
        Type = "asset-available";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.OtherClass1A"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.OtherClass1A value
    )
    {
        Type = "other-class-1a";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.OtherNonClass1A"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.OtherNonClass1A value
    )
    {
        Type = "other-non-class-1a";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.TaxPaidNotDeducted"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.TaxPaidNotDeducted value
    )
    {
        Type = "tax-paid-not-deducted";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesTravelAndSubsistence"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesTravelAndSubsistence value
    )
    {
        Type = "expenses-travel-and-subsistence";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesEntertainment"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesEntertainment value
    )
    {
        Type = "expenses-entertainment";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesHomeTelephone"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesHomeTelephone value
    )
    {
        Type = "expenses-home-telephone";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesNonQualifyingRelocation"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesNonQualifyingRelocation value
    )
    {
        Type = "expenses-non-qualifying-relocation";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsListDeclarationsResponseItemsItemItem with <see cref="GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesOther"/>.
    /// </summary>
    public GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesOther value
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
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetTransferred"/> if <see cref="Type"/> is 'asset-transferred', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'asset-transferred'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetTransferred AsAssetTransferred() =>
        IsAssetTransferred
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetTransferred)Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'asset-transferred'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemPayment"/> if <see cref="Type"/> is 'payment', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'payment'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemPayment AsPayment() =>
        IsPayment
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemPayment)Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'payment'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxOnNotionalPayments"/> if <see cref="Type"/> is 'tax-on-notional-payments', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'tax-on-notional-payments'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxOnNotionalPayments AsTaxOnNotionalPayments() =>
        IsTaxOnNotionalPayments
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxOnNotionalPayments)
                Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'tax-on-notional-payments'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVouchersOrCreditCards"/> if <see cref="Type"/> is 'vouchers-or-credit-cards', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'vouchers-or-credit-cards'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVouchersOrCreditCards AsVouchersOrCreditCards() =>
        IsVouchersOrCreditCards
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVouchersOrCreditCards)
                Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'vouchers-or-credit-cards'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLivingAccommodation"/> if <see cref="Type"/> is 'living-accommodation', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'living-accommodation'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLivingAccommodation AsLivingAccommodation() =>
        IsLivingAccommodation
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLivingAccommodation)Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'living-accommodation'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMileageAllowance"/> if <see cref="Type"/> is 'mileage-allowance', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'mileage-allowance'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMileageAllowance AsMileageAllowance() =>
        IsMileageAllowance
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMileageAllowance)Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'mileage-allowance'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemCar"/> if <see cref="Type"/> is 'car', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'car'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemCar AsCar() =>
        IsCar
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemCar)Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'car'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVans"/> if <see cref="Type"/> is 'vans', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'vans'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVans AsVans() =>
        IsVans
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVans)Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'vans'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLoan"/> if <see cref="Type"/> is 'loan', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'loan'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLoan AsLoan() =>
        IsLoan
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLoan)Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'loan'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMedical"/> if <see cref="Type"/> is 'medical', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'medical'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMedical AsMedical() =>
        IsMedical
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMedical)Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'medical'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemRelocation"/> if <see cref="Type"/> is 'relocation', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'relocation'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemRelocation AsRelocation() =>
        IsRelocation
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemRelocation)Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'relocation'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemServices"/> if <see cref="Type"/> is 'services', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'services'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemServices AsServices() =>
        IsServices
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemServices)Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'services'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailable"/> if <see cref="Type"/> is 'asset-available', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'asset-available'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailable AsAssetAvailable() =>
        IsAssetAvailable
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailable)Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'asset-available'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherClass1A"/> if <see cref="Type"/> is 'other-class-1a', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'other-class-1a'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherClass1A AsOtherClass1A() =>
        IsOtherClass1A
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherClass1A)Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'other-class-1a'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherNonClass1A"/> if <see cref="Type"/> is 'other-non-class-1a', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'other-non-class-1a'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherNonClass1A AsOtherNonClass1A() =>
        IsOtherNonClass1A
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherNonClass1A)Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'other-non-class-1a'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxPaidNotDeducted"/> if <see cref="Type"/> is 'tax-paid-not-deducted', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'tax-paid-not-deducted'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxPaidNotDeducted AsTaxPaidNotDeducted() =>
        IsTaxPaidNotDeducted
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxPaidNotDeducted)Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'tax-paid-not-deducted'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesTravelAndSubsistence"/> if <see cref="Type"/> is 'expenses-travel-and-subsistence', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'expenses-travel-and-subsistence'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesTravelAndSubsistence AsExpensesTravelAndSubsistence() =>
        IsExpensesTravelAndSubsistence
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesTravelAndSubsistence)
                Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'expenses-travel-and-subsistence'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesEntertainment"/> if <see cref="Type"/> is 'expenses-entertainment', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'expenses-entertainment'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesEntertainment AsExpensesEntertainment() =>
        IsExpensesEntertainment
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesEntertainment)
                Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'expenses-entertainment'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesHomeTelephone"/> if <see cref="Type"/> is 'expenses-home-telephone', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'expenses-home-telephone'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesHomeTelephone AsExpensesHomeTelephone() =>
        IsExpensesHomeTelephone
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesHomeTelephone)
                Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'expenses-home-telephone'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesNonQualifyingRelocation"/> if <see cref="Type"/> is 'expenses-non-qualifying-relocation', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'expenses-non-qualifying-relocation'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesNonQualifyingRelocation AsExpensesNonQualifyingRelocation() =>
        IsExpensesNonQualifyingRelocation
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesNonQualifyingRelocation)
                Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'expenses-non-qualifying-relocation'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesOther"/> if <see cref="Type"/> is 'expenses-other', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'expenses-other'.</exception>
    public NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesOther AsExpensesOther() =>
        IsExpensesOther
            ? (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesOther)Value!
            : throw new global::System.Exception(
                "GbP11DItemsListDeclarationsResponseItemsItemItem.Type is not 'expenses-other'"
            );

    public T Match<T>(
        Func<
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetTransferred,
            T
        > onAssetTransferred,
        Func<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemPayment, T> onPayment,
        Func<
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxOnNotionalPayments,
            T
        > onTaxOnNotionalPayments,
        Func<
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVouchersOrCreditCards,
            T
        > onVouchersOrCreditCards,
        Func<
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLivingAccommodation,
            T
        > onLivingAccommodation,
        Func<
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMileageAllowance,
            T
        > onMileageAllowance,
        Func<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemCar, T> onCar,
        Func<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVans, T> onVans,
        Func<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLoan, T> onLoan,
        Func<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMedical, T> onMedical,
        Func<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemRelocation, T> onRelocation,
        Func<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemServices, T> onServices,
        Func<
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailable,
            T
        > onAssetAvailable,
        Func<
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherClass1A,
            T
        > onOtherClass1A,
        Func<
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherNonClass1A,
            T
        > onOtherNonClass1A,
        Func<
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxPaidNotDeducted,
            T
        > onTaxPaidNotDeducted,
        Func<
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesTravelAndSubsistence,
            T
        > onExpensesTravelAndSubsistence,
        Func<
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesEntertainment,
            T
        > onExpensesEntertainment,
        Func<
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesHomeTelephone,
            T
        > onExpensesHomeTelephone,
        Func<
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesNonQualifyingRelocation,
            T
        > onExpensesNonQualifyingRelocation,
        Func<
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesOther,
            T
        > onExpensesOther,
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
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetTransferred> onAssetTransferred,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemPayment> onPayment,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxOnNotionalPayments> onTaxOnNotionalPayments,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVouchersOrCreditCards> onVouchersOrCreditCards,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLivingAccommodation> onLivingAccommodation,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMileageAllowance> onMileageAllowance,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemCar> onCar,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVans> onVans,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLoan> onLoan,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMedical> onMedical,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemRelocation> onRelocation,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemServices> onServices,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailable> onAssetAvailable,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherClass1A> onOtherClass1A,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherNonClass1A> onOtherNonClass1A,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxPaidNotDeducted> onTaxPaidNotDeducted,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesTravelAndSubsistence> onExpensesTravelAndSubsistence,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesEntertainment> onExpensesEntertainment,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesHomeTelephone> onExpensesHomeTelephone,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesNonQualifyingRelocation> onExpensesNonQualifyingRelocation,
        Action<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesOther> onExpensesOther,
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
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetTransferred"/> and returns true if successful.
    /// </summary>
    public bool TryAsAssetTransferred(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetTransferred? value
    )
    {
        if (Type == "asset-transferred")
        {
            value = (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetTransferred)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemPayment"/> and returns true if successful.
    /// </summary>
    public bool TryAsPayment(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemPayment? value
    )
    {
        if (Type == "payment")
        {
            value = (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemPayment)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxOnNotionalPayments"/> and returns true if successful.
    /// </summary>
    public bool TryAsTaxOnNotionalPayments(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxOnNotionalPayments? value
    )
    {
        if (Type == "tax-on-notional-payments")
        {
            value =
                (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxOnNotionalPayments)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVouchersOrCreditCards"/> and returns true if successful.
    /// </summary>
    public bool TryAsVouchersOrCreditCards(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVouchersOrCreditCards? value
    )
    {
        if (Type == "vouchers-or-credit-cards")
        {
            value =
                (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVouchersOrCreditCards)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLivingAccommodation"/> and returns true if successful.
    /// </summary>
    public bool TryAsLivingAccommodation(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLivingAccommodation? value
    )
    {
        if (Type == "living-accommodation")
        {
            value = (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLivingAccommodation)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMileageAllowance"/> and returns true if successful.
    /// </summary>
    public bool TryAsMileageAllowance(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMileageAllowance? value
    )
    {
        if (Type == "mileage-allowance")
        {
            value = (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMileageAllowance)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemCar"/> and returns true if successful.
    /// </summary>
    public bool TryAsCar(out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemCar? value)
    {
        if (Type == "car")
        {
            value = (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemCar)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVans"/> and returns true if successful.
    /// </summary>
    public bool TryAsVans(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVans? value
    )
    {
        if (Type == "vans")
        {
            value = (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVans)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLoan"/> and returns true if successful.
    /// </summary>
    public bool TryAsLoan(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLoan? value
    )
    {
        if (Type == "loan")
        {
            value = (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLoan)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMedical"/> and returns true if successful.
    /// </summary>
    public bool TryAsMedical(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMedical? value
    )
    {
        if (Type == "medical")
        {
            value = (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMedical)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemRelocation"/> and returns true if successful.
    /// </summary>
    public bool TryAsRelocation(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemRelocation? value
    )
    {
        if (Type == "relocation")
        {
            value = (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemRelocation)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemServices"/> and returns true if successful.
    /// </summary>
    public bool TryAsServices(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemServices? value
    )
    {
        if (Type == "services")
        {
            value = (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemServices)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailable"/> and returns true if successful.
    /// </summary>
    public bool TryAsAssetAvailable(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailable? value
    )
    {
        if (Type == "asset-available")
        {
            value = (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailable)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherClass1A"/> and returns true if successful.
    /// </summary>
    public bool TryAsOtherClass1A(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherClass1A? value
    )
    {
        if (Type == "other-class-1a")
        {
            value = (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherClass1A)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherNonClass1A"/> and returns true if successful.
    /// </summary>
    public bool TryAsOtherNonClass1A(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherNonClass1A? value
    )
    {
        if (Type == "other-non-class-1a")
        {
            value = (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherNonClass1A)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxPaidNotDeducted"/> and returns true if successful.
    /// </summary>
    public bool TryAsTaxPaidNotDeducted(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxPaidNotDeducted? value
    )
    {
        if (Type == "tax-paid-not-deducted")
        {
            value = (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxPaidNotDeducted)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesTravelAndSubsistence"/> and returns true if successful.
    /// </summary>
    public bool TryAsExpensesTravelAndSubsistence(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesTravelAndSubsistence? value
    )
    {
        if (Type == "expenses-travel-and-subsistence")
        {
            value =
                (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesTravelAndSubsistence)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesEntertainment"/> and returns true if successful.
    /// </summary>
    public bool TryAsExpensesEntertainment(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesEntertainment? value
    )
    {
        if (Type == "expenses-entertainment")
        {
            value =
                (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesEntertainment)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesHomeTelephone"/> and returns true if successful.
    /// </summary>
    public bool TryAsExpensesHomeTelephone(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesHomeTelephone? value
    )
    {
        if (Type == "expenses-home-telephone")
        {
            value =
                (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesHomeTelephone)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesNonQualifyingRelocation"/> and returns true if successful.
    /// </summary>
    public bool TryAsExpensesNonQualifyingRelocation(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesNonQualifyingRelocation? value
    )
    {
        if (Type == "expenses-non-qualifying-relocation")
        {
            value =
                (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesNonQualifyingRelocation)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesOther"/> and returns true if successful.
    /// </summary>
    public bool TryAsExpensesOther(
        out NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesOther? value
    )
    {
        if (Type == "expenses-other")
        {
            value = (NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesOther)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.AssetTransferred value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.Payment value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.TaxOnNotionalPayments value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.VouchersOrCreditCards value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.LivingAccommodation value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.MileageAllowance value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.Car value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.Vans value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.Loan value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.Medical value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.Relocation value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.Services value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.AssetAvailable value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.OtherClass1A value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.OtherNonClass1A value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.TaxPaidNotDeducted value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesTravelAndSubsistence value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesEntertainment value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesHomeTelephone value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesNonQualifyingRelocation value
    ) => new(value);

    public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem(
        GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesOther value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<GbP11DItemsListDeclarationsResponseItemsItemItem>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(GbP11DItemsListDeclarationsResponseItemsItemItem).IsAssignableFrom(
                typeToConvert
            );

        public override GbP11DItemsListDeclarationsResponseItemsItemItem Read(
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
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetTransferred?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetTransferred"
                        ),
                "payment" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemPayment?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemPayment"
                        ),
                "tax-on-notional-payments" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxOnNotionalPayments?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxOnNotionalPayments"
                        ),
                "vouchers-or-credit-cards" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVouchersOrCreditCards?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVouchersOrCreditCards"
                        ),
                "living-accommodation" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLivingAccommodation?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLivingAccommodation"
                        ),
                "mileage-allowance" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMileageAllowance?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMileageAllowance"
                        ),
                "car" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemCar?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemCar"
                        ),
                "vans" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVans?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVans"
                        ),
                "loan" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLoan?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLoan"
                        ),
                "medical" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMedical?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMedical"
                        ),
                "relocation" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemRelocation?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemRelocation"
                        ),
                "services" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemServices?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemServices"
                        ),
                "asset-available" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailable?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailable"
                        ),
                "other-class-1a" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherClass1A?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherClass1A"
                        ),
                "other-non-class-1a" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherNonClass1A?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherNonClass1A"
                        ),
                "tax-paid-not-deducted" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxPaidNotDeducted?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxPaidNotDeducted"
                        ),
                "expenses-travel-and-subsistence" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesTravelAndSubsistence?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesTravelAndSubsistence"
                        ),
                "expenses-entertainment" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesEntertainment?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesEntertainment"
                        ),
                "expenses-home-telephone" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesHomeTelephone?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesHomeTelephone"
                        ),
                "expenses-non-qualifying-relocation" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesNonQualifyingRelocation?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesNonQualifyingRelocation"
                        ),
                "expenses-other" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesOther?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesOther"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new GbP11DItemsListDeclarationsResponseItemsItemItem(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GbP11DItemsListDeclarationsResponseItemsItemItem value,
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

        public override GbP11DItemsListDeclarationsResponseItemsItemItem ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new GbP11DItemsListDeclarationsResponseItemsItemItem(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GbP11DItemsListDeclarationsResponseItemsItemItem value,
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
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetTransferred value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetTransferred Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.AssetTransferred(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetTransferred value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for payment
    /// </summary>
    [Serializable]
    public struct Payment
    {
        public Payment(NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemPayment value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemPayment Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.Payment(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemPayment value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for tax-on-notional-payments
    /// </summary>
    [Serializable]
    public struct TaxOnNotionalPayments
    {
        public TaxOnNotionalPayments(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxOnNotionalPayments value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxOnNotionalPayments Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.TaxOnNotionalPayments(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxOnNotionalPayments value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for vouchers-or-credit-cards
    /// </summary>
    [Serializable]
    public struct VouchersOrCreditCards
    {
        public VouchersOrCreditCards(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVouchersOrCreditCards value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVouchersOrCreditCards Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.VouchersOrCreditCards(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVouchersOrCreditCards value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for living-accommodation
    /// </summary>
    [Serializable]
    public struct LivingAccommodation
    {
        public LivingAccommodation(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLivingAccommodation value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLivingAccommodation Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.LivingAccommodation(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLivingAccommodation value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for mileage-allowance
    /// </summary>
    [Serializable]
    public struct MileageAllowance
    {
        public MileageAllowance(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMileageAllowance value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMileageAllowance Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.MileageAllowance(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMileageAllowance value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for car
    /// </summary>
    [Serializable]
    public struct Car
    {
        public Car(NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemCar value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemCar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.Car(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemCar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for vans
    /// </summary>
    [Serializable]
    public struct Vans
    {
        public Vans(NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVans value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVans Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.Vans(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemVans value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for loan
    /// </summary>
    [Serializable]
    public struct Loan
    {
        public Loan(NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLoan value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLoan Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.Loan(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemLoan value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for medical
    /// </summary>
    [Serializable]
    public struct Medical
    {
        public Medical(NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMedical value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMedical Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.Medical(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemMedical value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for relocation
    /// </summary>
    [Serializable]
    public struct Relocation
    {
        public Relocation(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemRelocation value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemRelocation Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.Relocation(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemRelocation value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for services
    /// </summary>
    [Serializable]
    public struct Services
    {
        public Services(NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemServices value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemServices Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.Services(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemServices value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for asset-available
    /// </summary>
    [Serializable]
    public struct AssetAvailable
    {
        public AssetAvailable(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailable value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailable Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.AssetAvailable(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemAssetAvailable value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for other-class-1a
    /// </summary>
    [Serializable]
    public struct OtherClass1A
    {
        public OtherClass1A(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherClass1A value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherClass1A Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.OtherClass1A(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherClass1A value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for other-non-class-1a
    /// </summary>
    [Serializable]
    public struct OtherNonClass1A
    {
        public OtherNonClass1A(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherNonClass1A value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherNonClass1A Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.OtherNonClass1A(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemOtherNonClass1A value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for tax-paid-not-deducted
    /// </summary>
    [Serializable]
    public struct TaxPaidNotDeducted
    {
        public TaxPaidNotDeducted(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxPaidNotDeducted value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxPaidNotDeducted Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.TaxPaidNotDeducted(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemTaxPaidNotDeducted value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for expenses-travel-and-subsistence
    /// </summary>
    [Serializable]
    public struct ExpensesTravelAndSubsistence
    {
        public ExpensesTravelAndSubsistence(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesTravelAndSubsistence value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesTravelAndSubsistence Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesTravelAndSubsistence(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesTravelAndSubsistence value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for expenses-entertainment
    /// </summary>
    [Serializable]
    public struct ExpensesEntertainment
    {
        public ExpensesEntertainment(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesEntertainment value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesEntertainment Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesEntertainment(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesEntertainment value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for expenses-home-telephone
    /// </summary>
    [Serializable]
    public struct ExpensesHomeTelephone
    {
        public ExpensesHomeTelephone(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesHomeTelephone value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesHomeTelephone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesHomeTelephone(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesHomeTelephone value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for expenses-non-qualifying-relocation
    /// </summary>
    [Serializable]
    public struct ExpensesNonQualifyingRelocation
    {
        public ExpensesNonQualifyingRelocation(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesNonQualifyingRelocation value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesNonQualifyingRelocation Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesNonQualifyingRelocation(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesNonQualifyingRelocation value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for expenses-other
    /// </summary>
    [Serializable]
    public struct ExpensesOther
    {
        public ExpensesOther(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesOther value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesOther Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsListDeclarationsResponseItemsItemItem.ExpensesOther(
            NordletApi.GbP11DItemsListDeclarationsResponseItemsItemItemExpensesOther value
        ) => new(value);
    }
}
