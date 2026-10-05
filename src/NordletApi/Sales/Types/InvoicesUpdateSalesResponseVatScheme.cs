using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesUpdateSalesResponseVatScheme.InvoicesUpdateSalesResponseVatSchemeSerializer)
)]
[Serializable]
public readonly record struct InvoicesUpdateSalesResponseVatScheme : IStringEnum
{
    public static readonly InvoicesUpdateSalesResponseVatScheme Domestic = new(Values.Domestic);

    public static readonly InvoicesUpdateSalesResponseVatScheme IntraEuB2B = new(Values.IntraEuB2B);

    public static readonly InvoicesUpdateSalesResponseVatScheme ReverseCharge = new(
        Values.ReverseCharge
    );

    public static readonly InvoicesUpdateSalesResponseVatScheme OssUnion = new(Values.OssUnion);

    public static readonly InvoicesUpdateSalesResponseVatScheme Ioss = new(Values.Ioss);

    public static readonly InvoicesUpdateSalesResponseVatScheme MarketplaceDeemed = new(
        Values.MarketplaceDeemed
    );

    public static readonly InvoicesUpdateSalesResponseVatScheme Export = new(Values.Export);

    public static readonly InvoicesUpdateSalesResponseVatScheme OutOfScope = new(Values.OutOfScope);

    public static readonly InvoicesUpdateSalesResponseVatScheme SmeExempt = new(Values.SmeExempt);

    public InvoicesUpdateSalesResponseVatScheme(string value)
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
    public static InvoicesUpdateSalesResponseVatScheme FromCustom(string value)
    {
        return new InvoicesUpdateSalesResponseVatScheme(value);
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

    public static bool operator ==(InvoicesUpdateSalesResponseVatScheme value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesUpdateSalesResponseVatScheme value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesUpdateSalesResponseVatScheme value) =>
        value.Value;

    public static explicit operator InvoicesUpdateSalesResponseVatScheme(string value) =>
        new(value);

    internal class InvoicesUpdateSalesResponseVatSchemeSerializer
        : JsonConverter<InvoicesUpdateSalesResponseVatScheme>
    {
        public override InvoicesUpdateSalesResponseVatScheme Read(
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
            return new InvoicesUpdateSalesResponseVatScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesUpdateSalesResponseVatScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesUpdateSalesResponseVatScheme ReadAsPropertyName(
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
            return new InvoicesUpdateSalesResponseVatScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesUpdateSalesResponseVatScheme value,
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
