using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FinancialStatementsReportsResponseCategory.FinancialStatementsReportsResponseCategorySerializer)
)]
[Serializable]
public readonly record struct FinancialStatementsReportsResponseCategory : IStringEnum
{
    public static readonly FinancialStatementsReportsResponseCategory Micro = new(Values.Micro);

    public static readonly FinancialStatementsReportsResponseCategory Small = new(Values.Small);

    public static readonly FinancialStatementsReportsResponseCategory Medium = new(Values.Medium);

    public static readonly FinancialStatementsReportsResponseCategory Large = new(Values.Large);

    public FinancialStatementsReportsResponseCategory(string value)
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
    public static FinancialStatementsReportsResponseCategory FromCustom(string value)
    {
        return new FinancialStatementsReportsResponseCategory(value);
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
        FinancialStatementsReportsResponseCategory value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FinancialStatementsReportsResponseCategory value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FinancialStatementsReportsResponseCategory value) =>
        value.Value;

    public static explicit operator FinancialStatementsReportsResponseCategory(string value) =>
        new(value);

    internal class FinancialStatementsReportsResponseCategorySerializer
        : JsonConverter<FinancialStatementsReportsResponseCategory>
    {
        public override FinancialStatementsReportsResponseCategory Read(
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
            return new FinancialStatementsReportsResponseCategory(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FinancialStatementsReportsResponseCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FinancialStatementsReportsResponseCategory ReadAsPropertyName(
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
            return new FinancialStatementsReportsResponseCategory(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FinancialStatementsReportsResponseCategory value,
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
        public const string Micro = "micro";

        public const string Small = "small";

        public const string Medium = "medium";

        public const string Large = "large";
    }
}
