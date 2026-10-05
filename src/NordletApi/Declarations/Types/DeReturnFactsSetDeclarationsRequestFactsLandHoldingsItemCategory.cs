using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory.DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategorySerializer)
)]
[Serializable]
public readonly record struct DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory
    : IStringEnum
{
    public static readonly DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory RentalEast =
        new(Values.RentalEast);

    public static readonly DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory BusinessEast =
        new(Values.BusinessEast);

    public static readonly DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory MixedEast =
        new(Values.MixedEast);

    public static readonly DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory UndevelopedEast =
        new(Values.UndevelopedEast);

    public static readonly DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory Other =
        new(Values.Other);

    public static readonly DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory Agricultural =
        new(Values.Agricultural);

    public DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory(string value)
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
    public static DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory FromCustom(
        string value
    )
    {
        return new DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory(value);
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
        DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory value
    ) => value.Value;

    public static explicit operator DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory(
        string value
    ) => new(value);

    internal class DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategorySerializer
        : JsonConverter<DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory>
    {
        public override DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory Read(
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
            return new DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory ReadAsPropertyName(
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
            return new DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DeReturnFactsSetDeclarationsRequestFactsLandHoldingsItemCategory value,
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
