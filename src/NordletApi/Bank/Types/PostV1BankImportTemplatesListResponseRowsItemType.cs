using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankImportTemplatesListResponseRowsItemType.PostV1BankImportTemplatesListResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1BankImportTemplatesListResponseRowsItemType : IStringEnum
{
    public static readonly PostV1BankImportTemplatesListResponseRowsItemType Stripe = new(
        Values.Stripe
    );

    public static readonly PostV1BankImportTemplatesListResponseRowsItemType Iso20022 = new(
        Values.Iso20022
    );

    public static readonly PostV1BankImportTemplatesListResponseRowsItemType BankConnection = new(
        Values.BankConnection
    );

    public PostV1BankImportTemplatesListResponseRowsItemType(string value)
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
    public static PostV1BankImportTemplatesListResponseRowsItemType FromCustom(string value)
    {
        return new PostV1BankImportTemplatesListResponseRowsItemType(value);
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
        PostV1BankImportTemplatesListResponseRowsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankImportTemplatesListResponseRowsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1BankImportTemplatesListResponseRowsItemType value
    ) => value.Value;

    public static explicit operator PostV1BankImportTemplatesListResponseRowsItemType(
        string value
    ) => new(value);

    internal class PostV1BankImportTemplatesListResponseRowsItemTypeSerializer
        : JsonConverter<PostV1BankImportTemplatesListResponseRowsItemType>
    {
        public override PostV1BankImportTemplatesListResponseRowsItemType Read(
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
            return new PostV1BankImportTemplatesListResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankImportTemplatesListResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankImportTemplatesListResponseRowsItemType ReadAsPropertyName(
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
            return new PostV1BankImportTemplatesListResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankImportTemplatesListResponseRowsItemType value,
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
        public const string Stripe = "stripe";

        public const string Iso20022 = "iso20022";

        public const string BankConnection = "bank_connection";
    }
}
