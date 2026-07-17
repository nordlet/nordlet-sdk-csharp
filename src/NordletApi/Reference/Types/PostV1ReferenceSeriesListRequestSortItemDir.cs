using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReferenceSeriesListRequestSortItemDir.PostV1ReferenceSeriesListRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct PostV1ReferenceSeriesListRequestSortItemDir : IStringEnum
{
    public static readonly PostV1ReferenceSeriesListRequestSortItemDir Asc = new(Values.Asc);

    public static readonly PostV1ReferenceSeriesListRequestSortItemDir Desc = new(Values.Desc);

    public PostV1ReferenceSeriesListRequestSortItemDir(string value)
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
    public static PostV1ReferenceSeriesListRequestSortItemDir FromCustom(string value)
    {
        return new PostV1ReferenceSeriesListRequestSortItemDir(value);
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
        PostV1ReferenceSeriesListRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ReferenceSeriesListRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ReferenceSeriesListRequestSortItemDir value) =>
        value.Value;

    public static explicit operator PostV1ReferenceSeriesListRequestSortItemDir(string value) =>
        new(value);

    internal class PostV1ReferenceSeriesListRequestSortItemDirSerializer
        : JsonConverter<PostV1ReferenceSeriesListRequestSortItemDir>
    {
        public override PostV1ReferenceSeriesListRequestSortItemDir Read(
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
            return new PostV1ReferenceSeriesListRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReferenceSeriesListRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReferenceSeriesListRequestSortItemDir ReadAsPropertyName(
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
            return new PostV1ReferenceSeriesListRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReferenceSeriesListRequestSortItemDir value,
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
