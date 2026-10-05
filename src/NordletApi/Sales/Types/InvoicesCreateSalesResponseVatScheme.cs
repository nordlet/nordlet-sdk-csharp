using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesCreateSalesResponseVatScheme.InvoicesCreateSalesResponseVatSchemeSerializer)
)]
[Serializable]
public readonly record struct InvoicesCreateSalesResponseVatScheme : IStringEnum
{
    public static readonly InvoicesCreateSalesResponseVatScheme Domestic = new(Values.Domestic);

    public static readonly InvoicesCreateSalesResponseVatScheme IntraEuB2B = new(Values.IntraEuB2B);

    public static readonly InvoicesCreateSalesResponseVatScheme ReverseCharge = new(
        Values.ReverseCharge
    );

    public static readonly InvoicesCreateSalesResponseVatScheme OssUnion = new(Values.OssUnion);

    public static readonly InvoicesCreateSalesResponseVatScheme Ioss = new(Values.Ioss);

    public static readonly InvoicesCreateSalesResponseVatScheme MarketplaceDeemed = new(
        Values.MarketplaceDeemed
    );

    public static readonly InvoicesCreateSalesResponseVatScheme Export = new(Values.Export);

    public static readonly InvoicesCreateSalesResponseVatScheme OutOfScope = new(Values.OutOfScope);

    public static readonly InvoicesCreateSalesResponseVatScheme SmeExempt = new(Values.SmeExempt);

    public InvoicesCreateSalesResponseVatScheme(string value)
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
    public static InvoicesCreateSalesResponseVatScheme FromCustom(string value)
    {
        return new InvoicesCreateSalesResponseVatScheme(value);
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

    public static bool operator ==(InvoicesCreateSalesResponseVatScheme value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesCreateSalesResponseVatScheme value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesCreateSalesResponseVatScheme value) =>
        value.Value;

    public static explicit operator InvoicesCreateSalesResponseVatScheme(string value) =>
        new(value);

    internal class InvoicesCreateSalesResponseVatSchemeSerializer
        : JsonConverter<InvoicesCreateSalesResponseVatScheme>
    {
        public override InvoicesCreateSalesResponseVatScheme Read(
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
            return new InvoicesCreateSalesResponseVatScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesCreateSalesResponseVatScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesCreateSalesResponseVatScheme ReadAsPropertyName(
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
            return new InvoicesCreateSalesResponseVatScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesCreateSalesResponseVatScheme value,
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
