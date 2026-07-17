using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrContractsListRequestSortItemDir.PostV1HrContractsListRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct PostV1HrContractsListRequestSortItemDir : IStringEnum
{
    public static readonly PostV1HrContractsListRequestSortItemDir Asc = new(Values.Asc);

    public static readonly PostV1HrContractsListRequestSortItemDir Desc = new(Values.Desc);

    public PostV1HrContractsListRequestSortItemDir(string value)
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
    public static PostV1HrContractsListRequestSortItemDir FromCustom(string value)
    {
        return new PostV1HrContractsListRequestSortItemDir(value);
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

    public static bool operator ==(PostV1HrContractsListRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1HrContractsListRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1HrContractsListRequestSortItemDir value) =>
        value.Value;

    public static explicit operator PostV1HrContractsListRequestSortItemDir(string value) =>
        new(value);

    internal class PostV1HrContractsListRequestSortItemDirSerializer
        : JsonConverter<PostV1HrContractsListRequestSortItemDir>
    {
        public override PostV1HrContractsListRequestSortItemDir Read(
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
            return new PostV1HrContractsListRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrContractsListRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrContractsListRequestSortItemDir ReadAsPropertyName(
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
            return new PostV1HrContractsListRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrContractsListRequestSortItemDir value,
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
