using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesLockSalesResponseVatScheme.InvoicesLockSalesResponseVatSchemeSerializer)
)]
[Serializable]
public readonly record struct InvoicesLockSalesResponseVatScheme : IStringEnum
{
    public static readonly InvoicesLockSalesResponseVatScheme Domestic = new(Values.Domestic);

    public static readonly InvoicesLockSalesResponseVatScheme IntraEuB2B = new(Values.IntraEuB2B);

    public static readonly InvoicesLockSalesResponseVatScheme ReverseCharge = new(
        Values.ReverseCharge
    );

    public static readonly InvoicesLockSalesResponseVatScheme OssUnion = new(Values.OssUnion);

    public static readonly InvoicesLockSalesResponseVatScheme Ioss = new(Values.Ioss);

    public static readonly InvoicesLockSalesResponseVatScheme MarketplaceDeemed = new(
        Values.MarketplaceDeemed
    );

    public static readonly InvoicesLockSalesResponseVatScheme Export = new(Values.Export);

    public static readonly InvoicesLockSalesResponseVatScheme OutOfScope = new(Values.OutOfScope);

    public static readonly InvoicesLockSalesResponseVatScheme SmeExempt = new(Values.SmeExempt);

    public InvoicesLockSalesResponseVatScheme(string value)
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
    public static InvoicesLockSalesResponseVatScheme FromCustom(string value)
    {
        return new InvoicesLockSalesResponseVatScheme(value);
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

    public static bool operator ==(InvoicesLockSalesResponseVatScheme value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesLockSalesResponseVatScheme value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesLockSalesResponseVatScheme value) => value.Value;

    public static explicit operator InvoicesLockSalesResponseVatScheme(string value) => new(value);

    internal class InvoicesLockSalesResponseVatSchemeSerializer
        : JsonConverter<InvoicesLockSalesResponseVatScheme>
    {
        public override InvoicesLockSalesResponseVatScheme Read(
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
            return new InvoicesLockSalesResponseVatScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesLockSalesResponseVatScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesLockSalesResponseVatScheme ReadAsPropertyName(
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
            return new InvoicesLockSalesResponseVatScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesLockSalesResponseVatScheme value,
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
