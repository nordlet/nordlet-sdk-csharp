using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EmployeesAnonymizeHrResponseStatus.EmployeesAnonymizeHrResponseStatusSerializer)
)]
[Serializable]
public readonly record struct EmployeesAnonymizeHrResponseStatus : IStringEnum
{
    public static readonly EmployeesAnonymizeHrResponseStatus Active = new(Values.Active);

    public static readonly EmployeesAnonymizeHrResponseStatus Terminated = new(Values.Terminated);

    public EmployeesAnonymizeHrResponseStatus(string value)
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
    public static EmployeesAnonymizeHrResponseStatus FromCustom(string value)
    {
        return new EmployeesAnonymizeHrResponseStatus(value);
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

    public static bool operator ==(EmployeesAnonymizeHrResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmployeesAnonymizeHrResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmployeesAnonymizeHrResponseStatus value) => value.Value;

    public static explicit operator EmployeesAnonymizeHrResponseStatus(string value) => new(value);

    internal class EmployeesAnonymizeHrResponseStatusSerializer
        : JsonConverter<EmployeesAnonymizeHrResponseStatus>
    {
        public override EmployeesAnonymizeHrResponseStatus Read(
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
            return new EmployeesAnonymizeHrResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EmployeesAnonymizeHrResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EmployeesAnonymizeHrResponseStatus ReadAsPropertyName(
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
            return new EmployeesAnonymizeHrResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EmployeesAnonymizeHrResponseStatus value,
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
