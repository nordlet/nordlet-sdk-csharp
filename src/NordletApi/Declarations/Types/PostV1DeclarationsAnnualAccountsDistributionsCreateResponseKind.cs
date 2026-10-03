using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind.PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKindSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind
    : IStringEnum
{
    public static readonly PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind Dividend =
        new(Values.Dividend);

    public static readonly PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind InterimDividend =
        new(Values.InterimDividend);

    public static readonly PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind Other =
        new(Values.Other);

    public PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind(string value)
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
    public static PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind(value);
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
        PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind(
        string value
    ) => new(value);

    internal class PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKindSerializer
        : JsonConverter<PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind>
    {
        public override PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind Read(
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
            return new PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind ReadAsPropertyName(
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
            return new PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsAnnualAccountsDistributionsCreateResponseKind value,
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
