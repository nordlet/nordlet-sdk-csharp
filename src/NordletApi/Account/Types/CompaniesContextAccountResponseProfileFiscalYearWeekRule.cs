using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(CompaniesContextAccountResponseProfileFiscalYearWeekRule.CompaniesContextAccountResponseProfileFiscalYearWeekRuleSerializer)
)]
[Serializable]
public readonly record struct CompaniesContextAccountResponseProfileFiscalYearWeekRule : IStringEnum
{
    public static readonly CompaniesContextAccountResponseProfileFiscalYearWeekRule Last = new(
        Values.Last
    );

    public static readonly CompaniesContextAccountResponseProfileFiscalYearWeekRule Nearest = new(
        Values.Nearest
    );

    public CompaniesContextAccountResponseProfileFiscalYearWeekRule(string value)
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
    public static CompaniesContextAccountResponseProfileFiscalYearWeekRule FromCustom(string value)
    {
        return new CompaniesContextAccountResponseProfileFiscalYearWeekRule(value);
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
        CompaniesContextAccountResponseProfileFiscalYearWeekRule value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CompaniesContextAccountResponseProfileFiscalYearWeekRule value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CompaniesContextAccountResponseProfileFiscalYearWeekRule value
    ) => value.Value;

    public static explicit operator CompaniesContextAccountResponseProfileFiscalYearWeekRule(
        string value
    ) => new(value);

    internal class CompaniesContextAccountResponseProfileFiscalYearWeekRuleSerializer
        : JsonConverter<CompaniesContextAccountResponseProfileFiscalYearWeekRule>
    {
        public override CompaniesContextAccountResponseProfileFiscalYearWeekRule Read(
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
            return new CompaniesContextAccountResponseProfileFiscalYearWeekRule(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CompaniesContextAccountResponseProfileFiscalYearWeekRule value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CompaniesContextAccountResponseProfileFiscalYearWeekRule ReadAsPropertyName(
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
            return new CompaniesContextAccountResponseProfileFiscalYearWeekRule(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CompaniesContextAccountResponseProfileFiscalYearWeekRule value,
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
