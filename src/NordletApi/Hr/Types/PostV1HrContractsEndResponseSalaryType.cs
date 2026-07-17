using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrContractsEndResponseSalaryType.PostV1HrContractsEndResponseSalaryTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1HrContractsEndResponseSalaryType : IStringEnum
{
    public static readonly PostV1HrContractsEndResponseSalaryType Monthly = new(Values.Monthly);

    public static readonly PostV1HrContractsEndResponseSalaryType Hourly = new(Values.Hourly);

    public PostV1HrContractsEndResponseSalaryType(string value)
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
    public static PostV1HrContractsEndResponseSalaryType FromCustom(string value)
    {
        return new PostV1HrContractsEndResponseSalaryType(value);
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

    public static bool operator ==(PostV1HrContractsEndResponseSalaryType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1HrContractsEndResponseSalaryType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1HrContractsEndResponseSalaryType value) =>
        value.Value;

    public static explicit operator PostV1HrContractsEndResponseSalaryType(string value) =>
        new(value);

    internal class PostV1HrContractsEndResponseSalaryTypeSerializer
        : JsonConverter<PostV1HrContractsEndResponseSalaryType>
    {
        public override PostV1HrContractsEndResponseSalaryType Read(
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
            return new PostV1HrContractsEndResponseSalaryType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrContractsEndResponseSalaryType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrContractsEndResponseSalaryType ReadAsPropertyName(
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
            return new PostV1HrContractsEndResponseSalaryType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrContractsEndResponseSalaryType value,
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
        public const string Monthly = "monthly";

        public const string Hourly = "hourly";
    }
}
