using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(RefundsListPosRequestSortItemDir.RefundsListPosRequestSortItemDirSerializer))]
[Serializable]
public readonly record struct RefundsListPosRequestSortItemDir : IStringEnum
{
    public static readonly RefundsListPosRequestSortItemDir Asc = new(Values.Asc);

    public static readonly RefundsListPosRequestSortItemDir Desc = new(Values.Desc);

    public RefundsListPosRequestSortItemDir(string value)
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
    public static RefundsListPosRequestSortItemDir FromCustom(string value)
    {
        return new RefundsListPosRequestSortItemDir(value);
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

    public static bool operator ==(RefundsListPosRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RefundsListPosRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RefundsListPosRequestSortItemDir value) => value.Value;

    public static explicit operator RefundsListPosRequestSortItemDir(string value) => new(value);

    internal class RefundsListPosRequestSortItemDirSerializer
        : JsonConverter<RefundsListPosRequestSortItemDir>
    {
        public override RefundsListPosRequestSortItemDir Read(
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
            return new RefundsListPosRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RefundsListPosRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RefundsListPosRequestSortItemDir ReadAsPropertyName(
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
            return new RefundsListPosRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RefundsListPosRequestSortItemDir value,
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
