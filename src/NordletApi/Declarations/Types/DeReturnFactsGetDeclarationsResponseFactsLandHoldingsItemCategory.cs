using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory.DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategorySerializer)
)]
[Serializable]
public readonly record struct DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory
    : IStringEnum
{
    public static readonly DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory RentalEast =
        new(Values.RentalEast);

    public static readonly DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory BusinessEast =
        new(Values.BusinessEast);

    public static readonly DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory MixedEast =
        new(Values.MixedEast);

    public static readonly DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory UndevelopedEast =
        new(Values.UndevelopedEast);

    public static readonly DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory Other =
        new(Values.Other);

    public static readonly DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory Agricultural =
        new(Values.Agricultural);

    public DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory(string value)
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
    public static DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory FromCustom(
        string value
    )
    {
        return new DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory(value);
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
        DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory value
    ) => value.Value;

    public static explicit operator DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory(
        string value
    ) => new(value);

    internal class DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategorySerializer
        : JsonConverter<DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory>
    {
        public override DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory Read(
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
            return new DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory ReadAsPropertyName(
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
            return new DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DeReturnFactsGetDeclarationsResponseFactsLandHoldingsItemCategory value,
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
