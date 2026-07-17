using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrContractsCreateRequestSalaryType.PostV1HrContractsCreateRequestSalaryTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1HrContractsCreateRequestSalaryType : IStringEnum
{
    public static readonly PostV1HrContractsCreateRequestSalaryType Monthly = new(Values.Monthly);

    public static readonly PostV1HrContractsCreateRequestSalaryType Hourly = new(Values.Hourly);

    public PostV1HrContractsCreateRequestSalaryType(string value)
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
    public static PostV1HrContractsCreateRequestSalaryType FromCustom(string value)
    {
        return new PostV1HrContractsCreateRequestSalaryType(value);
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
        PostV1HrContractsCreateRequestSalaryType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1HrContractsCreateRequestSalaryType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1HrContractsCreateRequestSalaryType value) =>
        value.Value;

    public static explicit operator PostV1HrContractsCreateRequestSalaryType(string value) =>
        new(value);

    internal class PostV1HrContractsCreateRequestSalaryTypeSerializer
        : JsonConverter<PostV1HrContractsCreateRequestSalaryType>
    {
        public override PostV1HrContractsCreateRequestSalaryType Read(
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
            return new PostV1HrContractsCreateRequestSalaryType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrContractsCreateRequestSalaryType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrContractsCreateRequestSalaryType ReadAsPropertyName(
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
            return new PostV1HrContractsCreateRequestSalaryType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrContractsCreateRequestSalaryType value,
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
