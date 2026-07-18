using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory.PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategorySerializer)
)]
[Serializable]
public readonly record struct PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory
    : IStringEnum
{
    public static readonly PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory Standard =
        new(Values.Standard);

    public static readonly PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory Reduced =
        new(Values.Reduced);

    public static readonly PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory SuperReduced =
        new(Values.SuperReduced);

    public static readonly PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory Parking =
        new(Values.Parking);

    public PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory(string value)
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
    public static PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory FromCustom(
        string value
    )
    {
        return new PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory(value);
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
        PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory value
    ) => value.Value;

    public static explicit operator PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory(
        string value
    ) => new(value);

    internal class PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategorySerializer
        : JsonConverter<PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory>
    {
        public override PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory Read(
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
            return new PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory ReadAsPropertyName(
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
            return new PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReferenceEuVatRatesSetOverridesResponseRowsItemCategory value,
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
