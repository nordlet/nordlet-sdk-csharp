using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TransactionsSuggestMatchesBankResponseAllocationsItemDocumentType.TransactionsSuggestMatchesBankResponseAllocationsItemDocumentTypeSerializer)
)]
[Serializable]
public readonly record struct TransactionsSuggestMatchesBankResponseAllocationsItemDocumentType
    : IStringEnum
{
    public static readonly TransactionsSuggestMatchesBankResponseAllocationsItemDocumentType SaleInvoice =
        new(Values.SaleInvoice);

    public static readonly TransactionsSuggestMatchesBankResponseAllocationsItemDocumentType PurchaseInvoice =
        new(Values.PurchaseInvoice);

    public TransactionsSuggestMatchesBankResponseAllocationsItemDocumentType(string value)
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
    public static TransactionsSuggestMatchesBankResponseAllocationsItemDocumentType FromCustom(
        string value
    )
    {
        return new TransactionsSuggestMatchesBankResponseAllocationsItemDocumentType(value);
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
        TransactionsSuggestMatchesBankResponseAllocationsItemDocumentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TransactionsSuggestMatchesBankResponseAllocationsItemDocumentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        TransactionsSuggestMatchesBankResponseAllocationsItemDocumentType value
    ) => value.Value;

    public static explicit operator TransactionsSuggestMatchesBankResponseAllocationsItemDocumentType(
        string value
    ) => new(value);

    internal class TransactionsSuggestMatchesBankResponseAllocationsItemDocumentTypeSerializer
        : JsonConverter<TransactionsSuggestMatchesBankResponseAllocationsItemDocumentType>
    {
        public override TransactionsSuggestMatchesBankResponseAllocationsItemDocumentType Read(
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
            return new TransactionsSuggestMatchesBankResponseAllocationsItemDocumentType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            TransactionsSuggestMatchesBankResponseAllocationsItemDocumentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TransactionsSuggestMatchesBankResponseAllocationsItemDocumentType ReadAsPropertyName(
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
            return new TransactionsSuggestMatchesBankResponseAllocationsItemDocumentType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TransactionsSuggestMatchesBankResponseAllocationsItemDocumentType value,
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
        public const string SaleInvoice = "sale_invoice";

        public const string PurchaseInvoice = "purchase_invoice";
    }
}
