using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrEmployeesRecordsUpdateResponseType.PostV1HrEmployeesRecordsUpdateResponseTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1HrEmployeesRecordsUpdateResponseType : IStringEnum
{
    public static readonly PostV1HrEmployeesRecordsUpdateResponseType Education = new(
        Values.Education
    );

    public static readonly PostV1HrEmployeesRecordsUpdateResponseType Qualification = new(
        Values.Qualification
    );

    public static readonly PostV1HrEmployeesRecordsUpdateResponseType Certificate = new(
        Values.Certificate
    );

    public static readonly PostV1HrEmployeesRecordsUpdateResponseType Training = new(
        Values.Training
    );

    public PostV1HrEmployeesRecordsUpdateResponseType(string value)
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
    public static PostV1HrEmployeesRecordsUpdateResponseType FromCustom(string value)
    {
        return new PostV1HrEmployeesRecordsUpdateResponseType(value);
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
        PostV1HrEmployeesRecordsUpdateResponseType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1HrEmployeesRecordsUpdateResponseType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1HrEmployeesRecordsUpdateResponseType value) =>
        value.Value;

    public static explicit operator PostV1HrEmployeesRecordsUpdateResponseType(string value) =>
        new(value);

    internal class PostV1HrEmployeesRecordsUpdateResponseTypeSerializer
        : JsonConverter<PostV1HrEmployeesRecordsUpdateResponseType>
    {
        public override PostV1HrEmployeesRecordsUpdateResponseType Read(
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
            return new PostV1HrEmployeesRecordsUpdateResponseType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrEmployeesRecordsUpdateResponseType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrEmployeesRecordsUpdateResponseType ReadAsPropertyName(
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
            return new PostV1HrEmployeesRecordsUpdateResponseType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrEmployeesRecordsUpdateResponseType value,
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
