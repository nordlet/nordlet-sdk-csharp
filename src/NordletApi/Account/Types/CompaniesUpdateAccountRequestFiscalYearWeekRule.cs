using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CompaniesUpdateAccountRequestFiscalYearWeekRule.CompaniesUpdateAccountRequestFiscalYearWeekRuleSerializer)
)]
[Serializable]
public readonly record struct CompaniesUpdateAccountRequestFiscalYearWeekRule : IStringEnum
{
    public static readonly CompaniesUpdateAccountRequestFiscalYearWeekRule Last = new(Values.Last);

    public static readonly CompaniesUpdateAccountRequestFiscalYearWeekRule Nearest = new(
        Values.Nearest
    );

    public CompaniesUpdateAccountRequestFiscalYearWeekRule(string value)
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
    public static CompaniesUpdateAccountRequestFiscalYearWeekRule FromCustom(string value)
    {
        return new CompaniesUpdateAccountRequestFiscalYearWeekRule(value);
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
        CompaniesUpdateAccountRequestFiscalYearWeekRule value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CompaniesUpdateAccountRequestFiscalYearWeekRule value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CompaniesUpdateAccountRequestFiscalYearWeekRule value) =>
        value.Value;

    public static explicit operator CompaniesUpdateAccountRequestFiscalYearWeekRule(string value) =>
        new(value);

    internal class CompaniesUpdateAccountRequestFiscalYearWeekRuleSerializer
        : JsonConverter<CompaniesUpdateAccountRequestFiscalYearWeekRule>
    {
        public override CompaniesUpdateAccountRequestFiscalYearWeekRule Read(
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
            return new CompaniesUpdateAccountRequestFiscalYearWeekRule(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CompaniesUpdateAccountRequestFiscalYearWeekRule value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CompaniesUpdateAccountRequestFiscalYearWeekRule ReadAsPropertyName(
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
            return new CompaniesUpdateAccountRequestFiscalYearWeekRule(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CompaniesUpdateAccountRequestFiscalYearWeekRule value,
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
