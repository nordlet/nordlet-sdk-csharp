using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(EmployeesUpdateHrRequestStatus.EmployeesUpdateHrRequestStatusSerializer))]
[Serializable]
public readonly record struct EmployeesUpdateHrRequestStatus : IStringEnum
{
    public static readonly EmployeesUpdateHrRequestStatus Active = new(Values.Active);

    public static readonly EmployeesUpdateHrRequestStatus Terminated = new(Values.Terminated);

    public EmployeesUpdateHrRequestStatus(string value)
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
    public static EmployeesUpdateHrRequestStatus FromCustom(string value)
    {
        return new EmployeesUpdateHrRequestStatus(value);
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

    public static bool operator ==(EmployeesUpdateHrRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmployeesUpdateHrRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmployeesUpdateHrRequestStatus value) => value.Value;

    public static explicit operator EmployeesUpdateHrRequestStatus(string value) => new(value);

    internal class EmployeesUpdateHrRequestStatusSerializer
        : JsonConverter<EmployeesUpdateHrRequestStatus>
    {
        public override EmployeesUpdateHrRequestStatus Read(
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
            return new EmployeesUpdateHrRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EmployeesUpdateHrRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EmployeesUpdateHrRequestStatus ReadAsPropertyName(
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
            return new EmployeesUpdateHrRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EmployeesUpdateHrRequestStatus value,
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
