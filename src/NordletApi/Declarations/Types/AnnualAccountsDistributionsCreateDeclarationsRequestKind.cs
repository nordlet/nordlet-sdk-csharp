using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AnnualAccountsDistributionsCreateDeclarationsRequestKind.AnnualAccountsDistributionsCreateDeclarationsRequestKindSerializer)
)]
[Serializable]
public readonly record struct AnnualAccountsDistributionsCreateDeclarationsRequestKind : IStringEnum
{
    public static readonly AnnualAccountsDistributionsCreateDeclarationsRequestKind Dividend = new(
        Values.Dividend
    );

    public static readonly AnnualAccountsDistributionsCreateDeclarationsRequestKind InterimDividend =
        new(Values.InterimDividend);

    public static readonly AnnualAccountsDistributionsCreateDeclarationsRequestKind Other = new(
        Values.Other
    );

    public AnnualAccountsDistributionsCreateDeclarationsRequestKind(string value)
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
    public static AnnualAccountsDistributionsCreateDeclarationsRequestKind FromCustom(string value)
    {
        return new AnnualAccountsDistributionsCreateDeclarationsRequestKind(value);
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
        AnnualAccountsDistributionsCreateDeclarationsRequestKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnualAccountsDistributionsCreateDeclarationsRequestKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnualAccountsDistributionsCreateDeclarationsRequestKind value
    ) => value.Value;

    public static explicit operator AnnualAccountsDistributionsCreateDeclarationsRequestKind(
        string value
    ) => new(value);

    internal class AnnualAccountsDistributionsCreateDeclarationsRequestKindSerializer
        : JsonConverter<AnnualAccountsDistributionsCreateDeclarationsRequestKind>
    {
        public override AnnualAccountsDistributionsCreateDeclarationsRequestKind Read(
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
            return new AnnualAccountsDistributionsCreateDeclarationsRequestKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnualAccountsDistributionsCreateDeclarationsRequestKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnualAccountsDistributionsCreateDeclarationsRequestKind ReadAsPropertyName(
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
            return new AnnualAccountsDistributionsCreateDeclarationsRequestKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnualAccountsDistributionsCreateDeclarationsRequestKind value,
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
