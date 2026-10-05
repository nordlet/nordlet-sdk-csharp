using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesMatchPurchasesResponseRowsItemStatus.InvoicesMatchPurchasesResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct InvoicesMatchPurchasesResponseRowsItemStatus : IStringEnum
{
    public static readonly InvoicesMatchPurchasesResponseRowsItemStatus Matched = new(
        Values.Matched
    );

    public static readonly InvoicesMatchPurchasesResponseRowsItemStatus NotReceived = new(
        Values.NotReceived
    );

    public static readonly InvoicesMatchPurchasesResponseRowsItemStatus OverInvoiced = new(
        Values.OverInvoiced
    );

    public static readonly InvoicesMatchPurchasesResponseRowsItemStatus PriceMismatch = new(
        Values.PriceMismatch
    );

    public static readonly InvoicesMatchPurchasesResponseRowsItemStatus NotOnOrder = new(
        Values.NotOnOrder
    );

    public static readonly InvoicesMatchPurchasesResponseRowsItemStatus NotInvoiced = new(
        Values.NotInvoiced
    );

    public InvoicesMatchPurchasesResponseRowsItemStatus(string value)
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
    public static InvoicesMatchPurchasesResponseRowsItemStatus FromCustom(string value)
    {
        return new InvoicesMatchPurchasesResponseRowsItemStatus(value);
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
        InvoicesMatchPurchasesResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoicesMatchPurchasesResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesMatchPurchasesResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator InvoicesMatchPurchasesResponseRowsItemStatus(string value) =>
        new(value);

    internal class InvoicesMatchPurchasesResponseRowsItemStatusSerializer
        : JsonConverter<InvoicesMatchPurchasesResponseRowsItemStatus>
    {
        public override InvoicesMatchPurchasesResponseRowsItemStatus Read(
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
            return new InvoicesMatchPurchasesResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesMatchPurchasesResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesMatchPurchasesResponseRowsItemStatus ReadAsPropertyName(
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
            return new InvoicesMatchPurchasesResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesMatchPurchasesResponseRowsItemStatus value,
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
        public const string Matched = "matched";

        public const string NotReceived = "not_received";

        public const string OverInvoiced = "over_invoiced";

        public const string PriceMismatch = "price_mismatch";

        public const string NotOnOrder = "not_on_order";

        public const string NotInvoiced = "not_invoiced";
    }
}
