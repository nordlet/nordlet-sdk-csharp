using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PerDiemRatesListHrRequestFilterItemOp.PerDiemRatesListHrRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct PerDiemRatesListHrRequestFilterItemOp : IStringEnum
{
    public static readonly PerDiemRatesListHrRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly PerDiemRatesListHrRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly PerDiemRatesListHrRequestFilterItemOp Contains = new(Values.Contains);

    public static readonly PerDiemRatesListHrRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly PerDiemRatesListHrRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly PerDiemRatesListHrRequestFilterItemOp In = new(Values.In);

    public PerDiemRatesListHrRequestFilterItemOp(string value)
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
    public static PerDiemRatesListHrRequestFilterItemOp FromCustom(string value)
    {
        return new PerDiemRatesListHrRequestFilterItemOp(value);
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

    public static bool operator ==(PerDiemRatesListHrRequestFilterItemOp value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PerDiemRatesListHrRequestFilterItemOp value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PerDiemRatesListHrRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator PerDiemRatesListHrRequestFilterItemOp(string value) =>
        new(value);

    internal class PerDiemRatesListHrRequestFilterItemOpSerializer
        : JsonConverter<PerDiemRatesListHrRequestFilterItemOp>
    {
        public override PerDiemRatesListHrRequestFilterItemOp Read(
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
            return new PerDiemRatesListHrRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PerDiemRatesListHrRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PerDiemRatesListHrRequestFilterItemOp ReadAsPropertyName(
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
            return new PerDiemRatesListHrRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PerDiemRatesListHrRequestFilterItemOp value,
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
