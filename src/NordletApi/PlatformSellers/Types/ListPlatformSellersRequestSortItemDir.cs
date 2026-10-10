using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ListPlatformSellersRequestSortItemDir.ListPlatformSellersRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct ListPlatformSellersRequestSortItemDir : IStringEnum
{
    public static readonly ListPlatformSellersRequestSortItemDir Asc = new(Values.Asc);

    public static readonly ListPlatformSellersRequestSortItemDir Desc = new(Values.Desc);

    public ListPlatformSellersRequestSortItemDir(string value)
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
    public static ListPlatformSellersRequestSortItemDir FromCustom(string value)
    {
        return new ListPlatformSellersRequestSortItemDir(value);
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

    public static bool operator ==(ListPlatformSellersRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListPlatformSellersRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListPlatformSellersRequestSortItemDir value) =>
        value.Value;

    public static explicit operator ListPlatformSellersRequestSortItemDir(string value) =>
        new(value);

    internal class ListPlatformSellersRequestSortItemDirSerializer
        : JsonConverter<ListPlatformSellersRequestSortItemDir>
    {
        public override ListPlatformSellersRequestSortItemDir Read(
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
            return new ListPlatformSellersRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ListPlatformSellersRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ListPlatformSellersRequestSortItemDir ReadAsPropertyName(
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
            return new ListPlatformSellersRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ListPlatformSellersRequestSortItemDir value,
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
