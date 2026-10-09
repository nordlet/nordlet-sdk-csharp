using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(RunsReversePayrollResponseStatus.RunsReversePayrollResponseStatusSerializer))]
[Serializable]
public readonly record struct RunsReversePayrollResponseStatus : IStringEnum
{
    public static readonly RunsReversePayrollResponseStatus Draft = new(Values.Draft);

    public static readonly RunsReversePayrollResponseStatus Approved = new(Values.Approved);

    public static readonly RunsReversePayrollResponseStatus Reversed = new(Values.Reversed);

    public RunsReversePayrollResponseStatus(string value)
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
    public static RunsReversePayrollResponseStatus FromCustom(string value)
    {
        return new RunsReversePayrollResponseStatus(value);
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

    public static bool operator ==(RunsReversePayrollResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RunsReversePayrollResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RunsReversePayrollResponseStatus value) => value.Value;

    public static explicit operator RunsReversePayrollResponseStatus(string value) => new(value);

    internal class RunsReversePayrollResponseStatusSerializer
        : JsonConverter<RunsReversePayrollResponseStatus>
    {
        public override RunsReversePayrollResponseStatus Read(
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
            return new RunsReversePayrollResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RunsReversePayrollResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RunsReversePayrollResponseStatus ReadAsPropertyName(
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
            return new RunsReversePayrollResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RunsReversePayrollResponseStatus value,
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
