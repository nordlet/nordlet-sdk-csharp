using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment.GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPaymentSerializer)
)]
[Serializable]
public readonly record struct GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment
    : IStringEnum
{
    public static readonly GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment DomesticBills =
        new(Values.DomesticBills);

    public static readonly GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment AccountancyFees =
        new(Values.AccountancyFees);

    public static readonly GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment PrivateEducation =
        new(Values.PrivateEducation);

    public static readonly GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment PrivateCarExpenses =
        new(Values.PrivateCarExpenses);

    public static readonly GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment SeasonTickets =
        new(Values.SeasonTickets);

    public static readonly GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment Other =
        new(Values.Other);

    public static readonly GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment Multiple =
        new(Values.Multiple);

    public GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment FromCustom(
        string value
    )
    {
        return new GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(
        GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment value
    ) => value.Value;

    public static explicit operator GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment(
        string value
    ) => new(value);

    internal class GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPaymentSerializer
        : JsonConverter<GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment>
    {
        public override GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GbP11DItemsListDeclarationsResponseItemsItemItemPaymentPayment value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string DomesticBills = "domestic bills";

        public const string AccountancyFees = "accountancy fees";

        public const string PrivateEducation = "private education";

        public const string PrivateCarExpenses = "private car expenses";

        public const string SeasonTickets = "season tickets";

        public const string Other = "other";

        public const string Multiple = "multiple";
    }
}
