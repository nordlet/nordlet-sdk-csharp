using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TransactionsMatchBankRequestDocumentType.TransactionsMatchBankRequestDocumentTypeSerializer)
)]
[Serializable]
public readonly record struct TransactionsMatchBankRequestDocumentType : IStringEnum
{
    public static readonly TransactionsMatchBankRequestDocumentType SaleInvoice = new(
        Values.SaleInvoice
    );

    public static readonly TransactionsMatchBankRequestDocumentType PurchaseInvoice = new(
        Values.PurchaseInvoice
    );

    public TransactionsMatchBankRequestDocumentType(string value)
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
    public static TransactionsMatchBankRequestDocumentType FromCustom(string value)
    {
        return new TransactionsMatchBankRequestDocumentType(value);
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
        TransactionsMatchBankRequestDocumentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TransactionsMatchBankRequestDocumentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TransactionsMatchBankRequestDocumentType value) =>
        value.Value;

    public static explicit operator TransactionsMatchBankRequestDocumentType(string value) =>
        new(value);

    internal class TransactionsMatchBankRequestDocumentTypeSerializer
        : JsonConverter<TransactionsMatchBankRequestDocumentType>
    {
        public override TransactionsMatchBankRequestDocumentType Read(
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
            return new TransactionsMatchBankRequestDocumentType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TransactionsMatchBankRequestDocumentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TransactionsMatchBankRequestDocumentType ReadAsPropertyName(
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
            return new TransactionsMatchBankRequestDocumentType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TransactionsMatchBankRequestDocumentType value,
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
