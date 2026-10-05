using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesCreateSalesRequestVatScheme.InvoicesCreateSalesRequestVatSchemeSerializer)
)]
[Serializable]
public readonly record struct InvoicesCreateSalesRequestVatScheme : IStringEnum
{
    public static readonly InvoicesCreateSalesRequestVatScheme Domestic = new(Values.Domestic);

    public static readonly InvoicesCreateSalesRequestVatScheme IntraEuB2B = new(Values.IntraEuB2B);

    public static readonly InvoicesCreateSalesRequestVatScheme ReverseCharge = new(
        Values.ReverseCharge
    );

    public static readonly InvoicesCreateSalesRequestVatScheme OssUnion = new(Values.OssUnion);

    public static readonly InvoicesCreateSalesRequestVatScheme Ioss = new(Values.Ioss);

    public static readonly InvoicesCreateSalesRequestVatScheme MarketplaceDeemed = new(
        Values.MarketplaceDeemed
    );

    public static readonly InvoicesCreateSalesRequestVatScheme Export = new(Values.Export);

    public static readonly InvoicesCreateSalesRequestVatScheme OutOfScope = new(Values.OutOfScope);

    public static readonly InvoicesCreateSalesRequestVatScheme SmeExempt = new(Values.SmeExempt);

    public InvoicesCreateSalesRequestVatScheme(string value)
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
    public static InvoicesCreateSalesRequestVatScheme FromCustom(string value)
    {
        return new InvoicesCreateSalesRequestVatScheme(value);
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

    public static bool operator ==(InvoicesCreateSalesRequestVatScheme value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesCreateSalesRequestVatScheme value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesCreateSalesRequestVatScheme value) =>
        value.Value;

    public static explicit operator InvoicesCreateSalesRequestVatScheme(string value) => new(value);

    internal class InvoicesCreateSalesRequestVatSchemeSerializer
        : JsonConverter<InvoicesCreateSalesRequestVatScheme>
    {
        public override InvoicesCreateSalesRequestVatScheme Read(
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
            return new InvoicesCreateSalesRequestVatScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesCreateSalesRequestVatScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesCreateSalesRequestVatScheme ReadAsPropertyName(
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
            return new InvoicesCreateSalesRequestVatScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesCreateSalesRequestVatScheme value,
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
