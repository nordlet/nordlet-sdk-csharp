using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LandedCostsGetInventoryResponseMethod.LandedCostsGetInventoryResponseMethodSerializer)
)]
[Serializable]
public readonly record struct LandedCostsGetInventoryResponseMethod : IStringEnum
{
    public static readonly LandedCostsGetInventoryResponseMethod ByValue = new(Values.ByValue);

    public static readonly LandedCostsGetInventoryResponseMethod ByQuantity = new(
        Values.ByQuantity
    );

    public LandedCostsGetInventoryResponseMethod(string value)
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
    public static LandedCostsGetInventoryResponseMethod FromCustom(string value)
    {
        return new LandedCostsGetInventoryResponseMethod(value);
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

    public static bool operator ==(LandedCostsGetInventoryResponseMethod value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LandedCostsGetInventoryResponseMethod value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LandedCostsGetInventoryResponseMethod value) =>
        value.Value;

    public static explicit operator LandedCostsGetInventoryResponseMethod(string value) =>
        new(value);

    internal class LandedCostsGetInventoryResponseMethodSerializer
        : JsonConverter<LandedCostsGetInventoryResponseMethod>
    {
        public override LandedCostsGetInventoryResponseMethod Read(
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
            return new LandedCostsGetInventoryResponseMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LandedCostsGetInventoryResponseMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LandedCostsGetInventoryResponseMethod ReadAsPropertyName(
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
            return new LandedCostsGetInventoryResponseMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LandedCostsGetInventoryResponseMethod value,
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
        public const string ByValue = "by_value";

        public const string ByQuantity = "by_quantity";
    }
}
