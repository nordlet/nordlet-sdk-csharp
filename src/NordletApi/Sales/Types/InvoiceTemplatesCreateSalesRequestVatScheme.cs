using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoiceTemplatesCreateSalesRequestVatScheme.InvoiceTemplatesCreateSalesRequestVatSchemeSerializer)
)]
[Serializable]
public readonly record struct InvoiceTemplatesCreateSalesRequestVatScheme : IStringEnum
{
    public static readonly InvoiceTemplatesCreateSalesRequestVatScheme Domestic = new(
        Values.Domestic
    );

    public static readonly InvoiceTemplatesCreateSalesRequestVatScheme IntraEuB2B = new(
        Values.IntraEuB2B
    );

    public static readonly InvoiceTemplatesCreateSalesRequestVatScheme ReverseCharge = new(
        Values.ReverseCharge
    );

    public static readonly InvoiceTemplatesCreateSalesRequestVatScheme OssUnion = new(
        Values.OssUnion
    );

    public static readonly InvoiceTemplatesCreateSalesRequestVatScheme Ioss = new(Values.Ioss);

    public static readonly InvoiceTemplatesCreateSalesRequestVatScheme MarketplaceDeemed = new(
        Values.MarketplaceDeemed
    );

    public static readonly InvoiceTemplatesCreateSalesRequestVatScheme Export = new(Values.Export);

    public static readonly InvoiceTemplatesCreateSalesRequestVatScheme OutOfScope = new(
        Values.OutOfScope
    );

    public static readonly InvoiceTemplatesCreateSalesRequestVatScheme SmeExempt = new(
        Values.SmeExempt
    );

    public InvoiceTemplatesCreateSalesRequestVatScheme(string value)
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
    public static InvoiceTemplatesCreateSalesRequestVatScheme FromCustom(string value)
    {
        return new InvoiceTemplatesCreateSalesRequestVatScheme(value);
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
        InvoiceTemplatesCreateSalesRequestVatScheme value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoiceTemplatesCreateSalesRequestVatScheme value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoiceTemplatesCreateSalesRequestVatScheme value) =>
        value.Value;

    public static explicit operator InvoiceTemplatesCreateSalesRequestVatScheme(string value) =>
        new(value);

    internal class InvoiceTemplatesCreateSalesRequestVatSchemeSerializer
        : JsonConverter<InvoiceTemplatesCreateSalesRequestVatScheme>
    {
        public override InvoiceTemplatesCreateSalesRequestVatScheme Read(
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
            return new InvoiceTemplatesCreateSalesRequestVatScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoiceTemplatesCreateSalesRequestVatScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoiceTemplatesCreateSalesRequestVatScheme ReadAsPropertyName(
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
            return new InvoiceTemplatesCreateSalesRequestVatScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoiceTemplatesCreateSalesRequestVatScheme value,
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
        public const string Domestic = "domestic";

        public const string IntraEuB2B = "intra_eu_b2b";

        public const string ReverseCharge = "reverse_charge";

        public const string OssUnion = "oss_union";

        public const string Ioss = "ioss";

        public const string MarketplaceDeemed = "marketplace_deemed";

        public const string Export = "export";

        public const string OutOfScope = "out_of_scope";

        public const string SmeExempt = "sme_exempt";
    }
}
