using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RoutingsListProductionRequestFilterItemOp.RoutingsListProductionRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct RoutingsListProductionRequestFilterItemOp : IStringEnum
{
    public static readonly RoutingsListProductionRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly RoutingsListProductionRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly RoutingsListProductionRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly RoutingsListProductionRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly RoutingsListProductionRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly RoutingsListProductionRequestFilterItemOp In = new(Values.In);

    public RoutingsListProductionRequestFilterItemOp(string value)
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
    public static RoutingsListProductionRequestFilterItemOp FromCustom(string value)
    {
        return new RoutingsListProductionRequestFilterItemOp(value);
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
        RoutingsListProductionRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RoutingsListProductionRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RoutingsListProductionRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator RoutingsListProductionRequestFilterItemOp(string value) =>
        new(value);

    internal class RoutingsListProductionRequestFilterItemOpSerializer
        : JsonConverter<RoutingsListProductionRequestFilterItemOp>
    {
        public override RoutingsListProductionRequestFilterItemOp Read(
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
            return new RoutingsListProductionRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RoutingsListProductionRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RoutingsListProductionRequestFilterItemOp ReadAsPropertyName(
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
            return new RoutingsListProductionRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RoutingsListProductionRequestFilterItemOp value,
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
