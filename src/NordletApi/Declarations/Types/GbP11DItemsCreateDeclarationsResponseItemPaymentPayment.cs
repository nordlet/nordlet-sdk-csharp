using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(GbP11DItemsCreateDeclarationsResponseItemPaymentPayment.GbP11DItemsCreateDeclarationsResponseItemPaymentPaymentSerializer)
)]
[Serializable]
public readonly record struct GbP11DItemsCreateDeclarationsResponseItemPaymentPayment : IStringEnum
{
    public static readonly GbP11DItemsCreateDeclarationsResponseItemPaymentPayment DomesticBills =
        new(Values.DomesticBills);

    public static readonly GbP11DItemsCreateDeclarationsResponseItemPaymentPayment AccountancyFees =
        new(Values.AccountancyFees);

    public static readonly GbP11DItemsCreateDeclarationsResponseItemPaymentPayment PrivateEducation =
        new(Values.PrivateEducation);

    public static readonly GbP11DItemsCreateDeclarationsResponseItemPaymentPayment PrivateCarExpenses =
        new(Values.PrivateCarExpenses);

    public static readonly GbP11DItemsCreateDeclarationsResponseItemPaymentPayment SeasonTickets =
        new(Values.SeasonTickets);

    public static readonly GbP11DItemsCreateDeclarationsResponseItemPaymentPayment Other = new(
        Values.Other
    );

    public static readonly GbP11DItemsCreateDeclarationsResponseItemPaymentPayment Multiple = new(
        Values.Multiple
    );

    public GbP11DItemsCreateDeclarationsResponseItemPaymentPayment(string value)
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
    public static GbP11DItemsCreateDeclarationsResponseItemPaymentPayment FromCustom(string value)
    {
        return new GbP11DItemsCreateDeclarationsResponseItemPaymentPayment(value);
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
        GbP11DItemsCreateDeclarationsResponseItemPaymentPayment value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GbP11DItemsCreateDeclarationsResponseItemPaymentPayment value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GbP11DItemsCreateDeclarationsResponseItemPaymentPayment value
    ) => value.Value;

    public static explicit operator GbP11DItemsCreateDeclarationsResponseItemPaymentPayment(
        string value
    ) => new(value);

    internal class GbP11DItemsCreateDeclarationsResponseItemPaymentPaymentSerializer
        : JsonConverter<GbP11DItemsCreateDeclarationsResponseItemPaymentPayment>
    {
        public override GbP11DItemsCreateDeclarationsResponseItemPaymentPayment Read(
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
            return new GbP11DItemsCreateDeclarationsResponseItemPaymentPayment(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GbP11DItemsCreateDeclarationsResponseItemPaymentPayment value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GbP11DItemsCreateDeclarationsResponseItemPaymentPayment ReadAsPropertyName(
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
            return new GbP11DItemsCreateDeclarationsResponseItemPaymentPayment(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GbP11DItemsCreateDeclarationsResponseItemPaymentPayment value,
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
