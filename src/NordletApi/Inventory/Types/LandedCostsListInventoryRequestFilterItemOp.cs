using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LandedCostsListInventoryRequestFilterItemOp.LandedCostsListInventoryRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct LandedCostsListInventoryRequestFilterItemOp : IStringEnum
{
    public static readonly LandedCostsListInventoryRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly LandedCostsListInventoryRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly LandedCostsListInventoryRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly LandedCostsListInventoryRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly LandedCostsListInventoryRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly LandedCostsListInventoryRequestFilterItemOp In = new(Values.In);

    public LandedCostsListInventoryRequestFilterItemOp(string value)
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
    public static LandedCostsListInventoryRequestFilterItemOp FromCustom(string value)
    {
        return new LandedCostsListInventoryRequestFilterItemOp(value);
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
        LandedCostsListInventoryRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LandedCostsListInventoryRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(LandedCostsListInventoryRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator LandedCostsListInventoryRequestFilterItemOp(string value) =>
        new(value);

    internal class LandedCostsListInventoryRequestFilterItemOpSerializer
        : JsonConverter<LandedCostsListInventoryRequestFilterItemOp>
    {
        public override LandedCostsListInventoryRequestFilterItemOp Read(
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
            return new LandedCostsListInventoryRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LandedCostsListInventoryRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LandedCostsListInventoryRequestFilterItemOp ReadAsPropertyName(
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
            return new LandedCostsListInventoryRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LandedCostsListInventoryRequestFilterItemOp value,
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
        public const string Eq = "eq";

        public const string Ne = "ne";

        public const string Contains = "contains";

        public const string Gte = "gte";

        public const string Lte = "lte";

        public const string In = "in";
    }
}
