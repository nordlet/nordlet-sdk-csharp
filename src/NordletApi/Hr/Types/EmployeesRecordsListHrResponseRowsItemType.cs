using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EmployeesRecordsListHrResponseRowsItemType.EmployeesRecordsListHrResponseRowsItemTypeSerializer)
)]
[Serializable]
public readonly record struct EmployeesRecordsListHrResponseRowsItemType : IStringEnum
{
    public static readonly EmployeesRecordsListHrResponseRowsItemType Education = new(
        Values.Education
    );

    public static readonly EmployeesRecordsListHrResponseRowsItemType Qualification = new(
        Values.Qualification
    );

    public static readonly EmployeesRecordsListHrResponseRowsItemType Certificate = new(
        Values.Certificate
    );

    public static readonly EmployeesRecordsListHrResponseRowsItemType Training = new(
        Values.Training
    );

    public EmployeesRecordsListHrResponseRowsItemType(string value)
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
    public static EmployeesRecordsListHrResponseRowsItemType FromCustom(string value)
    {
        return new EmployeesRecordsListHrResponseRowsItemType(value);
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
        EmployeesRecordsListHrResponseRowsItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EmployeesRecordsListHrResponseRowsItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EmployeesRecordsListHrResponseRowsItemType value) =>
        value.Value;

    public static explicit operator EmployeesRecordsListHrResponseRowsItemType(string value) =>
        new(value);

    internal class EmployeesRecordsListHrResponseRowsItemTypeSerializer
        : JsonConverter<EmployeesRecordsListHrResponseRowsItemType>
    {
        public override EmployeesRecordsListHrResponseRowsItemType Read(
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
            return new EmployeesRecordsListHrResponseRowsItemType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EmployeesRecordsListHrResponseRowsItemType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EmployeesRecordsListHrResponseRowsItemType ReadAsPropertyName(
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
            return new EmployeesRecordsListHrResponseRowsItemType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EmployeesRecordsListHrResponseRowsItemType value,
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
        public const string Education = "education";

        public const string Qualification = "qualification";

        public const string Certificate = "certificate";

        public const string Training = "training";
    }
}
