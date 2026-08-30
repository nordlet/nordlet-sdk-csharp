using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrEmployeesAnonymizeResponseStatus.PostV1HrEmployeesAnonymizeResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1HrEmployeesAnonymizeResponseStatus : IStringEnum
{
    public static readonly PostV1HrEmployeesAnonymizeResponseStatus Active = new(Values.Active);

    public static readonly PostV1HrEmployeesAnonymizeResponseStatus Terminated = new(
        Values.Terminated
    );

    public PostV1HrEmployeesAnonymizeResponseStatus(string value)
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
    public static PostV1HrEmployeesAnonymizeResponseStatus FromCustom(string value)
    {
        return new PostV1HrEmployeesAnonymizeResponseStatus(value);
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
        PostV1HrEmployeesAnonymizeResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1HrEmployeesAnonymizeResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1HrEmployeesAnonymizeResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1HrEmployeesAnonymizeResponseStatus(string value) =>
        new(value);

    internal class PostV1HrEmployeesAnonymizeResponseStatusSerializer
        : JsonConverter<PostV1HrEmployeesAnonymizeResponseStatus>
    {
        public override PostV1HrEmployeesAnonymizeResponseStatus Read(
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
            return new PostV1HrEmployeesAnonymizeResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrEmployeesAnonymizeResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrEmployeesAnonymizeResponseStatus ReadAsPropertyName(
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
            return new PostV1HrEmployeesAnonymizeResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrEmployeesAnonymizeResponseStatus value,
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
        public const string Active = "active";

        public const string Terminated = "terminated";
    }
}
