using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(LotsListInventoryRequestSortItemDir.LotsListInventoryRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct LotsListInventoryRequestSortItemDir : IStringEnum
{
    public static readonly LotsListInventoryRequestSortItemDir Asc = new(Values.Asc);

    public static readonly LotsListInventoryRequestSortItemDir Desc = new(Values.Desc);

    public LotsListInventoryRequestSortItemDir(string value)
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
    public static LotsListInventoryRequestSortItemDir FromCustom(string value)
    {
        return new LotsListInventoryRequestSortItemDir(value);
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

    public static bool operator ==(LotsListInventoryRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LotsListInventoryRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LotsListInventoryRequestSortItemDir value) =>
        value.Value;

    public static explicit operator LotsListInventoryRequestSortItemDir(string value) => new(value);

    internal class LotsListInventoryRequestSortItemDirSerializer
        : JsonConverter<LotsListInventoryRequestSortItemDir>
    {
        public override LotsListInventoryRequestSortItemDir Read(
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
            return new LotsListInventoryRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            LotsListInventoryRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override LotsListInventoryRequestSortItemDir ReadAsPropertyName(
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
            return new LotsListInventoryRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            LotsListInventoryRequestSortItemDir value,
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
