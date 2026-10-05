using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AnnualAccountsSetDeclarationsResponseDistributionsItemKind.AnnualAccountsSetDeclarationsResponseDistributionsItemKindSerializer)
)]
[Serializable]
public readonly record struct AnnualAccountsSetDeclarationsResponseDistributionsItemKind
    : IStringEnum
{
    public static readonly AnnualAccountsSetDeclarationsResponseDistributionsItemKind Dividend =
        new(Values.Dividend);

    public static readonly AnnualAccountsSetDeclarationsResponseDistributionsItemKind InterimDividend =
        new(Values.InterimDividend);

    public static readonly AnnualAccountsSetDeclarationsResponseDistributionsItemKind Other = new(
        Values.Other
    );

    public AnnualAccountsSetDeclarationsResponseDistributionsItemKind(string value)
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
    public static AnnualAccountsSetDeclarationsResponseDistributionsItemKind FromCustom(
        string value
    )
    {
        return new AnnualAccountsSetDeclarationsResponseDistributionsItemKind(value);
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
        AnnualAccountsSetDeclarationsResponseDistributionsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnualAccountsSetDeclarationsResponseDistributionsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnualAccountsSetDeclarationsResponseDistributionsItemKind value
    ) => value.Value;

    public static explicit operator AnnualAccountsSetDeclarationsResponseDistributionsItemKind(
        string value
    ) => new(value);

    internal class AnnualAccountsSetDeclarationsResponseDistributionsItemKindSerializer
        : JsonConverter<AnnualAccountsSetDeclarationsResponseDistributionsItemKind>
    {
        public override AnnualAccountsSetDeclarationsResponseDistributionsItemKind Read(
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
            return new AnnualAccountsSetDeclarationsResponseDistributionsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnualAccountsSetDeclarationsResponseDistributionsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnualAccountsSetDeclarationsResponseDistributionsItemKind ReadAsPropertyName(
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
            return new AnnualAccountsSetDeclarationsResponseDistributionsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnualAccountsSetDeclarationsResponseDistributionsItemKind value,
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
