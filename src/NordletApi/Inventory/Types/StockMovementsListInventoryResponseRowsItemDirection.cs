using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(StockMovementsListInventoryResponseRowsItemDirection.StockMovementsListInventoryResponseRowsItemDirectionSerializer)
)]
[Serializable]
public readonly record struct StockMovementsListInventoryResponseRowsItemDirection : IStringEnum
{
    public static readonly StockMovementsListInventoryResponseRowsItemDirection In = new(Values.In);

    public static readonly StockMovementsListInventoryResponseRowsItemDirection Out = new(
        Values.Out
    );

    public StockMovementsListInventoryResponseRowsItemDirection(string value)
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
    public static StockMovementsListInventoryResponseRowsItemDirection FromCustom(string value)
    {
        return new StockMovementsListInventoryResponseRowsItemDirection(value);
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
        StockMovementsListInventoryResponseRowsItemDirection value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        StockMovementsListInventoryResponseRowsItemDirection value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        StockMovementsListInventoryResponseRowsItemDirection value
    ) => value.Value;

    public static explicit operator StockMovementsListInventoryResponseRowsItemDirection(
        string value
    ) => new(value);

    internal class StockMovementsListInventoryResponseRowsItemDirectionSerializer
        : JsonConverter<StockMovementsListInventoryResponseRowsItemDirection>
    {
        public override StockMovementsListInventoryResponseRowsItemDirection Read(
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
            return new StockMovementsListInventoryResponseRowsItemDirection(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            StockMovementsListInventoryResponseRowsItemDirection value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override StockMovementsListInventoryResponseRowsItemDirection ReadAsPropertyName(
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
            return new StockMovementsListInventoryResponseRowsItemDirection(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            StockMovementsListInventoryResponseRowsItemDirection value,
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
