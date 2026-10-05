using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesListSalesResponseRowsItemVatScheme.InvoicesListSalesResponseRowsItemVatSchemeSerializer)
)]
[Serializable]
public readonly record struct InvoicesListSalesResponseRowsItemVatScheme : IStringEnum
{
    public static readonly InvoicesListSalesResponseRowsItemVatScheme Domestic = new(
        Values.Domestic
    );

    public static readonly InvoicesListSalesResponseRowsItemVatScheme IntraEuB2B = new(
        Values.IntraEuB2B
    );

    public static readonly InvoicesListSalesResponseRowsItemVatScheme ReverseCharge = new(
        Values.ReverseCharge
    );

    public static readonly InvoicesListSalesResponseRowsItemVatScheme OssUnion = new(
        Values.OssUnion
    );

    public static readonly InvoicesListSalesResponseRowsItemVatScheme Ioss = new(Values.Ioss);

    public static readonly InvoicesListSalesResponseRowsItemVatScheme MarketplaceDeemed = new(
        Values.MarketplaceDeemed
    );

    public static readonly InvoicesListSalesResponseRowsItemVatScheme Export = new(Values.Export);

    public static readonly InvoicesListSalesResponseRowsItemVatScheme OutOfScope = new(
        Values.OutOfScope
    );

    public static readonly InvoicesListSalesResponseRowsItemVatScheme SmeExempt = new(
        Values.SmeExempt
    );

    public InvoicesListSalesResponseRowsItemVatScheme(string value)
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
    public static InvoicesListSalesResponseRowsItemVatScheme FromCustom(string value)
    {
        return new InvoicesListSalesResponseRowsItemVatScheme(value);
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
        InvoicesListSalesResponseRowsItemVatScheme value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoicesListSalesResponseRowsItemVatScheme value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesListSalesResponseRowsItemVatScheme value) =>
        value.Value;

    public static explicit operator InvoicesListSalesResponseRowsItemVatScheme(string value) =>
        new(value);

    internal class InvoicesListSalesResponseRowsItemVatSchemeSerializer
        : JsonConverter<InvoicesListSalesResponseRowsItemVatScheme>
    {
        public override InvoicesListSalesResponseRowsItemVatScheme Read(
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
            return new InvoicesListSalesResponseRowsItemVatScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesListSalesResponseRowsItemVatScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesListSalesResponseRowsItemVatScheme ReadAsPropertyName(
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
            return new InvoicesListSalesResponseRowsItemVatScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesListSalesResponseRowsItemVatScheme value,
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
