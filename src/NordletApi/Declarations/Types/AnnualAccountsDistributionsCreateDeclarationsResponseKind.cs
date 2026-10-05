using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AnnualAccountsDistributionsCreateDeclarationsResponseKind.AnnualAccountsDistributionsCreateDeclarationsResponseKindSerializer)
)]
[Serializable]
public readonly record struct AnnualAccountsDistributionsCreateDeclarationsResponseKind
    : IStringEnum
{
    public static readonly AnnualAccountsDistributionsCreateDeclarationsResponseKind Dividend = new(
        Values.Dividend
    );

    public static readonly AnnualAccountsDistributionsCreateDeclarationsResponseKind InterimDividend =
        new(Values.InterimDividend);

    public static readonly AnnualAccountsDistributionsCreateDeclarationsResponseKind Other = new(
        Values.Other
    );

    public AnnualAccountsDistributionsCreateDeclarationsResponseKind(string value)
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
    public static AnnualAccountsDistributionsCreateDeclarationsResponseKind FromCustom(string value)
    {
        return new AnnualAccountsDistributionsCreateDeclarationsResponseKind(value);
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
        AnnualAccountsDistributionsCreateDeclarationsResponseKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnualAccountsDistributionsCreateDeclarationsResponseKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnualAccountsDistributionsCreateDeclarationsResponseKind value
    ) => value.Value;

    public static explicit operator AnnualAccountsDistributionsCreateDeclarationsResponseKind(
        string value
    ) => new(value);

    internal class AnnualAccountsDistributionsCreateDeclarationsResponseKindSerializer
        : JsonConverter<AnnualAccountsDistributionsCreateDeclarationsResponseKind>
    {
        public override AnnualAccountsDistributionsCreateDeclarationsResponseKind Read(
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
            return new AnnualAccountsDistributionsCreateDeclarationsResponseKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnualAccountsDistributionsCreateDeclarationsResponseKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnualAccountsDistributionsCreateDeclarationsResponseKind ReadAsPropertyName(
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
            return new AnnualAccountsDistributionsCreateDeclarationsResponseKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnualAccountsDistributionsCreateDeclarationsResponseKind value,
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
