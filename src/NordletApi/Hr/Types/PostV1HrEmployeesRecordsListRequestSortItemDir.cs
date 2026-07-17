using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrEmployeesRecordsListRequestSortItemDir.PostV1HrEmployeesRecordsListRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct PostV1HrEmployeesRecordsListRequestSortItemDir : IStringEnum
{
    public static readonly PostV1HrEmployeesRecordsListRequestSortItemDir Asc = new(Values.Asc);

    public static readonly PostV1HrEmployeesRecordsListRequestSortItemDir Desc = new(Values.Desc);

    public PostV1HrEmployeesRecordsListRequestSortItemDir(string value)
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
    public static PostV1HrEmployeesRecordsListRequestSortItemDir FromCustom(string value)
    {
        return new PostV1HrEmployeesRecordsListRequestSortItemDir(value);
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
        PostV1HrEmployeesRecordsListRequestSortItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1HrEmployeesRecordsListRequestSortItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1HrEmployeesRecordsListRequestSortItemDir value) =>
        value.Value;

    public static explicit operator PostV1HrEmployeesRecordsListRequestSortItemDir(string value) =>
        new(value);

    internal class PostV1HrEmployeesRecordsListRequestSortItemDirSerializer
        : JsonConverter<PostV1HrEmployeesRecordsListRequestSortItemDir>
    {
        public override PostV1HrEmployeesRecordsListRequestSortItemDir Read(
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
            return new PostV1HrEmployeesRecordsListRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrEmployeesRecordsListRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrEmployeesRecordsListRequestSortItemDir ReadAsPropertyName(
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
            return new PostV1HrEmployeesRecordsListRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrEmployeesRecordsListRequestSortItemDir value,
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
