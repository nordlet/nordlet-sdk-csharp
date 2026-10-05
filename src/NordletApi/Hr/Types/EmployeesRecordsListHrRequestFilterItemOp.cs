using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EmployeesRecordsListHrRequestFilterItemOp.EmployeesRecordsListHrRequestFilterItemOpSerializer)
)]
[Serializable]
public readonly record struct EmployeesRecordsListHrRequestFilterItemOp : IStringEnum
{
    public static readonly EmployeesRecordsListHrRequestFilterItemOp Eq = new(Values.Eq);

    public static readonly EmployeesRecordsListHrRequestFilterItemOp Ne = new(Values.Ne);

    public static readonly EmployeesRecordsListHrRequestFilterItemOp Contains = new(
        Values.Contains
    );

    public static readonly EmployeesRecordsListHrRequestFilterItemOp Gte = new(Values.Gte);

    public static readonly EmployeesRecordsListHrRequestFilterItemOp Lte = new(Values.Lte);

    public static readonly EmployeesRecordsListHrRequestFilterItemOp In = new(Values.In);

    public EmployeesRecordsListHrRequestFilterItemOp(string value)
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
    public static EmployeesRecordsListHrRequestFilterItemOp FromCustom(string value)
    {
        return new EmployeesRecordsListHrRequestFilterItemOp(value);
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
        EmployeesRecordsListHrRequestFilterItemOp value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EmployeesRecordsListHrRequestFilterItemOp value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EmployeesRecordsListHrRequestFilterItemOp value) =>
        value.Value;

    public static explicit operator EmployeesRecordsListHrRequestFilterItemOp(string value) =>
        new(value);

    internal class EmployeesRecordsListHrRequestFilterItemOpSerializer
        : JsonConverter<EmployeesRecordsListHrRequestFilterItemOp>
    {
        public override EmployeesRecordsListHrRequestFilterItemOp Read(
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
            return new EmployeesRecordsListHrRequestFilterItemOp(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EmployeesRecordsListHrRequestFilterItemOp value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EmployeesRecordsListHrRequestFilterItemOp ReadAsPropertyName(
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
            return new EmployeesRecordsListHrRequestFilterItemOp(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EmployeesRecordsListHrRequestFilterItemOp value,
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
        public const string Eq = "eq";

        public const string Ne = "ne";

        public const string Contains = "contains";

        public const string Gte = "gte";

        public const string Lte = "lte";

        public const string In = "in";
    }
}
