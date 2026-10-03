using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory.PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategorySerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory
    : IStringEnum
{
    public static readonly PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory RentalEast =
        new(Values.RentalEast);

    public static readonly PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory BusinessEast =
        new(Values.BusinessEast);

    public static readonly PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory MixedEast =
        new(Values.MixedEast);

    public static readonly PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory UndevelopedEast =
        new(Values.UndevelopedEast);

    public static readonly PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory Other =
        new(Values.Other);

    public static readonly PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory Agricultural =
        new(Values.Agricultural);

    public PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory(string value)
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
    public static PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory(value);
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
        PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory(
        string value
    ) => new(value);

    internal class PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategorySerializer
        : JsonConverter<PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory>
    {
        public override PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory Read(
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
            return new PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory ReadAsPropertyName(
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
            return new PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsDeReturnFactsSetRequestFactsLandHoldingsItemCategory value,
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
        public const string RentalEast = "rental_east";

        public const string BusinessEast = "business_east";

        public const string MixedEast = "mixed_east";

        public const string UndevelopedEast = "undeveloped_east";

        public const string Other = "other";

        public const string Agricultural = "agricultural";
    }
}
