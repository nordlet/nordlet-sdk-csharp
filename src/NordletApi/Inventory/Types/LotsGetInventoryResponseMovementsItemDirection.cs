using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LotsGetInventoryResponseMovementsItemDirection.LotsGetInventoryResponseMovementsItemDirectionSerializer)
)]
[Serializable]
public readonly record struct LotsGetInventoryResponseMovementsItemDirection : IStringEnum
{
    public static readonly LotsGetInventoryResponseMovementsItemDirection In = new(Values.In);

    public static readonly LotsGetInventoryResponseMovementsItemDirection Out = new(Values.Out);

    public LotsGetInventoryResponseMovementsItemDirection(string value)
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
    public static LotsGetInventoryResponseMovementsItemDirection FromCustom(string value)
    {
        return new LotsGetInventoryResponseMovementsItemDirection(value);
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
        LotsGetInventoryResponseMovementsItemDirection value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LotsGetInventoryResponseMovementsItemDirection value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(LotsGetInventoryResponseMovementsItemDirection value) =>
        value.Value;

    public static explicit operator LotsGetInventoryResponseMovementsItemDirection(string value) =>
        new(value);

    internal class LotsGetInventoryResponseMovementsItemDirectionSerializer
        : JsonConverter<LotsGetInventoryResponseMovementsItemDirection>
    {
        public override LotsGetInventoryResponseMovementsItemDirection Read(
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
            return new LotsGetInventoryResponseMovementsItemDirection(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LotsGetInventoryResponseMovementsItemDirection value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LotsGetInventoryResponseMovementsItemDirection ReadAsPropertyName(
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
            return new LotsGetInventoryResponseMovementsItemDirection(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LotsGetInventoryResponseMovementsItemDirection value,
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
        public const string In = "in";

        public const string Out = "out";
    }
}
