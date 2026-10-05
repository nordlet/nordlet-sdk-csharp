using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InvoicesApplyAdvanceSalesResponseVatScheme.InvoicesApplyAdvanceSalesResponseVatSchemeSerializer)
)]
[Serializable]
public readonly record struct InvoicesApplyAdvanceSalesResponseVatScheme : IStringEnum
{
    public static readonly InvoicesApplyAdvanceSalesResponseVatScheme Domestic = new(
        Values.Domestic
    );

    public static readonly InvoicesApplyAdvanceSalesResponseVatScheme IntraEuB2B = new(
        Values.IntraEuB2B
    );

    public static readonly InvoicesApplyAdvanceSalesResponseVatScheme ReverseCharge = new(
        Values.ReverseCharge
    );

    public static readonly InvoicesApplyAdvanceSalesResponseVatScheme OssUnion = new(
        Values.OssUnion
    );

    public static readonly InvoicesApplyAdvanceSalesResponseVatScheme Ioss = new(Values.Ioss);

    public static readonly InvoicesApplyAdvanceSalesResponseVatScheme MarketplaceDeemed = new(
        Values.MarketplaceDeemed
    );

    public static readonly InvoicesApplyAdvanceSalesResponseVatScheme Export = new(Values.Export);

    public static readonly InvoicesApplyAdvanceSalesResponseVatScheme OutOfScope = new(
        Values.OutOfScope
    );

    public static readonly InvoicesApplyAdvanceSalesResponseVatScheme SmeExempt = new(
        Values.SmeExempt
    );

    public InvoicesApplyAdvanceSalesResponseVatScheme(string value)
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
    public static InvoicesApplyAdvanceSalesResponseVatScheme FromCustom(string value)
    {
        return new InvoicesApplyAdvanceSalesResponseVatScheme(value);
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
        InvoicesApplyAdvanceSalesResponseVatScheme value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InvoicesApplyAdvanceSalesResponseVatScheme value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesApplyAdvanceSalesResponseVatScheme value) =>
        value.Value;

    public static explicit operator InvoicesApplyAdvanceSalesResponseVatScheme(string value) =>
        new(value);

    internal class InvoicesApplyAdvanceSalesResponseVatSchemeSerializer
        : JsonConverter<InvoicesApplyAdvanceSalesResponseVatScheme>
    {
        public override InvoicesApplyAdvanceSalesResponseVatScheme Read(
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
            return new InvoicesApplyAdvanceSalesResponseVatScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoicesApplyAdvanceSalesResponseVatScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InvoicesApplyAdvanceSalesResponseVatScheme ReadAsPropertyName(
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
            return new InvoicesApplyAdvanceSalesResponseVatScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InvoicesApplyAdvanceSalesResponseVatScheme value,
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
