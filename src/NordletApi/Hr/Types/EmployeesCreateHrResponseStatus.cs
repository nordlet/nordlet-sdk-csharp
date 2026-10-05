using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(EmployeesCreateHrResponseStatus.EmployeesCreateHrResponseStatusSerializer))]
[Serializable]
public readonly record struct EmployeesCreateHrResponseStatus : IStringEnum
{
    public static readonly EmployeesCreateHrResponseStatus Active = new(Values.Active);

    public static readonly EmployeesCreateHrResponseStatus Terminated = new(Values.Terminated);

    public EmployeesCreateHrResponseStatus(string value)
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
    public static EmployeesCreateHrResponseStatus FromCustom(string value)
    {
        return new EmployeesCreateHrResponseStatus(value);
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

    public static bool operator ==(EmployeesCreateHrResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmployeesCreateHrResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmployeesCreateHrResponseStatus value) => value.Value;

    public static explicit operator EmployeesCreateHrResponseStatus(string value) => new(value);

    internal class EmployeesCreateHrResponseStatusSerializer
        : JsonConverter<EmployeesCreateHrResponseStatus>
    {
        public override EmployeesCreateHrResponseStatus Read(
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
            return new EmployeesCreateHrResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EmployeesCreateHrResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EmployeesCreateHrResponseStatus ReadAsPropertyName(
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
            return new EmployeesCreateHrResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EmployeesCreateHrResponseStatus value,
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
