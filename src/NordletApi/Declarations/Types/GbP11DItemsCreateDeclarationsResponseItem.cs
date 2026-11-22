// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(GbP11DItemsCreateDeclarationsResponseItem.JsonConverter))]
[Serializable]
public record GbP11DItemsCreateDeclarationsResponseItem
{
    internal GbP11DItemsCreateDeclarationsResponseItem(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.AssetTransferred"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.AssetTransferred value
    )
    {
        Type = "asset-transferred";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.Payment"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.Payment value
    )
    {
        Type = "payment";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.TaxOnNotionalPayments"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.TaxOnNotionalPayments value
    )
    {
        Type = "tax-on-notional-payments";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.VouchersOrCreditCards"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.VouchersOrCreditCards value
    )
    {
        Type = "vouchers-or-credit-cards";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.LivingAccommodation"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.LivingAccommodation value
    )
    {
        Type = "living-accommodation";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.MileageAllowance"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.MileageAllowance value
    )
    {
        Type = "mileage-allowance";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.Car"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.Car value
    )
    {
        Type = "car";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.Vans"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.Vans value
    )
    {
        Type = "vans";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.Loan"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.Loan value
    )
    {
        Type = "loan";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.Medical"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.Medical value
    )
    {
        Type = "medical";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.Relocation"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.Relocation value
    )
    {
        Type = "relocation";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.Services"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.Services value
    )
    {
        Type = "services";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.AssetAvailable"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.AssetAvailable value
    )
    {
        Type = "asset-available";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.OtherClass1A"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.OtherClass1A value
    )
    {
        Type = "other-class-1a";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.OtherNonClass1A"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.OtherNonClass1A value
    )
    {
        Type = "other-non-class-1a";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.TaxPaidNotDeducted"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.TaxPaidNotDeducted value
    )
    {
        Type = "tax-paid-not-deducted";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.ExpensesTravelAndSubsistence"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.ExpensesTravelAndSubsistence value
    )
    {
        Type = "expenses-travel-and-subsistence";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.ExpensesEntertainment"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.ExpensesEntertainment value
    )
    {
        Type = "expenses-entertainment";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.ExpensesHomeTelephone"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.ExpensesHomeTelephone value
    )
    {
        Type = "expenses-home-telephone";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.ExpensesNonQualifyingRelocation"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.ExpensesNonQualifyingRelocation value
    )
    {
        Type = "expenses-non-qualifying-relocation";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of GbP11DItemsCreateDeclarationsResponseItem with <see cref="GbP11DItemsCreateDeclarationsResponseItem.ExpensesOther"/>.
    /// </summary>
    public GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.ExpensesOther value
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
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetTransferred"/> if <see cref="Type"/> is 'asset-transferred', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'asset-transferred'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetTransferred AsAssetTransferred() =>
        IsAssetTransferred
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetTransferred)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'asset-transferred'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemPayment"/> if <see cref="Type"/> is 'payment', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'payment'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemPayment AsPayment() =>
        IsPayment
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemPayment)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'payment'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxOnNotionalPayments"/> if <see cref="Type"/> is 'tax-on-notional-payments', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'tax-on-notional-payments'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxOnNotionalPayments AsTaxOnNotionalPayments() =>
        IsTaxOnNotionalPayments
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxOnNotionalPayments)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'tax-on-notional-payments'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemVouchersOrCreditCards"/> if <see cref="Type"/> is 'vouchers-or-credit-cards', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'vouchers-or-credit-cards'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemVouchersOrCreditCards AsVouchersOrCreditCards() =>
        IsVouchersOrCreditCards
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemVouchersOrCreditCards)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'vouchers-or-credit-cards'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemLivingAccommodation"/> if <see cref="Type"/> is 'living-accommodation', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'living-accommodation'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemLivingAccommodation AsLivingAccommodation() =>
        IsLivingAccommodation
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemLivingAccommodation)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'living-accommodation'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemMileageAllowance"/> if <see cref="Type"/> is 'mileage-allowance', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'mileage-allowance'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemMileageAllowance AsMileageAllowance() =>
        IsMileageAllowance
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemMileageAllowance)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'mileage-allowance'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemCar"/> if <see cref="Type"/> is 'car', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'car'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemCar AsCar() =>
        IsCar
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemCar)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'car'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemVans"/> if <see cref="Type"/> is 'vans', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'vans'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemVans AsVans() =>
        IsVans
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemVans)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'vans'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemLoan"/> if <see cref="Type"/> is 'loan', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'loan'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemLoan AsLoan() =>
        IsLoan
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemLoan)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'loan'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemMedical"/> if <see cref="Type"/> is 'medical', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'medical'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemMedical AsMedical() =>
        IsMedical
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemMedical)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'medical'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemRelocation"/> if <see cref="Type"/> is 'relocation', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'relocation'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemRelocation AsRelocation() =>
        IsRelocation
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemRelocation)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'relocation'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemServices"/> if <see cref="Type"/> is 'services', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'services'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemServices AsServices() =>
        IsServices
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemServices)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'services'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetAvailable"/> if <see cref="Type"/> is 'asset-available', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'asset-available'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetAvailable AsAssetAvailable() =>
        IsAssetAvailable
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetAvailable)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'asset-available'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherClass1A"/> if <see cref="Type"/> is 'other-class-1a', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'other-class-1a'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherClass1A AsOtherClass1A() =>
        IsOtherClass1A
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherClass1A)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'other-class-1a'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherNonClass1A"/> if <see cref="Type"/> is 'other-non-class-1a', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'other-non-class-1a'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherNonClass1A AsOtherNonClass1A() =>
        IsOtherNonClass1A
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherNonClass1A)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'other-non-class-1a'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxPaidNotDeducted"/> if <see cref="Type"/> is 'tax-paid-not-deducted', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'tax-paid-not-deducted'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxPaidNotDeducted AsTaxPaidNotDeducted() =>
        IsTaxPaidNotDeducted
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxPaidNotDeducted)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'tax-paid-not-deducted'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesTravelAndSubsistence"/> if <see cref="Type"/> is 'expenses-travel-and-subsistence', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'expenses-travel-and-subsistence'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesTravelAndSubsistence AsExpensesTravelAndSubsistence() =>
        IsExpensesTravelAndSubsistence
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesTravelAndSubsistence)
                Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'expenses-travel-and-subsistence'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesEntertainment"/> if <see cref="Type"/> is 'expenses-entertainment', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'expenses-entertainment'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesEntertainment AsExpensesEntertainment() =>
        IsExpensesEntertainment
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesEntertainment)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'expenses-entertainment'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesHomeTelephone"/> if <see cref="Type"/> is 'expenses-home-telephone', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'expenses-home-telephone'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesHomeTelephone AsExpensesHomeTelephone() =>
        IsExpensesHomeTelephone
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesHomeTelephone)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'expenses-home-telephone'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesNonQualifyingRelocation"/> if <see cref="Type"/> is 'expenses-non-qualifying-relocation', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'expenses-non-qualifying-relocation'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesNonQualifyingRelocation AsExpensesNonQualifyingRelocation() =>
        IsExpensesNonQualifyingRelocation
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesNonQualifyingRelocation)
                Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'expenses-non-qualifying-relocation'"
            );

    /// <summary>
    /// Returns the value as a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesOther"/> if <see cref="Type"/> is 'expenses-other', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'expenses-other'.</exception>
    public NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesOther AsExpensesOther() =>
        IsExpensesOther
            ? (NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesOther)Value!
            : throw new global::System.Exception(
                "GbP11DItemsCreateDeclarationsResponseItem.Type is not 'expenses-other'"
            );

    public T Match<T>(
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetTransferred,
            T
        > onAssetTransferred,
        Func<NordletApi.GbP11DItemsCreateDeclarationsResponseItemPayment, T> onPayment,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxOnNotionalPayments,
            T
        > onTaxOnNotionalPayments,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemVouchersOrCreditCards,
            T
        > onVouchersOrCreditCards,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemLivingAccommodation,
            T
        > onLivingAccommodation,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemMileageAllowance,
            T
        > onMileageAllowance,
        Func<NordletApi.GbP11DItemsCreateDeclarationsResponseItemCar, T> onCar,
        Func<NordletApi.GbP11DItemsCreateDeclarationsResponseItemVans, T> onVans,
        Func<NordletApi.GbP11DItemsCreateDeclarationsResponseItemLoan, T> onLoan,
        Func<NordletApi.GbP11DItemsCreateDeclarationsResponseItemMedical, T> onMedical,
        Func<NordletApi.GbP11DItemsCreateDeclarationsResponseItemRelocation, T> onRelocation,
        Func<NordletApi.GbP11DItemsCreateDeclarationsResponseItemServices, T> onServices,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetAvailable,
            T
        > onAssetAvailable,
        Func<NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherClass1A, T> onOtherClass1A,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherNonClass1A,
            T
        > onOtherNonClass1A,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxPaidNotDeducted,
            T
        > onTaxPaidNotDeducted,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesTravelAndSubsistence,
            T
        > onExpensesTravelAndSubsistence,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesEntertainment,
            T
        > onExpensesEntertainment,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesHomeTelephone,
            T
        > onExpensesHomeTelephone,
        Func<
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesNonQualifyingRelocation,
            T
        > onExpensesNonQualifyingRelocation,
        Func<NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesOther, T> onExpensesOther,
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
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetTransferred> onAssetTransferred,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemPayment> onPayment,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxOnNotionalPayments> onTaxOnNotionalPayments,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemVouchersOrCreditCards> onVouchersOrCreditCards,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemLivingAccommodation> onLivingAccommodation,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemMileageAllowance> onMileageAllowance,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemCar> onCar,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemVans> onVans,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemLoan> onLoan,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemMedical> onMedical,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemRelocation> onRelocation,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemServices> onServices,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetAvailable> onAssetAvailable,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherClass1A> onOtherClass1A,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherNonClass1A> onOtherNonClass1A,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxPaidNotDeducted> onTaxPaidNotDeducted,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesTravelAndSubsistence> onExpensesTravelAndSubsistence,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesEntertainment> onExpensesEntertainment,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesHomeTelephone> onExpensesHomeTelephone,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesNonQualifyingRelocation> onExpensesNonQualifyingRelocation,
        Action<NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesOther> onExpensesOther,
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
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetTransferred"/> and returns true if successful.
    /// </summary>
    public bool TryAsAssetTransferred(
        out NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetTransferred? value
    )
    {
        if (Type == "asset-transferred")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetTransferred)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemPayment"/> and returns true if successful.
    /// </summary>
    public bool TryAsPayment(out NordletApi.GbP11DItemsCreateDeclarationsResponseItemPayment? value)
    {
        if (Type == "payment")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemPayment)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxOnNotionalPayments"/> and returns true if successful.
    /// </summary>
    public bool TryAsTaxOnNotionalPayments(
        out NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxOnNotionalPayments? value
    )
    {
        if (Type == "tax-on-notional-payments")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxOnNotionalPayments)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemVouchersOrCreditCards"/> and returns true if successful.
    /// </summary>
    public bool TryAsVouchersOrCreditCards(
        out NordletApi.GbP11DItemsCreateDeclarationsResponseItemVouchersOrCreditCards? value
    )
    {
        if (Type == "vouchers-or-credit-cards")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemVouchersOrCreditCards)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemLivingAccommodation"/> and returns true if successful.
    /// </summary>
    public bool TryAsLivingAccommodation(
        out NordletApi.GbP11DItemsCreateDeclarationsResponseItemLivingAccommodation? value
    )
    {
        if (Type == "living-accommodation")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemLivingAccommodation)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemMileageAllowance"/> and returns true if successful.
    /// </summary>
    public bool TryAsMileageAllowance(
        out NordletApi.GbP11DItemsCreateDeclarationsResponseItemMileageAllowance? value
    )
    {
        if (Type == "mileage-allowance")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemMileageAllowance)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemCar"/> and returns true if successful.
    /// </summary>
    public bool TryAsCar(out NordletApi.GbP11DItemsCreateDeclarationsResponseItemCar? value)
    {
        if (Type == "car")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemCar)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemVans"/> and returns true if successful.
    /// </summary>
    public bool TryAsVans(out NordletApi.GbP11DItemsCreateDeclarationsResponseItemVans? value)
    {
        if (Type == "vans")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemVans)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemLoan"/> and returns true if successful.
    /// </summary>
    public bool TryAsLoan(out NordletApi.GbP11DItemsCreateDeclarationsResponseItemLoan? value)
    {
        if (Type == "loan")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemLoan)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemMedical"/> and returns true if successful.
    /// </summary>
    public bool TryAsMedical(out NordletApi.GbP11DItemsCreateDeclarationsResponseItemMedical? value)
    {
        if (Type == "medical")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemMedical)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemRelocation"/> and returns true if successful.
    /// </summary>
    public bool TryAsRelocation(
        out NordletApi.GbP11DItemsCreateDeclarationsResponseItemRelocation? value
    )
    {
        if (Type == "relocation")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemRelocation)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemServices"/> and returns true if successful.
    /// </summary>
    public bool TryAsServices(
        out NordletApi.GbP11DItemsCreateDeclarationsResponseItemServices? value
    )
    {
        if (Type == "services")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemServices)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetAvailable"/> and returns true if successful.
    /// </summary>
    public bool TryAsAssetAvailable(
        out NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetAvailable? value
    )
    {
        if (Type == "asset-available")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetAvailable)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherClass1A"/> and returns true if successful.
    /// </summary>
    public bool TryAsOtherClass1A(
        out NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherClass1A? value
    )
    {
        if (Type == "other-class-1a")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherClass1A)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherNonClass1A"/> and returns true if successful.
    /// </summary>
    public bool TryAsOtherNonClass1A(
        out NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherNonClass1A? value
    )
    {
        if (Type == "other-non-class-1a")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherNonClass1A)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxPaidNotDeducted"/> and returns true if successful.
    /// </summary>
    public bool TryAsTaxPaidNotDeducted(
        out NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxPaidNotDeducted? value
    )
    {
        if (Type == "tax-paid-not-deducted")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxPaidNotDeducted)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesTravelAndSubsistence"/> and returns true if successful.
    /// </summary>
    public bool TryAsExpensesTravelAndSubsistence(
        out NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesTravelAndSubsistence? value
    )
    {
        if (Type == "expenses-travel-and-subsistence")
        {
            value =
                (NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesTravelAndSubsistence)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesEntertainment"/> and returns true if successful.
    /// </summary>
    public bool TryAsExpensesEntertainment(
        out NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesEntertainment? value
    )
    {
        if (Type == "expenses-entertainment")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesEntertainment)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesHomeTelephone"/> and returns true if successful.
    /// </summary>
    public bool TryAsExpensesHomeTelephone(
        out NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesHomeTelephone? value
    )
    {
        if (Type == "expenses-home-telephone")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesHomeTelephone)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesNonQualifyingRelocation"/> and returns true if successful.
    /// </summary>
    public bool TryAsExpensesNonQualifyingRelocation(
        out NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesNonQualifyingRelocation? value
    )
    {
        if (Type == "expenses-non-qualifying-relocation")
        {
            value =
                (NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesNonQualifyingRelocation)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesOther"/> and returns true if successful.
    /// </summary>
    public bool TryAsExpensesOther(
        out NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesOther? value
    )
    {
        if (Type == "expenses-other")
        {
            value = (NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesOther)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.AssetTransferred value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.Payment value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.TaxOnNotionalPayments value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.VouchersOrCreditCards value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.LivingAccommodation value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.MileageAllowance value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.Car value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.Vans value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.Loan value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.Medical value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.Relocation value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.Services value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.AssetAvailable value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.OtherClass1A value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.OtherNonClass1A value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.TaxPaidNotDeducted value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.ExpensesTravelAndSubsistence value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.ExpensesEntertainment value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.ExpensesHomeTelephone value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.ExpensesNonQualifyingRelocation value
    ) => new(value);

    public static implicit operator GbP11DItemsCreateDeclarationsResponseItem(
        GbP11DItemsCreateDeclarationsResponseItem.ExpensesOther value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<GbP11DItemsCreateDeclarationsResponseItem>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(GbP11DItemsCreateDeclarationsResponseItem).IsAssignableFrom(typeToConvert);

        public override GbP11DItemsCreateDeclarationsResponseItem Read(
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
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetTransferred?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetTransferred"
                        ),
                "payment" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemPayment?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemPayment"
                        ),
                "tax-on-notional-payments" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxOnNotionalPayments?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxOnNotionalPayments"
                        ),
                "vouchers-or-credit-cards" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemVouchersOrCreditCards?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemVouchersOrCreditCards"
                        ),
                "living-accommodation" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemLivingAccommodation?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemLivingAccommodation"
                        ),
                "mileage-allowance" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemMileageAllowance?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemMileageAllowance"
                        ),
                "car" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemCar?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemCar"
                        ),
                "vans" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemVans?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemVans"
                        ),
                "loan" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemLoan?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemLoan"
                        ),
                "medical" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemMedical?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemMedical"
                        ),
                "relocation" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemRelocation?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemRelocation"
                        ),
                "services" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemServices?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemServices"
                        ),
                "asset-available" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetAvailable?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetAvailable"
                        ),
                "other-class-1a" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherClass1A?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherClass1A"
                        ),
                "other-non-class-1a" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherNonClass1A?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherNonClass1A"
                        ),
                "tax-paid-not-deducted" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxPaidNotDeducted?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxPaidNotDeducted"
                        ),
                "expenses-travel-and-subsistence" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesTravelAndSubsistence?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesTravelAndSubsistence"
                        ),
                "expenses-entertainment" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesEntertainment?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesEntertainment"
                        ),
                "expenses-home-telephone" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesHomeTelephone?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesHomeTelephone"
                        ),
                "expenses-non-qualifying-relocation" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesNonQualifyingRelocation?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesNonQualifyingRelocation"
                        ),
                "expenses-other" =>
                    jsonWithoutDiscriminator.Deserialize<NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesOther?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesOther"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new GbP11DItemsCreateDeclarationsResponseItem(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GbP11DItemsCreateDeclarationsResponseItem value,
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

        public override GbP11DItemsCreateDeclarationsResponseItem ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new GbP11DItemsCreateDeclarationsResponseItem(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GbP11DItemsCreateDeclarationsResponseItem value,
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
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetTransferred value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetTransferred Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.AssetTransferred(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetTransferred value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for payment
    /// </summary>
    [Serializable]
    public struct Payment
    {
        public Payment(NordletApi.GbP11DItemsCreateDeclarationsResponseItemPayment value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemPayment Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.Payment(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemPayment value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for tax-on-notional-payments
    /// </summary>
    [Serializable]
    public struct TaxOnNotionalPayments
    {
        public TaxOnNotionalPayments(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxOnNotionalPayments value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxOnNotionalPayments Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.TaxOnNotionalPayments(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxOnNotionalPayments value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for vouchers-or-credit-cards
    /// </summary>
    [Serializable]
    public struct VouchersOrCreditCards
    {
        public VouchersOrCreditCards(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemVouchersOrCreditCards value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemVouchersOrCreditCards Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.VouchersOrCreditCards(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemVouchersOrCreditCards value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for living-accommodation
    /// </summary>
    [Serializable]
    public struct LivingAccommodation
    {
        public LivingAccommodation(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemLivingAccommodation value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemLivingAccommodation Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.LivingAccommodation(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemLivingAccommodation value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for mileage-allowance
    /// </summary>
    [Serializable]
    public struct MileageAllowance
    {
        public MileageAllowance(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemMileageAllowance value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemMileageAllowance Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.MileageAllowance(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemMileageAllowance value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for car
    /// </summary>
    [Serializable]
    public struct Car
    {
        public Car(NordletApi.GbP11DItemsCreateDeclarationsResponseItemCar value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemCar Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.Car(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemCar value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for vans
    /// </summary>
    [Serializable]
    public struct Vans
    {
        public Vans(NordletApi.GbP11DItemsCreateDeclarationsResponseItemVans value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemVans Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.Vans(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemVans value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for loan
    /// </summary>
    [Serializable]
    public struct Loan
    {
        public Loan(NordletApi.GbP11DItemsCreateDeclarationsResponseItemLoan value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemLoan Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.Loan(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemLoan value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for medical
    /// </summary>
    [Serializable]
    public struct Medical
    {
        public Medical(NordletApi.GbP11DItemsCreateDeclarationsResponseItemMedical value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemMedical Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.Medical(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemMedical value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for relocation
    /// </summary>
    [Serializable]
    public struct Relocation
    {
        public Relocation(NordletApi.GbP11DItemsCreateDeclarationsResponseItemRelocation value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemRelocation Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.Relocation(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemRelocation value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for services
    /// </summary>
    [Serializable]
    public struct Services
    {
        public Services(NordletApi.GbP11DItemsCreateDeclarationsResponseItemServices value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemServices Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.Services(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemServices value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for asset-available
    /// </summary>
    [Serializable]
    public struct AssetAvailable
    {
        public AssetAvailable(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetAvailable value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetAvailable Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.AssetAvailable(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemAssetAvailable value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for other-class-1a
    /// </summary>
    [Serializable]
    public struct OtherClass1A
    {
        public OtherClass1A(NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherClass1A value)
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherClass1A Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.OtherClass1A(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherClass1A value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for other-non-class-1a
    /// </summary>
    [Serializable]
    public struct OtherNonClass1A
    {
        public OtherNonClass1A(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherNonClass1A value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherNonClass1A Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.OtherNonClass1A(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemOtherNonClass1A value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for tax-paid-not-deducted
    /// </summary>
    [Serializable]
    public struct TaxPaidNotDeducted
    {
        public TaxPaidNotDeducted(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxPaidNotDeducted value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxPaidNotDeducted Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.TaxPaidNotDeducted(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemTaxPaidNotDeducted value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for expenses-travel-and-subsistence
    /// </summary>
    [Serializable]
    public struct ExpensesTravelAndSubsistence
    {
        public ExpensesTravelAndSubsistence(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesTravelAndSubsistence value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesTravelAndSubsistence Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.ExpensesTravelAndSubsistence(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesTravelAndSubsistence value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for expenses-entertainment
    /// </summary>
    [Serializable]
    public struct ExpensesEntertainment
    {
        public ExpensesEntertainment(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesEntertainment value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesEntertainment Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.ExpensesEntertainment(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesEntertainment value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for expenses-home-telephone
    /// </summary>
    [Serializable]
    public struct ExpensesHomeTelephone
    {
        public ExpensesHomeTelephone(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesHomeTelephone value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesHomeTelephone Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.ExpensesHomeTelephone(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesHomeTelephone value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for expenses-non-qualifying-relocation
    /// </summary>
    [Serializable]
    public struct ExpensesNonQualifyingRelocation
    {
        public ExpensesNonQualifyingRelocation(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesNonQualifyingRelocation value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesNonQualifyingRelocation Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.ExpensesNonQualifyingRelocation(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesNonQualifyingRelocation value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for expenses-other
    /// </summary>
    [Serializable]
    public struct ExpensesOther
    {
        public ExpensesOther(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesOther value
        )
        {
            Value = value;
        }

        internal NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesOther Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator GbP11DItemsCreateDeclarationsResponseItem.ExpensesOther(
            NordletApi.GbP11DItemsCreateDeclarationsResponseItemExpensesOther value
        ) => new(value);
    }
}
