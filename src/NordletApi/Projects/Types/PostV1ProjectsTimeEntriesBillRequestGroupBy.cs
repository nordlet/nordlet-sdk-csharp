using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProjectsTimeEntriesBillRequestGroupBy.PostV1ProjectsTimeEntriesBillRequestGroupBySerializer)
)]
[Serializable]
public readonly record struct PostV1ProjectsTimeEntriesBillRequestGroupBy : IStringEnum
{
    public static readonly PostV1ProjectsTimeEntriesBillRequestGroupBy Rate = new(Values.Rate);

    public static readonly PostV1ProjectsTimeEntriesBillRequestGroupBy Entry = new(Values.Entry);

    public PostV1ProjectsTimeEntriesBillRequestGroupBy(string value)
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
    public static PostV1ProjectsTimeEntriesBillRequestGroupBy FromCustom(string value)
    {
        return new PostV1ProjectsTimeEntriesBillRequestGroupBy(value);
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
        PostV1ProjectsTimeEntriesBillRequestGroupBy value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ProjectsTimeEntriesBillRequestGroupBy value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ProjectsTimeEntriesBillRequestGroupBy value) =>
        value.Value;

    public static explicit operator PostV1ProjectsTimeEntriesBillRequestGroupBy(string value) =>
        new(value);

    internal class PostV1ProjectsTimeEntriesBillRequestGroupBySerializer
        : JsonConverter<PostV1ProjectsTimeEntriesBillRequestGroupBy>
    {
        public override PostV1ProjectsTimeEntriesBillRequestGroupBy Read(
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
            return new PostV1ProjectsTimeEntriesBillRequestGroupBy(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProjectsTimeEntriesBillRequestGroupBy value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProjectsTimeEntriesBillRequestGroupBy ReadAsPropertyName(
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
            return new PostV1ProjectsTimeEntriesBillRequestGroupBy(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProjectsTimeEntriesBillRequestGroupBy value,
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
        public const string Rate = "rate";

        public const string Entry = "entry";
    }
}
