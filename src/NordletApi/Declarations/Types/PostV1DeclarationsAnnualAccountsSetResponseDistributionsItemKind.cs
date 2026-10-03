using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind.PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKindSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind
    : IStringEnum
{
    public static readonly PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind Dividend =
        new(Values.Dividend);

    public static readonly PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind InterimDividend =
        new(Values.InterimDividend);

    public static readonly PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind Other =
        new(Values.Other);

    public PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind(string value)
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
    public static PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind(value);
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
        PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind(
        string value
    ) => new(value);

    internal class PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKindSerializer
        : JsonConverter<PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind>
    {
        public override PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind Read(
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
            return new PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind ReadAsPropertyName(
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
            return new PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsAnnualAccountsSetResponseDistributionsItemKind value,
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
