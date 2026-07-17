using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1InventoryStockMovementsListResponseRowsItemDirection.PostV1InventoryStockMovementsListResponseRowsItemDirectionSerializer)
)]
[Serializable]
public readonly record struct PostV1InventoryStockMovementsListResponseRowsItemDirection
    : IStringEnum
{
    public static readonly PostV1InventoryStockMovementsListResponseRowsItemDirection In = new(
        Values.In
    );

    public static readonly PostV1InventoryStockMovementsListResponseRowsItemDirection Out = new(
        Values.Out
    );

    public PostV1InventoryStockMovementsListResponseRowsItemDirection(string value)
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
    public static PostV1InventoryStockMovementsListResponseRowsItemDirection FromCustom(
        string value
    )
    {
        return new PostV1InventoryStockMovementsListResponseRowsItemDirection(value);
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
        PostV1InventoryStockMovementsListResponseRowsItemDirection value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1InventoryStockMovementsListResponseRowsItemDirection value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1InventoryStockMovementsListResponseRowsItemDirection value
    ) => value.Value;

    public static explicit operator PostV1InventoryStockMovementsListResponseRowsItemDirection(
        string value
    ) => new(value);

    internal class PostV1InventoryStockMovementsListResponseRowsItemDirectionSerializer
        : JsonConverter<PostV1InventoryStockMovementsListResponseRowsItemDirection>
    {
        public override PostV1InventoryStockMovementsListResponseRowsItemDirection Read(
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
            return new PostV1InventoryStockMovementsListResponseRowsItemDirection(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1InventoryStockMovementsListResponseRowsItemDirection value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1InventoryStockMovementsListResponseRowsItemDirection ReadAsPropertyName(
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
            return new PostV1InventoryStockMovementsListResponseRowsItemDirection(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1InventoryStockMovementsListResponseRowsItemDirection value,
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
