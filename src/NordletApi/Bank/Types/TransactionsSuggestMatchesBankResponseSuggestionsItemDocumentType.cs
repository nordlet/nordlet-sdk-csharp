using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType.TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentTypeSerializer)
)]
[Serializable]
public readonly record struct TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType
    : IStringEnum
{
    public static readonly TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType SaleInvoice =
        new(Values.SaleInvoice);

    public static readonly TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType PurchaseInvoice =
        new(Values.PurchaseInvoice);

    public static readonly TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType PayrollRun =
        new(Values.PayrollRun);

    public TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType(string value)
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
    public static TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType FromCustom(
        string value
    )
    {
        return new TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType(value);
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
        TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType value
    ) => value.Value;

    public static explicit operator TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType(
        string value
    ) => new(value);

    internal class TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentTypeSerializer
        : JsonConverter<TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType>
    {
        public override TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType Read(
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
            return new TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType ReadAsPropertyName(
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
            return new TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TransactionsSuggestMatchesBankResponseSuggestionsItemDocumentType value,
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
