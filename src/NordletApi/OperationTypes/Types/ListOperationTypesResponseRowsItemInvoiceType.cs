using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ListOperationTypesResponseRowsItemInvoiceType.ListOperationTypesResponseRowsItemInvoiceTypeSerializer)
)]
[Serializable]
public readonly record struct ListOperationTypesResponseRowsItemInvoiceType : IStringEnum
{
    public static readonly ListOperationTypesResponseRowsItemInvoiceType Invoice = new(
        Values.Invoice
    );

    public static readonly ListOperationTypesResponseRowsItemInvoiceType CreditNote = new(
        Values.CreditNote
    );

    public static readonly ListOperationTypesResponseRowsItemInvoiceType Proforma = new(
        Values.Proforma
    );

    public static readonly ListOperationTypesResponseRowsItemInvoiceType Advance = new(
        Values.Advance
    );

    public ListOperationTypesResponseRowsItemInvoiceType(string value)
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
    public static ListOperationTypesResponseRowsItemInvoiceType FromCustom(string value)
    {
        return new ListOperationTypesResponseRowsItemInvoiceType(value);
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
        ListOperationTypesResponseRowsItemInvoiceType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListOperationTypesResponseRowsItemInvoiceType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListOperationTypesResponseRowsItemInvoiceType value) =>
        value.Value;

    public static explicit operator ListOperationTypesResponseRowsItemInvoiceType(string value) =>
        new(value);

    internal class ListOperationTypesResponseRowsItemInvoiceTypeSerializer
        : JsonConverter<ListOperationTypesResponseRowsItemInvoiceType>
    {
        public override ListOperationTypesResponseRowsItemInvoiceType Read(
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
            return new ListOperationTypesResponseRowsItemInvoiceType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListOperationTypesResponseRowsItemInvoiceType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListOperationTypesResponseRowsItemInvoiceType ReadAsPropertyName(
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
            return new ListOperationTypesResponseRowsItemInvoiceType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListOperationTypesResponseRowsItemInvoiceType value,
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
