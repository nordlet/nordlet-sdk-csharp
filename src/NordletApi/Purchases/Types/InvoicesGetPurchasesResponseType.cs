using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(InvoicesGetPurchasesResponseType.InvoicesGetPurchasesResponseTypeSerializer))]
[Serializable]
public readonly record struct InvoicesGetPurchasesResponseType : IStringEnum
{
    public static readonly InvoicesGetPurchasesResponseType Invoice = new(Values.Invoice);

    public static readonly InvoicesGetPurchasesResponseType CreditNote = new(Values.CreditNote);

    public InvoicesGetPurchasesResponseType(string value)
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
    public static InvoicesGetPurchasesResponseType FromCustom(string value)
    {
        return new InvoicesGetPurchasesResponseType(value);
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

    public static bool operator ==(InvoicesGetPurchasesResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesGetPurchasesResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesGetPurchasesResponseType value) => value.Value;

    public static explicit operator InvoicesGetPurchasesResponseType(string value) => new(value);

    internal class InvoicesGetPurchasesResponseTypeSerializer
        : JsonConverter<InvoicesGetPurchasesResponseType>
    {
        public override InvoicesGetPurchasesResponseType Read(
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
            return new InvoicesGetPurchasesResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesGetPurchasesResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesGetPurchasesResponseType ReadAsPropertyName(
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
            return new InvoicesGetPurchasesResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesGetPurchasesResponseType value,
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
        public const string Invoice = "invoice";

        public const string CreditNote = "credit_note";
    }
}
