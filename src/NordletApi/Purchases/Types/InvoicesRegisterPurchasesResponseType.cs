using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesRegisterPurchasesResponseType.InvoicesRegisterPurchasesResponseTypeSerializer)
)]
[Serializable]
public readonly record struct InvoicesRegisterPurchasesResponseType : IStringEnum
{
    public static readonly InvoicesRegisterPurchasesResponseType Invoice = new(Values.Invoice);

    public static readonly InvoicesRegisterPurchasesResponseType CreditNote = new(
        Values.CreditNote
    );

    public InvoicesRegisterPurchasesResponseType(string value)
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
    public static InvoicesRegisterPurchasesResponseType FromCustom(string value)
    {
        return new InvoicesRegisterPurchasesResponseType(value);
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

    public static bool operator ==(InvoicesRegisterPurchasesResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesRegisterPurchasesResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesRegisterPurchasesResponseType value) =>
        value.Value;

    public static explicit operator InvoicesRegisterPurchasesResponseType(string value) =>
        new(value);

    internal class InvoicesRegisterPurchasesResponseTypeSerializer
        : JsonConverter<InvoicesRegisterPurchasesResponseType>
    {
        public override InvoicesRegisterPurchasesResponseType Read(
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
            return new InvoicesRegisterPurchasesResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesRegisterPurchasesResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesRegisterPurchasesResponseType ReadAsPropertyName(
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
            return new InvoicesRegisterPurchasesResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesRegisterPurchasesResponseType value,
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
