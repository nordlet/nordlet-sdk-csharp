using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PartnersListRequestSortItemDir.PostV1PartnersListRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct PostV1PartnersListRequestSortItemDir : IStringEnum
{
    public static readonly PostV1PartnersListRequestSortItemDir Asc = new(Values.Asc);

    public static readonly PostV1PartnersListRequestSortItemDir Desc = new(Values.Desc);

    public PostV1PartnersListRequestSortItemDir(string value)
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
    public static PostV1PartnersListRequestSortItemDir FromCustom(string value)
    {
        return new PostV1PartnersListRequestSortItemDir(value);
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

    public static bool operator ==(PostV1PartnersListRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1PartnersListRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PartnersListRequestSortItemDir value) =>
        value.Value;

    public static explicit operator PostV1PartnersListRequestSortItemDir(string value) =>
        new(value);

    internal class PostV1PartnersListRequestSortItemDirSerializer
        : JsonConverter<PostV1PartnersListRequestSortItemDir>
    {
        public override PostV1PartnersListRequestSortItemDir Read(
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
            return new PostV1PartnersListRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PartnersListRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PartnersListRequestSortItemDir ReadAsPropertyName(
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
            return new PostV1PartnersListRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PartnersListRequestSortItemDir value,
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
