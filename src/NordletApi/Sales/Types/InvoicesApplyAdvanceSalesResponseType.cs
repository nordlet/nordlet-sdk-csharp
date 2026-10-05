using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesApplyAdvanceSalesResponseType.InvoicesApplyAdvanceSalesResponseTypeSerializer)
)]
[Serializable]
public readonly record struct InvoicesApplyAdvanceSalesResponseType : IStringEnum
{
    public static readonly InvoicesApplyAdvanceSalesResponseType Invoice = new(Values.Invoice);

    public static readonly InvoicesApplyAdvanceSalesResponseType CreditNote = new(
        Values.CreditNote
    );

    public static readonly InvoicesApplyAdvanceSalesResponseType Proforma = new(Values.Proforma);

    public static readonly InvoicesApplyAdvanceSalesResponseType Advance = new(Values.Advance);

    public InvoicesApplyAdvanceSalesResponseType(string value)
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
    public static InvoicesApplyAdvanceSalesResponseType FromCustom(string value)
    {
        return new InvoicesApplyAdvanceSalesResponseType(value);
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

    public static bool operator ==(InvoicesApplyAdvanceSalesResponseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesApplyAdvanceSalesResponseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesApplyAdvanceSalesResponseType value) =>
        value.Value;

    public static explicit operator InvoicesApplyAdvanceSalesResponseType(string value) =>
        new(value);

    internal class InvoicesApplyAdvanceSalesResponseTypeSerializer
        : JsonConverter<InvoicesApplyAdvanceSalesResponseType>
    {
        public override InvoicesApplyAdvanceSalesResponseType Read(
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
            return new InvoicesApplyAdvanceSalesResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesApplyAdvanceSalesResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesApplyAdvanceSalesResponseType ReadAsPropertyName(
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
            return new InvoicesApplyAdvanceSalesResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesApplyAdvanceSalesResponseType value,
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
