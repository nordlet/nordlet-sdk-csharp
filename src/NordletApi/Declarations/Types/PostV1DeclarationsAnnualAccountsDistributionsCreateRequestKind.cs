using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind.PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKindSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind
    : IStringEnum
{
    public static readonly PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind Dividend =
        new(Values.Dividend);

    public static readonly PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind InterimDividend =
        new(Values.InterimDividend);

    public static readonly PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind Other =
        new(Values.Other);

    public PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind(string value)
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
    public static PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind(value);
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
        PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind(
        string value
    ) => new(value);

    internal class PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKindSerializer
        : JsonConverter<PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind>
    {
        public override PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind Read(
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
            return new PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind ReadAsPropertyName(
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
            return new PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsAnnualAccountsDistributionsCreateRequestKind value,
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
        public const string Dividend = "dividend";

        public const string InterimDividend = "interim_dividend";

        public const string Other = "other";
    }
}
