using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1InventoryStockMovementsListRequestSortItemDir.PostV1InventoryStockMovementsListRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct PostV1InventoryStockMovementsListRequestSortItemDir : IStringEnum
{
    public static readonly PostV1InventoryStockMovementsListRequestSortItemDir Asc = new(
        Values.Asc
    );

    public static readonly PostV1InventoryStockMovementsListRequestSortItemDir Desc = new(
        Values.Desc
    );

    public PostV1InventoryStockMovementsListRequestSortItemDir(string value)
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
    public static PostV1InventoryStockMovementsListRequestSortItemDir FromCustom(string value)
    {
        return new PostV1InventoryStockMovementsListRequestSortItemDir(value);
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
        PostV1InventoryStockMovementsListRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1InventoryStockMovementsListRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1InventoryStockMovementsListRequestSortItemDir value
    ) => value.Value;

    public static explicit operator PostV1InventoryStockMovementsListRequestSortItemDir(
        string value
    ) => new(value);

    internal class PostV1InventoryStockMovementsListRequestSortItemDirSerializer
        : JsonConverter<PostV1InventoryStockMovementsListRequestSortItemDir>
    {
        public override PostV1InventoryStockMovementsListRequestSortItemDir Read(
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
            return new PostV1InventoryStockMovementsListRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1InventoryStockMovementsListRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1InventoryStockMovementsListRequestSortItemDir ReadAsPropertyName(
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
            return new PostV1InventoryStockMovementsListRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1InventoryStockMovementsListRequestSortItemDir value,
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
        public const string Asc = "asc";

        public const string Desc = "desc";
    }
}
