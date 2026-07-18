using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory.PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategorySerializer)
)]
[Serializable]
public readonly record struct PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory
    : IStringEnum
{
    public static readonly PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory Standard =
        new(Values.Standard);

    public static readonly PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory Reduced =
        new(Values.Reduced);

    public static readonly PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory SuperReduced =
        new(Values.SuperReduced);

    public static readonly PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory Parking =
        new(Values.Parking);

    public PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory(string value)
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
    public static PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory FromCustom(
        string value
    )
    {
        return new PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory(value);
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
        PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory value
    ) => value.Value;

    public static explicit operator PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory(
        string value
    ) => new(value);

    internal class PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategorySerializer
        : JsonConverter<PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory>
    {
        public override PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory Read(
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
            return new PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory ReadAsPropertyName(
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
            return new PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory value,
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
