using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(DebtAgingReportsRequestSide.DebtAgingReportsRequestSideSerializer))]
[Serializable]
public readonly record struct DebtAgingReportsRequestSide : IStringEnum
{
    public static readonly DebtAgingReportsRequestSide Receivables = new(Values.Receivables);

    public static readonly DebtAgingReportsRequestSide Payables = new(Values.Payables);

    public DebtAgingReportsRequestSide(string value)
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
    public static DebtAgingReportsRequestSide FromCustom(string value)
    {
        return new DebtAgingReportsRequestSide(value);
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

    public static bool operator ==(DebtAgingReportsRequestSide value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DebtAgingReportsRequestSide value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DebtAgingReportsRequestSide value) => value.Value;

    public static explicit operator DebtAgingReportsRequestSide(string value) => new(value);

    internal class DebtAgingReportsRequestSideSerializer
        : JsonConverter<DebtAgingReportsRequestSide>
    {
        public override DebtAgingReportsRequestSide Read(
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
            return new DebtAgingReportsRequestSide(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DebtAgingReportsRequestSide value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DebtAgingReportsRequestSide ReadAsPropertyName(
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
            return new DebtAgingReportsRequestSide(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DebtAgingReportsRequestSide value,
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
        public const string Receivables = "receivables";

        public const string Payables = "payables";
    }
}
