using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(WarehousesListInventoryRequestSortItemDir.WarehousesListInventoryRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct WarehousesListInventoryRequestSortItemDir : IStringEnum
{
    public static readonly WarehousesListInventoryRequestSortItemDir Asc = new(Values.Asc);

    public static readonly WarehousesListInventoryRequestSortItemDir Desc = new(Values.Desc);

    public WarehousesListInventoryRequestSortItemDir(string value)
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
    public static WarehousesListInventoryRequestSortItemDir FromCustom(string value)
    {
        return new WarehousesListInventoryRequestSortItemDir(value);
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
        WarehousesListInventoryRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WarehousesListInventoryRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(WarehousesListInventoryRequestSortItemDir value) =>
        value.Value;

    public static explicit operator WarehousesListInventoryRequestSortItemDir(string value) =>
        new(value);

    internal class WarehousesListInventoryRequestSortItemDirSerializer
        : JsonConverter<WarehousesListInventoryRequestSortItemDir>
    {
        public override WarehousesListInventoryRequestSortItemDir Read(
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
            return new WarehousesListInventoryRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WarehousesListInventoryRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WarehousesListInventoryRequestSortItemDir ReadAsPropertyName(
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
            return new WarehousesListInventoryRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WarehousesListInventoryRequestSortItemDir value,
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
