using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CompaniesCreateAccountRequestFiscalYearWeekRule.CompaniesCreateAccountRequestFiscalYearWeekRuleSerializer)
)]
[Serializable]
public readonly record struct CompaniesCreateAccountRequestFiscalYearWeekRule : IStringEnum
{
    public static readonly CompaniesCreateAccountRequestFiscalYearWeekRule Last = new(Values.Last);

    public static readonly CompaniesCreateAccountRequestFiscalYearWeekRule Nearest = new(
        Values.Nearest
    );

    public CompaniesCreateAccountRequestFiscalYearWeekRule(string value)
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
    public static CompaniesCreateAccountRequestFiscalYearWeekRule FromCustom(string value)
    {
        return new CompaniesCreateAccountRequestFiscalYearWeekRule(value);
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
        CompaniesCreateAccountRequestFiscalYearWeekRule value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CompaniesCreateAccountRequestFiscalYearWeekRule value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CompaniesCreateAccountRequestFiscalYearWeekRule value) =>
        value.Value;

    public static explicit operator CompaniesCreateAccountRequestFiscalYearWeekRule(string value) =>
        new(value);

    internal class CompaniesCreateAccountRequestFiscalYearWeekRuleSerializer
        : JsonConverter<CompaniesCreateAccountRequestFiscalYearWeekRule>
    {
        public override CompaniesCreateAccountRequestFiscalYearWeekRule Read(
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
            return new CompaniesCreateAccountRequestFiscalYearWeekRule(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CompaniesCreateAccountRequestFiscalYearWeekRule value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CompaniesCreateAccountRequestFiscalYearWeekRule ReadAsPropertyName(
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
            return new CompaniesCreateAccountRequestFiscalYearWeekRule(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CompaniesCreateAccountRequestFiscalYearWeekRule value,
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
        public const string Last = "last";

        public const string Nearest = "nearest";
    }
}
