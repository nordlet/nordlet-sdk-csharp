using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EmployeesListHrResponseRowsItemStatus.EmployeesListHrResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct EmployeesListHrResponseRowsItemStatus : IStringEnum
{
    public static readonly EmployeesListHrResponseRowsItemStatus Active = new(Values.Active);

    public static readonly EmployeesListHrResponseRowsItemStatus Terminated = new(
        Values.Terminated
    );

    public EmployeesListHrResponseRowsItemStatus(string value)
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
    public static EmployeesListHrResponseRowsItemStatus FromCustom(string value)
    {
        return new EmployeesListHrResponseRowsItemStatus(value);
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

    public static bool operator ==(EmployeesListHrResponseRowsItemStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmployeesListHrResponseRowsItemStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmployeesListHrResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator EmployeesListHrResponseRowsItemStatus(string value) =>
        new(value);

    internal class EmployeesListHrResponseRowsItemStatusSerializer
        : JsonConverter<EmployeesListHrResponseRowsItemStatus>
    {
        public override EmployeesListHrResponseRowsItemStatus Read(
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
            return new EmployeesListHrResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EmployeesListHrResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EmployeesListHrResponseRowsItemStatus ReadAsPropertyName(
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
            return new EmployeesListHrResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EmployeesListHrResponseRowsItemStatus value,
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
