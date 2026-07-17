using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReportsFinancialStatementsRequestCategory.PostV1ReportsFinancialStatementsRequestCategorySerializer)
)]
[Serializable]
public readonly record struct PostV1ReportsFinancialStatementsRequestCategory : IStringEnum
{
    public static readonly PostV1ReportsFinancialStatementsRequestCategory Micro = new(
        Values.Micro
    );

    public static readonly PostV1ReportsFinancialStatementsRequestCategory Small = new(
        Values.Small
    );

    public static readonly PostV1ReportsFinancialStatementsRequestCategory Medium = new(
        Values.Medium
    );

    public static readonly PostV1ReportsFinancialStatementsRequestCategory Large = new(
        Values.Large
    );

    public PostV1ReportsFinancialStatementsRequestCategory(string value)
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
    public static PostV1ReportsFinancialStatementsRequestCategory FromCustom(string value)
    {
        return new PostV1ReportsFinancialStatementsRequestCategory(value);
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
        PostV1ReportsFinancialStatementsRequestCategory value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ReportsFinancialStatementsRequestCategory value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ReportsFinancialStatementsRequestCategory value) =>
        value.Value;

    public static explicit operator PostV1ReportsFinancialStatementsRequestCategory(string value) =>
        new(value);

    internal class PostV1ReportsFinancialStatementsRequestCategorySerializer
        : JsonConverter<PostV1ReportsFinancialStatementsRequestCategory>
    {
        public override PostV1ReportsFinancialStatementsRequestCategory Read(
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
            return new PostV1ReportsFinancialStatementsRequestCategory(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReportsFinancialStatementsRequestCategory value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReportsFinancialStatementsRequestCategory ReadAsPropertyName(
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
            return new PostV1ReportsFinancialStatementsRequestCategory(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReportsFinancialStatementsRequestCategory value,
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
