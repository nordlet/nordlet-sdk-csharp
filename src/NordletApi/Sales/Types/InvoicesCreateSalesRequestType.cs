using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(InvoicesCreateSalesRequestType.InvoicesCreateSalesRequestTypeSerializer))]
[Serializable]
public readonly record struct InvoicesCreateSalesRequestType : IStringEnum
{
    public static readonly InvoicesCreateSalesRequestType Invoice = new(Values.Invoice);

    public static readonly InvoicesCreateSalesRequestType CreditNote = new(Values.CreditNote);

    public static readonly InvoicesCreateSalesRequestType Proforma = new(Values.Proforma);

    public static readonly InvoicesCreateSalesRequestType Advance = new(Values.Advance);

    public InvoicesCreateSalesRequestType(string value)
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
    public static InvoicesCreateSalesRequestType FromCustom(string value)
    {
        return new InvoicesCreateSalesRequestType(value);
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

    public static bool operator ==(InvoicesCreateSalesRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesCreateSalesRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesCreateSalesRequestType value) => value.Value;

    public static explicit operator InvoicesCreateSalesRequestType(string value) => new(value);

    internal class InvoicesCreateSalesRequestTypeSerializer
        : JsonConverter<InvoicesCreateSalesRequestType>
    {
        public override InvoicesCreateSalesRequestType Read(
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
            return new InvoicesCreateSalesRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesCreateSalesRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesCreateSalesRequestType ReadAsPropertyName(
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
            return new InvoicesCreateSalesRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesCreateSalesRequestType value,
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

        public const string Proforma = "proforma";

        public const string Advance = "advance";
    }
}
