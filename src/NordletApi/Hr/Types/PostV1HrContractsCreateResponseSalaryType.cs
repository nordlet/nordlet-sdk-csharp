using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1HrContractsCreateResponseSalaryType.PostV1HrContractsCreateResponseSalaryTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1HrContractsCreateResponseSalaryType : IStringEnum
{
    public static readonly PostV1HrContractsCreateResponseSalaryType Monthly = new(Values.Monthly);

    public static readonly PostV1HrContractsCreateResponseSalaryType Hourly = new(Values.Hourly);

    public static readonly PostV1HrContractsCreateResponseSalaryType Weekly = new(Values.Weekly);

    public static readonly PostV1HrContractsCreateResponseSalaryType Daily = new(Values.Daily);

    public static readonly PostV1HrContractsCreateResponseSalaryType Yearly = new(Values.Yearly);

    public PostV1HrContractsCreateResponseSalaryType(string value)
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
    public static PostV1HrContractsCreateResponseSalaryType FromCustom(string value)
    {
        return new PostV1HrContractsCreateResponseSalaryType(value);
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
        PostV1HrContractsCreateResponseSalaryType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1HrContractsCreateResponseSalaryType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1HrContractsCreateResponseSalaryType value) =>
        value.Value;

    public static explicit operator PostV1HrContractsCreateResponseSalaryType(string value) =>
        new(value);

    internal class PostV1HrContractsCreateResponseSalaryTypeSerializer
        : JsonConverter<PostV1HrContractsCreateResponseSalaryType>
    {
        public override PostV1HrContractsCreateResponseSalaryType Read(
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
            return new PostV1HrContractsCreateResponseSalaryType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1HrContractsCreateResponseSalaryType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1HrContractsCreateResponseSalaryType ReadAsPropertyName(
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
            return new PostV1HrContractsCreateResponseSalaryType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1HrContractsCreateResponseSalaryType value,
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

        public const string Weekly = "weekly";

        public const string Daily = "daily";

        public const string Yearly = "yearly";
    }
}
