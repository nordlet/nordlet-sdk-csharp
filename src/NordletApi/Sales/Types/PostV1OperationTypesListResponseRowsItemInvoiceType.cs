using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1OperationTypesListResponseRowsItemInvoiceType.PostV1OperationTypesListResponseRowsItemInvoiceTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1OperationTypesListResponseRowsItemInvoiceType : IStringEnum
{
    public static readonly PostV1OperationTypesListResponseRowsItemInvoiceType Invoice = new(
        Values.Invoice
    );

    public static readonly PostV1OperationTypesListResponseRowsItemInvoiceType CreditNote = new(
        Values.CreditNote
    );

    public static readonly PostV1OperationTypesListResponseRowsItemInvoiceType Proforma = new(
        Values.Proforma
    );

    public static readonly PostV1OperationTypesListResponseRowsItemInvoiceType Advance = new(
        Values.Advance
    );

    public PostV1OperationTypesListResponseRowsItemInvoiceType(string value)
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
    public static PostV1OperationTypesListResponseRowsItemInvoiceType FromCustom(string value)
    {
        return new PostV1OperationTypesListResponseRowsItemInvoiceType(value);
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
        PostV1OperationTypesListResponseRowsItemInvoiceType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1OperationTypesListResponseRowsItemInvoiceType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1OperationTypesListResponseRowsItemInvoiceType value
    ) => value.Value;

    public static explicit operator PostV1OperationTypesListResponseRowsItemInvoiceType(
        string value
    ) => new(value);

    internal class PostV1OperationTypesListResponseRowsItemInvoiceTypeSerializer
        : JsonConverter<PostV1OperationTypesListResponseRowsItemInvoiceType>
    {
        public override PostV1OperationTypesListResponseRowsItemInvoiceType Read(
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
            return new PostV1OperationTypesListResponseRowsItemInvoiceType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1OperationTypesListResponseRowsItemInvoiceType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1OperationTypesListResponseRowsItemInvoiceType ReadAsPropertyName(
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
            return new PostV1OperationTypesListResponseRowsItemInvoiceType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1OperationTypesListResponseRowsItemInvoiceType value,
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
