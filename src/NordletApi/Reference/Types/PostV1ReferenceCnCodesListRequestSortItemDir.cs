using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReferenceCnCodesListRequestSortItemDir.PostV1ReferenceCnCodesListRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct PostV1ReferenceCnCodesListRequestSortItemDir : IStringEnum
{
    public static readonly PostV1ReferenceCnCodesListRequestSortItemDir Asc = new(Values.Asc);

    public static readonly PostV1ReferenceCnCodesListRequestSortItemDir Desc = new(Values.Desc);

    public PostV1ReferenceCnCodesListRequestSortItemDir(string value)
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
    public static PostV1ReferenceCnCodesListRequestSortItemDir FromCustom(string value)
    {
        return new PostV1ReferenceCnCodesListRequestSortItemDir(value);
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
        PostV1ReferenceCnCodesListRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ReferenceCnCodesListRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ReferenceCnCodesListRequestSortItemDir value) =>
        value.Value;

    public static explicit operator PostV1ReferenceCnCodesListRequestSortItemDir(string value) =>
        new(value);

    internal class PostV1ReferenceCnCodesListRequestSortItemDirSerializer
        : JsonConverter<PostV1ReferenceCnCodesListRequestSortItemDir>
    {
        public override PostV1ReferenceCnCodesListRequestSortItemDir Read(
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
            return new PostV1ReferenceCnCodesListRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReferenceCnCodesListRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReferenceCnCodesListRequestSortItemDir ReadAsPropertyName(
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
            return new PostV1ReferenceCnCodesListRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReferenceCnCodesListRequestSortItemDir value,
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
