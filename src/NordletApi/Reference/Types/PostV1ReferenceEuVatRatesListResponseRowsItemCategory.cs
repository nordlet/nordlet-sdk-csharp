using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReferenceEuVatRatesListResponseRowsItemCategory.PostV1ReferenceEuVatRatesListResponseRowsItemCategorySerializer)
)]
[Serializable]
public readonly record struct PostV1ReferenceEuVatRatesListResponseRowsItemCategory : IStringEnum
{
    public static readonly PostV1ReferenceEuVatRatesListResponseRowsItemCategory Standard = new(
        Values.Standard
    );

    public static readonly PostV1ReferenceEuVatRatesListResponseRowsItemCategory Reduced = new(
        Values.Reduced
    );

    public static readonly PostV1ReferenceEuVatRatesListResponseRowsItemCategory SuperReduced = new(
        Values.SuperReduced
    );

    public static readonly PostV1ReferenceEuVatRatesListResponseRowsItemCategory Parking = new(
        Values.Parking
    );

    public PostV1ReferenceEuVatRatesListResponseRowsItemCategory(string value)
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
    public static PostV1ReferenceEuVatRatesListResponseRowsItemCategory FromCustom(string value)
    {
        return new PostV1ReferenceEuVatRatesListResponseRowsItemCategory(value);
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
        PostV1ReferenceEuVatRatesListResponseRowsItemCategory value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ReferenceEuVatRatesListResponseRowsItemCategory value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ReferenceEuVatRatesListResponseRowsItemCategory value
    ) => value.Value;

    public static explicit operator PostV1ReferenceEuVatRatesListResponseRowsItemCategory(
        string value
    ) => new(value);

    internal class PostV1ReferenceEuVatRatesListResponseRowsItemCategorySerializer
        : JsonConverter<PostV1ReferenceEuVatRatesListResponseRowsItemCategory>
    {
        public override PostV1ReferenceEuVatRatesListResponseRowsItemCategory Read(
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
            return new PostV1ReferenceEuVatRatesListResponseRowsItemCategory(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReferenceEuVatRatesListResponseRowsItemCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReferenceEuVatRatesListResponseRowsItemCategory ReadAsPropertyName(
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
            return new PostV1ReferenceEuVatRatesListResponseRowsItemCategory(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReferenceEuVatRatesListResponseRowsItemCategory value,
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
        public const string Standard = "standard";

        public const string Reduced = "reduced";

        public const string SuperReduced = "super_reduced";

        public const string Parking = "parking";
    }
}
