using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ReceiptsListPosRequestSortItemDir.ReceiptsListPosRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct ReceiptsListPosRequestSortItemDir : IStringEnum
{
    public static readonly ReceiptsListPosRequestSortItemDir Asc = new(Values.Asc);

    public static readonly ReceiptsListPosRequestSortItemDir Desc = new(Values.Desc);

    public ReceiptsListPosRequestSortItemDir(string value)
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
    public static ReceiptsListPosRequestSortItemDir FromCustom(string value)
    {
        return new ReceiptsListPosRequestSortItemDir(value);
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

    public static bool operator ==(ReceiptsListPosRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReceiptsListPosRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReceiptsListPosRequestSortItemDir value) => value.Value;

    public static explicit operator ReceiptsListPosRequestSortItemDir(string value) => new(value);

    internal class ReceiptsListPosRequestSortItemDirSerializer
        : JsonConverter<ReceiptsListPosRequestSortItemDir>
    {
        public override ReceiptsListPosRequestSortItemDir Read(
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
            return new ReceiptsListPosRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReceiptsListPosRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReceiptsListPosRequestSortItemDir ReadAsPropertyName(
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
            return new ReceiptsListPosRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReceiptsListPosRequestSortItemDir value,
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
