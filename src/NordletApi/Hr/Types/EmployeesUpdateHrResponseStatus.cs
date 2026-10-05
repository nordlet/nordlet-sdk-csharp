using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(EmployeesUpdateHrResponseStatus.EmployeesUpdateHrResponseStatusSerializer))]
[Serializable]
public readonly record struct EmployeesUpdateHrResponseStatus : IStringEnum
{
    public static readonly EmployeesUpdateHrResponseStatus Active = new(Values.Active);

    public static readonly EmployeesUpdateHrResponseStatus Terminated = new(Values.Terminated);

    public EmployeesUpdateHrResponseStatus(string value)
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
    public static EmployeesUpdateHrResponseStatus FromCustom(string value)
    {
        return new EmployeesUpdateHrResponseStatus(value);
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

    public static bool operator ==(EmployeesUpdateHrResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmployeesUpdateHrResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmployeesUpdateHrResponseStatus value) => value.Value;

    public static explicit operator EmployeesUpdateHrResponseStatus(string value) => new(value);

    internal class EmployeesUpdateHrResponseStatusSerializer
        : JsonConverter<EmployeesUpdateHrResponseStatus>
    {
        public override EmployeesUpdateHrResponseStatus Read(
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
            return new EmployeesUpdateHrResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EmployeesUpdateHrResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EmployeesUpdateHrResponseStatus ReadAsPropertyName(
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
            return new EmployeesUpdateHrResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EmployeesUpdateHrResponseStatus value,
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
