using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsTaxPaymentsCreateRequestTax.PostV1DeclarationsTaxPaymentsCreateRequestTaxSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsTaxPaymentsCreateRequestTax : IStringEnum
{
    public static readonly PostV1DeclarationsTaxPaymentsCreateRequestTax CorporateIncomeTax = new(
        Values.CorporateIncomeTax
    );

    public static readonly PostV1DeclarationsTaxPaymentsCreateRequestTax PayrollWithholding = new(
        Values.PayrollWithholding
    );

    public static readonly PostV1DeclarationsTaxPaymentsCreateRequestTax Vat = new(Values.Vat);

    public static readonly PostV1DeclarationsTaxPaymentsCreateRequestTax SocialInsurance = new(
        Values.SocialInsurance
    );

    public static readonly PostV1DeclarationsTaxPaymentsCreateRequestTax Other = new(Values.Other);

    public PostV1DeclarationsTaxPaymentsCreateRequestTax(string value)
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
    public static PostV1DeclarationsTaxPaymentsCreateRequestTax FromCustom(string value)
    {
        return new PostV1DeclarationsTaxPaymentsCreateRequestTax(value);
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
        PostV1DeclarationsTaxPaymentsCreateRequestTax value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsTaxPaymentsCreateRequestTax value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1DeclarationsTaxPaymentsCreateRequestTax value) =>
        value.Value;

    public static explicit operator PostV1DeclarationsTaxPaymentsCreateRequestTax(string value) =>
        new(value);

    internal class PostV1DeclarationsTaxPaymentsCreateRequestTaxSerializer
        : JsonConverter<PostV1DeclarationsTaxPaymentsCreateRequestTax>
    {
        public override PostV1DeclarationsTaxPaymentsCreateRequestTax Read(
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
            return new PostV1DeclarationsTaxPaymentsCreateRequestTax(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsTaxPaymentsCreateRequestTax value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsTaxPaymentsCreateRequestTax ReadAsPropertyName(
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
            return new PostV1DeclarationsTaxPaymentsCreateRequestTax(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsTaxPaymentsCreateRequestTax value,
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
        public const string CorporateIncomeTax = "corporate_income_tax";

        public const string PayrollWithholding = "payroll_withholding";

        public const string Vat = "vat";

        public const string SocialInsurance = "social_insurance";

        public const string Other = "other";
    }
}
