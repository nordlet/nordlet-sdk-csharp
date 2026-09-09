using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DocumentSeriesCreateRequestDocumentType.PostV1DocumentSeriesCreateRequestDocumentTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1DocumentSeriesCreateRequestDocumentType : IStringEnum
{
    public static readonly PostV1DocumentSeriesCreateRequestDocumentType SaleInvoice = new(
        Values.SaleInvoice
    );

    public static readonly PostV1DocumentSeriesCreateRequestDocumentType SaleCreditNote = new(
        Values.SaleCreditNote
    );

    public static readonly PostV1DocumentSeriesCreateRequestDocumentType SaleProforma = new(
        Values.SaleProforma
    );

    public static readonly PostV1DocumentSeriesCreateRequestDocumentType SaleAdvance = new(
        Values.SaleAdvance
    );

    public PostV1DocumentSeriesCreateRequestDocumentType(string value)
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
    public static PostV1DocumentSeriesCreateRequestDocumentType FromCustom(string value)
    {
        return new PostV1DocumentSeriesCreateRequestDocumentType(value);
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
        PostV1DocumentSeriesCreateRequestDocumentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DocumentSeriesCreateRequestDocumentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1DocumentSeriesCreateRequestDocumentType value) =>
        value.Value;

    public static explicit operator PostV1DocumentSeriesCreateRequestDocumentType(string value) =>
        new(value);

    internal class PostV1DocumentSeriesCreateRequestDocumentTypeSerializer
        : JsonConverter<PostV1DocumentSeriesCreateRequestDocumentType>
    {
        public override PostV1DocumentSeriesCreateRequestDocumentType Read(
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
            return new PostV1DocumentSeriesCreateRequestDocumentType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DocumentSeriesCreateRequestDocumentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DocumentSeriesCreateRequestDocumentType ReadAsPropertyName(
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
            return new PostV1DocumentSeriesCreateRequestDocumentType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DocumentSeriesCreateRequestDocumentType value,
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

        public const string SaleCreditNote = "sale_credit_note";

        public const string SaleProforma = "sale_proforma";

        public const string SaleAdvance = "sale_advance";
    }
}
