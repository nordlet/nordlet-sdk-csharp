using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProductionRoutingsListRequestSortItemDir.PostV1ProductionRoutingsListRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct PostV1ProductionRoutingsListRequestSortItemDir : IStringEnum
{
    public static readonly PostV1ProductionRoutingsListRequestSortItemDir Asc = new(Values.Asc);

    public static readonly PostV1ProductionRoutingsListRequestSortItemDir Desc = new(Values.Desc);

    public PostV1ProductionRoutingsListRequestSortItemDir(string value)
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
    public static PostV1ProductionRoutingsListRequestSortItemDir FromCustom(string value)
    {
        return new PostV1ProductionRoutingsListRequestSortItemDir(value);
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
        PostV1ProductionRoutingsListRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ProductionRoutingsListRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ProductionRoutingsListRequestSortItemDir value) =>
        value.Value;

    public static explicit operator PostV1ProductionRoutingsListRequestSortItemDir(string value) =>
        new(value);

    internal class PostV1ProductionRoutingsListRequestSortItemDirSerializer
        : JsonConverter<PostV1ProductionRoutingsListRequestSortItemDir>
    {
        public override PostV1ProductionRoutingsListRequestSortItemDir Read(
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
            return new PostV1ProductionRoutingsListRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProductionRoutingsListRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProductionRoutingsListRequestSortItemDir ReadAsPropertyName(
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
            return new PostV1ProductionRoutingsListRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProductionRoutingsListRequestSortItemDir value,
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
