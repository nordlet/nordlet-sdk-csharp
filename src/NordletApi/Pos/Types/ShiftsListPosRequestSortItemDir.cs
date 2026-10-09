using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ShiftsListPosRequestSortItemDir.ShiftsListPosRequestSortItemDirSerializer))]
[Serializable]
public readonly record struct ShiftsListPosRequestSortItemDir : IStringEnum
{
    public static readonly ShiftsListPosRequestSortItemDir Asc = new(Values.Asc);

    public static readonly ShiftsListPosRequestSortItemDir Desc = new(Values.Desc);

    public ShiftsListPosRequestSortItemDir(string value)
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
    public static ShiftsListPosRequestSortItemDir FromCustom(string value)
    {
        return new ShiftsListPosRequestSortItemDir(value);
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

    public static bool operator ==(ShiftsListPosRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ShiftsListPosRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ShiftsListPosRequestSortItemDir value) => value.Value;

    public static explicit operator ShiftsListPosRequestSortItemDir(string value) => new(value);

    internal class ShiftsListPosRequestSortItemDirSerializer
        : JsonConverter<ShiftsListPosRequestSortItemDir>
    {
        public override ShiftsListPosRequestSortItemDir Read(
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
            return new ShiftsListPosRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ShiftsListPosRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ShiftsListPosRequestSortItemDir ReadAsPropertyName(
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
            return new ShiftsListPosRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ShiftsListPosRequestSortItemDir value,
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
