using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrEmployeesRecordsListResponseRowsItemType.PostV1HrEmployeesRecordsListResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1HrEmployeesRecordsListResponseRowsItemType : IStringEnum
{
    public static readonly PostV1HrEmployeesRecordsListResponseRowsItemType Education = new(
        Values.Education
    );

    public static readonly PostV1HrEmployeesRecordsListResponseRowsItemType Qualification = new(
        Values.Qualification
    );

    public static readonly PostV1HrEmployeesRecordsListResponseRowsItemType Certificate = new(
        Values.Certificate
    );

    public static readonly PostV1HrEmployeesRecordsListResponseRowsItemType Training = new(
        Values.Training
    );

    public PostV1HrEmployeesRecordsListResponseRowsItemType(string value)
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
    public static PostV1HrEmployeesRecordsListResponseRowsItemType FromCustom(string value)
    {
        return new PostV1HrEmployeesRecordsListResponseRowsItemType(value);
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
        PostV1HrEmployeesRecordsListResponseRowsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1HrEmployeesRecordsListResponseRowsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1HrEmployeesRecordsListResponseRowsItemType value
    ) => value.Value;

    public static explicit operator PostV1HrEmployeesRecordsListResponseRowsItemType(
        string value
    ) => new(value);

    internal class PostV1HrEmployeesRecordsListResponseRowsItemTypeSerializer
        : JsonConverter<PostV1HrEmployeesRecordsListResponseRowsItemType>
    {
        public override PostV1HrEmployeesRecordsListResponseRowsItemType Read(
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
            return new PostV1HrEmployeesRecordsListResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrEmployeesRecordsListResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrEmployeesRecordsListResponseRowsItemType ReadAsPropertyName(
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
            return new PostV1HrEmployeesRecordsListResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrEmployeesRecordsListResponseRowsItemType value,
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
        public const string Education = "education";

        public const string Qualification = "qualification";

        public const string Certificate = "certificate";

        public const string Training = "training";
    }
}
