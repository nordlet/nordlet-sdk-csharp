using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsDeReturnsGenerateRequestRuleKey.PostV1DeclarationsDeReturnsGenerateRequestRuleKeySerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsDeReturnsGenerateRequestRuleKey : IStringEnum
{
    public static readonly PostV1DeclarationsDeReturnsGenerateRequestRuleKey DeEBilanz = new(
        Values.DeEBilanz
    );

    public static readonly PostV1DeclarationsDeReturnsGenerateRequestRuleKey DeCitReturn = new(
        Values.DeCitReturn
    );

    public static readonly PostV1DeclarationsDeReturnsGenerateRequestRuleKey DeTradeTax = new(
        Values.DeTradeTax
    );

    public static readonly PostV1DeclarationsDeReturnsGenerateRequestRuleKey DeTradeTaxApportionment =
        new(Values.DeTradeTaxApportionment);

    public static readonly PostV1DeclarationsDeReturnsGenerateRequestRuleKey DeAnnualVatReturn =
        new(Values.DeAnnualVatReturn);

    public static readonly PostV1DeclarationsDeReturnsGenerateRequestRuleKey DePayrollWithholding =
        new(Values.DePayrollWithholding);

    public static readonly PostV1DeclarationsDeReturnsGenerateRequestRuleKey DePayrollStatements =
        new(Values.DePayrollStatements);

    public PostV1DeclarationsDeReturnsGenerateRequestRuleKey(string value)
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
    public static PostV1DeclarationsDeReturnsGenerateRequestRuleKey FromCustom(string value)
    {
        return new PostV1DeclarationsDeReturnsGenerateRequestRuleKey(value);
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
        PostV1DeclarationsDeReturnsGenerateRequestRuleKey value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsDeReturnsGenerateRequestRuleKey value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsDeReturnsGenerateRequestRuleKey value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsDeReturnsGenerateRequestRuleKey(
        string value
    ) => new(value);

    internal class PostV1DeclarationsDeReturnsGenerateRequestRuleKeySerializer
        : JsonConverter<PostV1DeclarationsDeReturnsGenerateRequestRuleKey>
    {
        public override PostV1DeclarationsDeReturnsGenerateRequestRuleKey Read(
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
            return new PostV1DeclarationsDeReturnsGenerateRequestRuleKey(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsDeReturnsGenerateRequestRuleKey value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsDeReturnsGenerateRequestRuleKey ReadAsPropertyName(
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
            return new PostV1DeclarationsDeReturnsGenerateRequestRuleKey(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsDeReturnsGenerateRequestRuleKey value,
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
        public const string DeEBilanz = "de-e-bilanz";

        public const string DeCitReturn = "de-cit-return";

        public const string DeTradeTax = "de-trade-tax";

        public const string DeTradeTaxApportionment = "de-trade-tax-apportionment";

        public const string DeAnnualVatReturn = "de-annual-vat-return";

        public const string DePayrollWithholding = "de-payroll-withholding";

        public const string DePayrollStatements = "de-payroll-statements";
    }
}
