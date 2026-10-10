using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TransactionsRecordBankRequestDocumentType.TransactionsRecordBankRequestDocumentTypeSerializer)
)]
[Serializable]
public readonly record struct TransactionsRecordBankRequestDocumentType : IStringEnum
{
    public static readonly TransactionsRecordBankRequestDocumentType SaleInvoice = new(
        Values.SaleInvoice
    );

    public static readonly TransactionsRecordBankRequestDocumentType PurchaseInvoice = new(
        Values.PurchaseInvoice
    );

    public static readonly TransactionsRecordBankRequestDocumentType PayrollRun = new(
        Values.PayrollRun
    );

    public TransactionsRecordBankRequestDocumentType(string value)
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
    public static TransactionsRecordBankRequestDocumentType FromCustom(string value)
    {
        return new TransactionsRecordBankRequestDocumentType(value);
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
        TransactionsRecordBankRequestDocumentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TransactionsRecordBankRequestDocumentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TransactionsRecordBankRequestDocumentType value) =>
        value.Value;

    public static explicit operator TransactionsRecordBankRequestDocumentType(string value) =>
        new(value);

    internal class TransactionsRecordBankRequestDocumentTypeSerializer
        : JsonConverter<TransactionsRecordBankRequestDocumentType>
    {
        public override TransactionsRecordBankRequestDocumentType Read(
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
            return new TransactionsRecordBankRequestDocumentType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TransactionsRecordBankRequestDocumentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TransactionsRecordBankRequestDocumentType ReadAsPropertyName(
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
            return new TransactionsRecordBankRequestDocumentType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TransactionsRecordBankRequestDocumentType value,
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

        public const string PayrollRun = "payroll_run";
    }
}
