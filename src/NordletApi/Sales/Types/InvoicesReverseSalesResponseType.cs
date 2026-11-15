using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(InvoicesReverseSalesResponseType.InvoicesReverseSalesResponseTypeSerializer))]
[Serializable]
public readonly record struct InvoicesReverseSalesResponseType : IStringEnum
{
    public static readonly InvoicesReverseSalesResponseType Invoice = new(Values.Invoice);

    public static readonly InvoicesReverseSalesResponseType CreditNote = new(Values.CreditNote);

    public static readonly InvoicesReverseSalesResponseType Proforma = new(Values.Proforma);

    public static readonly InvoicesReverseSalesResponseType Advance = new(Values.Advance);

    public InvoicesReverseSalesResponseType(string value)
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
    public static InvoicesReverseSalesResponseType FromCustom(string value)
    {
        return new InvoicesReverseSalesResponseType(value);
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

    public static bool operator ==(InvoicesReverseSalesResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesReverseSalesResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesReverseSalesResponseType value) => value.Value;

    public static explicit operator InvoicesReverseSalesResponseType(string value) => new(value);

    internal class InvoicesReverseSalesResponseTypeSerializer
        : JsonConverter<InvoicesReverseSalesResponseType>
    {
        public override InvoicesReverseSalesResponseType Read(
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
            return new InvoicesReverseSalesResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesReverseSalesResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesReverseSalesResponseType ReadAsPropertyName(
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
            return new InvoicesReverseSalesResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesReverseSalesResponseType value,
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
