using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1OperationTypesCreateResponseInvoiceType.PostV1OperationTypesCreateResponseInvoiceTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1OperationTypesCreateResponseInvoiceType : IStringEnum
{
    public static readonly PostV1OperationTypesCreateResponseInvoiceType Invoice = new(
        Values.Invoice
    );

    public static readonly PostV1OperationTypesCreateResponseInvoiceType CreditNote = new(
        Values.CreditNote
    );

    public static readonly PostV1OperationTypesCreateResponseInvoiceType Proforma = new(
        Values.Proforma
    );

    public static readonly PostV1OperationTypesCreateResponseInvoiceType Advance = new(
        Values.Advance
    );

    public PostV1OperationTypesCreateResponseInvoiceType(string value)
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
    public static PostV1OperationTypesCreateResponseInvoiceType FromCustom(string value)
    {
        return new PostV1OperationTypesCreateResponseInvoiceType(value);
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
        PostV1OperationTypesCreateResponseInvoiceType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1OperationTypesCreateResponseInvoiceType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1OperationTypesCreateResponseInvoiceType value) =>
        value.Value;

    public static explicit operator PostV1OperationTypesCreateResponseInvoiceType(string value) =>
        new(value);

    internal class PostV1OperationTypesCreateResponseInvoiceTypeSerializer
        : JsonConverter<PostV1OperationTypesCreateResponseInvoiceType>
    {
        public override PostV1OperationTypesCreateResponseInvoiceType Read(
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
            return new PostV1OperationTypesCreateResponseInvoiceType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1OperationTypesCreateResponseInvoiceType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1OperationTypesCreateResponseInvoiceType ReadAsPropertyName(
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
            return new PostV1OperationTypesCreateResponseInvoiceType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1OperationTypesCreateResponseInvoiceType value,
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
