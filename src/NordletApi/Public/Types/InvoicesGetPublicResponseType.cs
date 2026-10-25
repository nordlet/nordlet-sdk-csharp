using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(InvoicesGetPublicResponseType.InvoicesGetPublicResponseTypeSerializer))]
[Serializable]
public readonly record struct InvoicesGetPublicResponseType : IStringEnum
{
    public static readonly InvoicesGetPublicResponseType Invoice = new(Values.Invoice);

    public static readonly InvoicesGetPublicResponseType CreditNote = new(Values.CreditNote);

    public static readonly InvoicesGetPublicResponseType Proforma = new(Values.Proforma);

    public static readonly InvoicesGetPublicResponseType Advance = new(Values.Advance);

    public InvoicesGetPublicResponseType(string value)
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
    public static InvoicesGetPublicResponseType FromCustom(string value)
    {
        return new InvoicesGetPublicResponseType(value);
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

    public static bool operator ==(InvoicesGetPublicResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesGetPublicResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesGetPublicResponseType value) => value.Value;

    public static explicit operator InvoicesGetPublicResponseType(string value) => new(value);

    internal class InvoicesGetPublicResponseTypeSerializer
        : JsonConverter<InvoicesGetPublicResponseType>
    {
        public override InvoicesGetPublicResponseType Read(
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
            return new InvoicesGetPublicResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesGetPublicResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesGetPublicResponseType ReadAsPropertyName(
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
            return new InvoicesGetPublicResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesGetPublicResponseType value,
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
