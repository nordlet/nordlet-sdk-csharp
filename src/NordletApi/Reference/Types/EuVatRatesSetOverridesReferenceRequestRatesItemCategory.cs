using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EuVatRatesSetOverridesReferenceRequestRatesItemCategory.EuVatRatesSetOverridesReferenceRequestRatesItemCategorySerializer)
)]
[Serializable]
public readonly record struct EuVatRatesSetOverridesReferenceRequestRatesItemCategory : IStringEnum
{
    public static readonly EuVatRatesSetOverridesReferenceRequestRatesItemCategory Standard = new(
        Values.Standard
    );

    public static readonly EuVatRatesSetOverridesReferenceRequestRatesItemCategory Reduced = new(
        Values.Reduced
    );

    public static readonly EuVatRatesSetOverridesReferenceRequestRatesItemCategory SuperReduced =
        new(Values.SuperReduced);

    public static readonly EuVatRatesSetOverridesReferenceRequestRatesItemCategory Parking = new(
        Values.Parking
    );

    public EuVatRatesSetOverridesReferenceRequestRatesItemCategory(string value)
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
    public static EuVatRatesSetOverridesReferenceRequestRatesItemCategory FromCustom(string value)
    {
        return new EuVatRatesSetOverridesReferenceRequestRatesItemCategory(value);
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
        EuVatRatesSetOverridesReferenceRequestRatesItemCategory value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EuVatRatesSetOverridesReferenceRequestRatesItemCategory value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EuVatRatesSetOverridesReferenceRequestRatesItemCategory value
    ) => value.Value;

    public static explicit operator EuVatRatesSetOverridesReferenceRequestRatesItemCategory(
        string value
    ) => new(value);

    internal class EuVatRatesSetOverridesReferenceRequestRatesItemCategorySerializer
        : JsonConverter<EuVatRatesSetOverridesReferenceRequestRatesItemCategory>
    {
        public override EuVatRatesSetOverridesReferenceRequestRatesItemCategory Read(
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
            return new EuVatRatesSetOverridesReferenceRequestRatesItemCategory(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EuVatRatesSetOverridesReferenceRequestRatesItemCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EuVatRatesSetOverridesReferenceRequestRatesItemCategory ReadAsPropertyName(
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
            return new EuVatRatesSetOverridesReferenceRequestRatesItemCategory(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EuVatRatesSetOverridesReferenceRequestRatesItemCategory value,
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
