using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(ListLeadsRequestSortItemDir.ListLeadsRequestSortItemDirSerializer))]
[Serializable]
public readonly record struct ListLeadsRequestSortItemDir : IStringEnum
{
    public static readonly ListLeadsRequestSortItemDir Asc = new(Values.Asc);

    public static readonly ListLeadsRequestSortItemDir Desc = new(Values.Desc);

    public ListLeadsRequestSortItemDir(string value)
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
    public static ListLeadsRequestSortItemDir FromCustom(string value)
    {
        return new ListLeadsRequestSortItemDir(value);
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

    public static bool operator ==(ListLeadsRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListLeadsRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListLeadsRequestSortItemDir value) => value.Value;

    public static explicit operator ListLeadsRequestSortItemDir(string value) => new(value);

    internal class ListLeadsRequestSortItemDirSerializer
        : JsonConverter<ListLeadsRequestSortItemDir>
    {
        public override ListLeadsRequestSortItemDir Read(
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
            return new ListLeadsRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListLeadsRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListLeadsRequestSortItemDir ReadAsPropertyName(
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
            return new ListLeadsRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListLeadsRequestSortItemDir value,
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
