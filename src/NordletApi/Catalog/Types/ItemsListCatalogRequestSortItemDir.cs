using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ItemsListCatalogRequestSortItemDir.ItemsListCatalogRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct ItemsListCatalogRequestSortItemDir : IStringEnum
{
    public static readonly ItemsListCatalogRequestSortItemDir Asc = new(Values.Asc);

    public static readonly ItemsListCatalogRequestSortItemDir Desc = new(Values.Desc);

    public ItemsListCatalogRequestSortItemDir(string value)
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
    public static ItemsListCatalogRequestSortItemDir FromCustom(string value)
    {
        return new ItemsListCatalogRequestSortItemDir(value);
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

    public static bool operator ==(ItemsListCatalogRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemsListCatalogRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemsListCatalogRequestSortItemDir value) => value.Value;

    public static explicit operator ItemsListCatalogRequestSortItemDir(string value) => new(value);

    internal class ItemsListCatalogRequestSortItemDirSerializer
        : JsonConverter<ItemsListCatalogRequestSortItemDir>
    {
        public override ItemsListCatalogRequestSortItemDir Read(
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
            return new ItemsListCatalogRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItemsListCatalogRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItemsListCatalogRequestSortItemDir ReadAsPropertyName(
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
            return new ItemsListCatalogRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItemsListCatalogRequestSortItemDir value,
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
