using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankTransactionsRecordRequestDocumentType.PostV1BankTransactionsRecordRequestDocumentTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1BankTransactionsRecordRequestDocumentType : IStringEnum
{
    public static readonly PostV1BankTransactionsRecordRequestDocumentType SaleInvoice = new(
        Values.SaleInvoice
    );

    public static readonly PostV1BankTransactionsRecordRequestDocumentType PurchaseInvoice = new(
        Values.PurchaseInvoice
    );

    public PostV1BankTransactionsRecordRequestDocumentType(string value)
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
    public static PostV1BankTransactionsRecordRequestDocumentType FromCustom(string value)
    {
        return new PostV1BankTransactionsRecordRequestDocumentType(value);
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
        PostV1BankTransactionsRecordRequestDocumentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankTransactionsRecordRequestDocumentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankTransactionsRecordRequestDocumentType value) =>
        value.Value;

    public static explicit operator PostV1BankTransactionsRecordRequestDocumentType(string value) =>
        new(value);

    internal class PostV1BankTransactionsRecordRequestDocumentTypeSerializer
        : JsonConverter<PostV1BankTransactionsRecordRequestDocumentType>
    {
        public override PostV1BankTransactionsRecordRequestDocumentType Read(
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
            return new PostV1BankTransactionsRecordRequestDocumentType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankTransactionsRecordRequestDocumentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankTransactionsRecordRequestDocumentType ReadAsPropertyName(
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
            return new PostV1BankTransactionsRecordRequestDocumentType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankTransactionsRecordRequestDocumentType value,
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
