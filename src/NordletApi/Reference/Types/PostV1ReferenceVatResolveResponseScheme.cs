using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReferenceVatResolveResponseScheme.PostV1ReferenceVatResolveResponseSchemeSerializer)
)]
[Serializable]
public readonly record struct PostV1ReferenceVatResolveResponseScheme : IStringEnum
{
    public static readonly PostV1ReferenceVatResolveResponseScheme Domestic = new(Values.Domestic);

    public static readonly PostV1ReferenceVatResolveResponseScheme IntraEuB2B = new(
        Values.IntraEuB2B
    );

    public static readonly PostV1ReferenceVatResolveResponseScheme ReverseCharge = new(
        Values.ReverseCharge
    );

    public static readonly PostV1ReferenceVatResolveResponseScheme OssUnion = new(Values.OssUnion);

    public static readonly PostV1ReferenceVatResolveResponseScheme Ioss = new(Values.Ioss);

    public static readonly PostV1ReferenceVatResolveResponseScheme MarketplaceDeemed = new(
        Values.MarketplaceDeemed
    );

    public static readonly PostV1ReferenceVatResolveResponseScheme Export = new(Values.Export);

    public static readonly PostV1ReferenceVatResolveResponseScheme OutOfScope = new(
        Values.OutOfScope
    );

    public PostV1ReferenceVatResolveResponseScheme(string value)
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
    public static PostV1ReferenceVatResolveResponseScheme FromCustom(string value)
    {
        return new PostV1ReferenceVatResolveResponseScheme(value);
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

    public static bool operator ==(PostV1ReferenceVatResolveResponseScheme value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1ReferenceVatResolveResponseScheme value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ReferenceVatResolveResponseScheme value) =>
        value.Value;

    public static explicit operator PostV1ReferenceVatResolveResponseScheme(string value) =>
        new(value);

    internal class PostV1ReferenceVatResolveResponseSchemeSerializer
        : JsonConverter<PostV1ReferenceVatResolveResponseScheme>
    {
        public override PostV1ReferenceVatResolveResponseScheme Read(
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
            return new PostV1ReferenceVatResolveResponseScheme(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReferenceVatResolveResponseScheme value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReferenceVatResolveResponseScheme ReadAsPropertyName(
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
            return new PostV1ReferenceVatResolveResponseScheme(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReferenceVatResolveResponseScheme value,
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
