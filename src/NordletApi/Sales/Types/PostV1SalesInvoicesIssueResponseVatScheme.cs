using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesInvoicesIssueResponseVatScheme.PostV1SalesInvoicesIssueResponseVatSchemeSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesInvoicesIssueResponseVatScheme : IStringEnum
{
    public static readonly PostV1SalesInvoicesIssueResponseVatScheme Domestic = new(
        Values.Domestic
    );

    public static readonly PostV1SalesInvoicesIssueResponseVatScheme IntraEuB2B = new(
        Values.IntraEuB2B
    );

    public static readonly PostV1SalesInvoicesIssueResponseVatScheme ReverseCharge = new(
        Values.ReverseCharge
    );

    public static readonly PostV1SalesInvoicesIssueResponseVatScheme OssUnion = new(
        Values.OssUnion
    );

    public static readonly PostV1SalesInvoicesIssueResponseVatScheme Ioss = new(Values.Ioss);

    public static readonly PostV1SalesInvoicesIssueResponseVatScheme MarketplaceDeemed = new(
        Values.MarketplaceDeemed
    );

    public static readonly PostV1SalesInvoicesIssueResponseVatScheme Export = new(Values.Export);

    public static readonly PostV1SalesInvoicesIssueResponseVatScheme OutOfScope = new(
        Values.OutOfScope
    );

    public PostV1SalesInvoicesIssueResponseVatScheme(string value)
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
    public static PostV1SalesInvoicesIssueResponseVatScheme FromCustom(string value)
    {
        return new PostV1SalesInvoicesIssueResponseVatScheme(value);
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
        PostV1SalesInvoicesIssueResponseVatScheme value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesInvoicesIssueResponseVatScheme value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1SalesInvoicesIssueResponseVatScheme value) =>
        value.Value;

    public static explicit operator PostV1SalesInvoicesIssueResponseVatScheme(string value) =>
        new(value);

    internal class PostV1SalesInvoicesIssueResponseVatSchemeSerializer
        : JsonConverter<PostV1SalesInvoicesIssueResponseVatScheme>
    {
        public override PostV1SalesInvoicesIssueResponseVatScheme Read(
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
            return new PostV1SalesInvoicesIssueResponseVatScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesIssueResponseVatScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesInvoicesIssueResponseVatScheme ReadAsPropertyName(
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
            return new PostV1SalesInvoicesIssueResponseVatScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesInvoicesIssueResponseVatScheme value,
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
    }
}
