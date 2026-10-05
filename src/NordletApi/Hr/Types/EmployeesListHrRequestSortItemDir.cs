using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EmployeesListHrRequestSortItemDir.EmployeesListHrRequestSortItemDirSerializer)
)]
[Serializable]
public readonly record struct EmployeesListHrRequestSortItemDir : IStringEnum
{
    public static readonly EmployeesListHrRequestSortItemDir Asc = new(Values.Asc);

    public static readonly EmployeesListHrRequestSortItemDir Desc = new(Values.Desc);

    public EmployeesListHrRequestSortItemDir(string value)
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
    public static EmployeesListHrRequestSortItemDir FromCustom(string value)
    {
        return new EmployeesListHrRequestSortItemDir(value);
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

    public static bool operator ==(EmployeesListHrRequestSortItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmployeesListHrRequestSortItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmployeesListHrRequestSortItemDir value) => value.Value;

    public static explicit operator EmployeesListHrRequestSortItemDir(string value) => new(value);

    internal class EmployeesListHrRequestSortItemDirSerializer
        : JsonConverter<EmployeesListHrRequestSortItemDir>
    {
        public override EmployeesListHrRequestSortItemDir Read(
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
            return new EmployeesListHrRequestSortItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EmployeesListHrRequestSortItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EmployeesListHrRequestSortItemDir ReadAsPropertyName(
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
            return new EmployeesListHrRequestSortItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EmployeesListHrRequestSortItemDir value,
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
        public const string Asc = "asc";

        public const string Desc = "desc";
    }
}
