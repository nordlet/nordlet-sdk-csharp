using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesListPurchasesResponseRowsItemType.InvoicesListPurchasesResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct InvoicesListPurchasesResponseRowsItemType : IStringEnum
{
    public static readonly InvoicesListPurchasesResponseRowsItemType Invoice = new(Values.Invoice);

    public static readonly InvoicesListPurchasesResponseRowsItemType CreditNote = new(
        Values.CreditNote
    );

    public InvoicesListPurchasesResponseRowsItemType(string value)
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
    public static InvoicesListPurchasesResponseRowsItemType FromCustom(string value)
    {
        return new InvoicesListPurchasesResponseRowsItemType(value);
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
        InvoicesListPurchasesResponseRowsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoicesListPurchasesResponseRowsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesListPurchasesResponseRowsItemType value) =>
        value.Value;

    public static explicit operator InvoicesListPurchasesResponseRowsItemType(string value) =>
        new(value);

    internal class InvoicesListPurchasesResponseRowsItemTypeSerializer
        : JsonConverter<InvoicesListPurchasesResponseRowsItemType>
    {
        public override InvoicesListPurchasesResponseRowsItemType Read(
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
            return new InvoicesListPurchasesResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesListPurchasesResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesListPurchasesResponseRowsItemType ReadAsPropertyName(
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
            return new InvoicesListPurchasesResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesListPurchasesResponseRowsItemType value,
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
