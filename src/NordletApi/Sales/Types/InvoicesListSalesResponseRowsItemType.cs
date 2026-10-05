using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesListSalesResponseRowsItemType.InvoicesListSalesResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct InvoicesListSalesResponseRowsItemType : IStringEnum
{
    public static readonly InvoicesListSalesResponseRowsItemType Invoice = new(Values.Invoice);

    public static readonly InvoicesListSalesResponseRowsItemType CreditNote = new(
        Values.CreditNote
    );

    public static readonly InvoicesListSalesResponseRowsItemType Proforma = new(Values.Proforma);

    public static readonly InvoicesListSalesResponseRowsItemType Advance = new(Values.Advance);

    public InvoicesListSalesResponseRowsItemType(string value)
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
    public static InvoicesListSalesResponseRowsItemType FromCustom(string value)
    {
        return new InvoicesListSalesResponseRowsItemType(value);
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

    public static bool operator ==(InvoicesListSalesResponseRowsItemType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesListSalesResponseRowsItemType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesListSalesResponseRowsItemType value) =>
        value.Value;

    public static explicit operator InvoicesListSalesResponseRowsItemType(string value) =>
        new(value);

    internal class InvoicesListSalesResponseRowsItemTypeSerializer
        : JsonConverter<InvoicesListSalesResponseRowsItemType>
    {
        public override InvoicesListSalesResponseRowsItemType Read(
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
            return new InvoicesListSalesResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesListSalesResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesListSalesResponseRowsItemType ReadAsPropertyName(
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
            return new InvoicesListSalesResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesListSalesResponseRowsItemType value,
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
