using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReferenceVatResolveResponseRatesItemCategory.PostV1ReferenceVatResolveResponseRatesItemCategorySerializer)
)]
[Serializable]
public readonly record struct PostV1ReferenceVatResolveResponseRatesItemCategory : IStringEnum
{
    public static readonly PostV1ReferenceVatResolveResponseRatesItemCategory Standard = new(
        Values.Standard
    );

    public static readonly PostV1ReferenceVatResolveResponseRatesItemCategory Reduced = new(
        Values.Reduced
    );

    public static readonly PostV1ReferenceVatResolveResponseRatesItemCategory SuperReduced = new(
        Values.SuperReduced
    );

    public static readonly PostV1ReferenceVatResolveResponseRatesItemCategory Parking = new(
        Values.Parking
    );

    public PostV1ReferenceVatResolveResponseRatesItemCategory(string value)
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
    public static PostV1ReferenceVatResolveResponseRatesItemCategory FromCustom(string value)
    {
        return new PostV1ReferenceVatResolveResponseRatesItemCategory(value);
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
        PostV1ReferenceVatResolveResponseRatesItemCategory value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ReferenceVatResolveResponseRatesItemCategory value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ReferenceVatResolveResponseRatesItemCategory value
    ) => value.Value;

    public static explicit operator PostV1ReferenceVatResolveResponseRatesItemCategory(
        string value
    ) => new(value);

    internal class PostV1ReferenceVatResolveResponseRatesItemCategorySerializer
        : JsonConverter<PostV1ReferenceVatResolveResponseRatesItemCategory>
    {
        public override PostV1ReferenceVatResolveResponseRatesItemCategory Read(
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
            return new PostV1ReferenceVatResolveResponseRatesItemCategory(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReferenceVatResolveResponseRatesItemCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReferenceVatResolveResponseRatesItemCategory ReadAsPropertyName(
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
            return new PostV1ReferenceVatResolveResponseRatesItemCategory(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReferenceVatResolveResponseRatesItemCategory value,
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
