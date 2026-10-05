using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LandedCostsCreateInventoryResponseMethod.LandedCostsCreateInventoryResponseMethodSerializer)
)]
[Serializable]
public readonly record struct LandedCostsCreateInventoryResponseMethod : IStringEnum
{
    public static readonly LandedCostsCreateInventoryResponseMethod ByValue = new(Values.ByValue);

    public static readonly LandedCostsCreateInventoryResponseMethod ByQuantity = new(
        Values.ByQuantity
    );

    public LandedCostsCreateInventoryResponseMethod(string value)
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
    public static LandedCostsCreateInventoryResponseMethod FromCustom(string value)
    {
        return new LandedCostsCreateInventoryResponseMethod(value);
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
        LandedCostsCreateInventoryResponseMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LandedCostsCreateInventoryResponseMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(LandedCostsCreateInventoryResponseMethod value) =>
        value.Value;

    public static explicit operator LandedCostsCreateInventoryResponseMethod(string value) =>
        new(value);

    internal class LandedCostsCreateInventoryResponseMethodSerializer
        : JsonConverter<LandedCostsCreateInventoryResponseMethod>
    {
        public override LandedCostsCreateInventoryResponseMethod Read(
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
            return new LandedCostsCreateInventoryResponseMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LandedCostsCreateInventoryResponseMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LandedCostsCreateInventoryResponseMethod ReadAsPropertyName(
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
            return new LandedCostsCreateInventoryResponseMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LandedCostsCreateInventoryResponseMethod value,
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
