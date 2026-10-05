using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LandedCostsListInventoryResponseRowsItemMethod.LandedCostsListInventoryResponseRowsItemMethodSerializer)
)]
[Serializable]
public readonly record struct LandedCostsListInventoryResponseRowsItemMethod : IStringEnum
{
    public static readonly LandedCostsListInventoryResponseRowsItemMethod ByValue = new(
        Values.ByValue
    );

    public static readonly LandedCostsListInventoryResponseRowsItemMethod ByQuantity = new(
        Values.ByQuantity
    );

    public LandedCostsListInventoryResponseRowsItemMethod(string value)
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
    public static LandedCostsListInventoryResponseRowsItemMethod FromCustom(string value)
    {
        return new LandedCostsListInventoryResponseRowsItemMethod(value);
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
        LandedCostsListInventoryResponseRowsItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LandedCostsListInventoryResponseRowsItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(LandedCostsListInventoryResponseRowsItemMethod value) =>
        value.Value;

    public static explicit operator LandedCostsListInventoryResponseRowsItemMethod(string value) =>
        new(value);

    internal class LandedCostsListInventoryResponseRowsItemMethodSerializer
        : JsonConverter<LandedCostsListInventoryResponseRowsItemMethod>
    {
        public override LandedCostsListInventoryResponseRowsItemMethod Read(
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
            return new LandedCostsListInventoryResponseRowsItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LandedCostsListInventoryResponseRowsItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LandedCostsListInventoryResponseRowsItemMethod ReadAsPropertyName(
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
            return new LandedCostsListInventoryResponseRowsItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LandedCostsListInventoryResponseRowsItemMethod value,
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
