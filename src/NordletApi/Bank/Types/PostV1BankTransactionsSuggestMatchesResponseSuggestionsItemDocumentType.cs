using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType.PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType
    : IStringEnum
{
    public static readonly PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType SaleInvoice =
        new(Values.SaleInvoice);

    public static readonly PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType PurchaseInvoice =
        new(Values.PurchaseInvoice);

    public PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType(string value)
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
    public static PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType FromCustom(
        string value
    )
    {
        return new PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType(value);
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
        PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType value
    ) => value.Value;

    public static explicit operator PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType(
        string value
    ) => new(value);

    internal class PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentTypeSerializer
        : JsonConverter<PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType>
    {
        public override PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType Read(
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
            return new PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType ReadAsPropertyName(
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
            return new PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType value,
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
