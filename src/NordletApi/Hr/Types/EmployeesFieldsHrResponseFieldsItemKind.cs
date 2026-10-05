using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EmployeesFieldsHrResponseFieldsItemKind.EmployeesFieldsHrResponseFieldsItemKindSerializer)
)]
[Serializable]
public readonly record struct EmployeesFieldsHrResponseFieldsItemKind : IStringEnum
{
    public static readonly EmployeesFieldsHrResponseFieldsItemKind Text = new(Values.Text);

    public static readonly EmployeesFieldsHrResponseFieldsItemKind Select = new(Values.Select);

    public static readonly EmployeesFieldsHrResponseFieldsItemKind Date = new(Values.Date);

    public EmployeesFieldsHrResponseFieldsItemKind(string value)
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
    public static EmployeesFieldsHrResponseFieldsItemKind FromCustom(string value)
    {
        return new EmployeesFieldsHrResponseFieldsItemKind(value);
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

    public static bool operator ==(EmployeesFieldsHrResponseFieldsItemKind value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmployeesFieldsHrResponseFieldsItemKind value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmployeesFieldsHrResponseFieldsItemKind value) =>
        value.Value;

    public static explicit operator EmployeesFieldsHrResponseFieldsItemKind(string value) =>
        new(value);

    internal class EmployeesFieldsHrResponseFieldsItemKindSerializer
        : JsonConverter<EmployeesFieldsHrResponseFieldsItemKind>
    {
        public override EmployeesFieldsHrResponseFieldsItemKind Read(
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
            return new EmployeesFieldsHrResponseFieldsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EmployeesFieldsHrResponseFieldsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EmployeesFieldsHrResponseFieldsItemKind ReadAsPropertyName(
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
            return new EmployeesFieldsHrResponseFieldsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EmployeesFieldsHrResponseFieldsItemKind value,
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
        public const string Text = "text";

        public const string Select = "select";

        public const string Date = "date";
    }
}
