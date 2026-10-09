using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(RunsCreatePayrollResponseStatus.RunsCreatePayrollResponseStatusSerializer))]
[Serializable]
public readonly record struct RunsCreatePayrollResponseStatus : IStringEnum
{
    public static readonly RunsCreatePayrollResponseStatus Draft = new(Values.Draft);

    public static readonly RunsCreatePayrollResponseStatus Approved = new(Values.Approved);

    public static readonly RunsCreatePayrollResponseStatus Reversed = new(Values.Reversed);

    public RunsCreatePayrollResponseStatus(string value)
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
    public static RunsCreatePayrollResponseStatus FromCustom(string value)
    {
        return new RunsCreatePayrollResponseStatus(value);
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

    public static bool operator ==(RunsCreatePayrollResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RunsCreatePayrollResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RunsCreatePayrollResponseStatus value) => value.Value;

    public static explicit operator RunsCreatePayrollResponseStatus(string value) => new(value);

    internal class RunsCreatePayrollResponseStatusSerializer
        : JsonConverter<RunsCreatePayrollResponseStatus>
    {
        public override RunsCreatePayrollResponseStatus Read(
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
            return new RunsCreatePayrollResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RunsCreatePayrollResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RunsCreatePayrollResponseStatus ReadAsPropertyName(
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
            return new RunsCreatePayrollResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RunsCreatePayrollResponseStatus value,
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
        public const string Draft = "draft";

        public const string Approved = "approved";

        public const string Reversed = "reversed";
    }
}
