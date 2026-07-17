using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1BankSettlementsListRequestSortItemDir.PostV1BankSettlementsListRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct PostV1BankSettlementsListRequestSortItemDir : IStringEnum
{
    public static readonly PostV1BankSettlementsListRequestSortItemDir Asc = new(Values.Asc);

    public static readonly PostV1BankSettlementsListRequestSortItemDir Desc = new(Values.Desc);

    public PostV1BankSettlementsListRequestSortItemDir(string value)
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
    public static PostV1BankSettlementsListRequestSortItemDir FromCustom(string value)
    {
        return new PostV1BankSettlementsListRequestSortItemDir(value);
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
        PostV1BankSettlementsListRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1BankSettlementsListRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1BankSettlementsListRequestSortItemDir value) =>
        value.Value;

    public static explicit operator PostV1BankSettlementsListRequestSortItemDir(string value) =>
        new(value);

    internal class PostV1BankSettlementsListRequestSortItemDirSerializer
        : JsonConverter<PostV1BankSettlementsListRequestSortItemDir>
    {
        public override PostV1BankSettlementsListRequestSortItemDir Read(
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
            return new PostV1BankSettlementsListRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1BankSettlementsListRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1BankSettlementsListRequestSortItemDir ReadAsPropertyName(
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
            return new PostV1BankSettlementsListRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1BankSettlementsListRequestSortItemDir value,
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
