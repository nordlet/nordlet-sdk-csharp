using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AnnualAccountsDistributionsUpdateDeclarationsRequestKind.AnnualAccountsDistributionsUpdateDeclarationsRequestKindSerializer)
)]
[Serializable]
public readonly record struct AnnualAccountsDistributionsUpdateDeclarationsRequestKind : IStringEnum
{
    public static readonly AnnualAccountsDistributionsUpdateDeclarationsRequestKind Dividend = new(
        Values.Dividend
    );

    public static readonly AnnualAccountsDistributionsUpdateDeclarationsRequestKind InterimDividend =
        new(Values.InterimDividend);

    public static readonly AnnualAccountsDistributionsUpdateDeclarationsRequestKind Other = new(
        Values.Other
    );

    public AnnualAccountsDistributionsUpdateDeclarationsRequestKind(string value)
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
    public static AnnualAccountsDistributionsUpdateDeclarationsRequestKind FromCustom(string value)
    {
        return new AnnualAccountsDistributionsUpdateDeclarationsRequestKind(value);
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
        AnnualAccountsDistributionsUpdateDeclarationsRequestKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnualAccountsDistributionsUpdateDeclarationsRequestKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnualAccountsDistributionsUpdateDeclarationsRequestKind value
    ) => value.Value;

    public static explicit operator AnnualAccountsDistributionsUpdateDeclarationsRequestKind(
        string value
    ) => new(value);

    internal class AnnualAccountsDistributionsUpdateDeclarationsRequestKindSerializer
        : JsonConverter<AnnualAccountsDistributionsUpdateDeclarationsRequestKind>
    {
        public override AnnualAccountsDistributionsUpdateDeclarationsRequestKind Read(
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
            return new AnnualAccountsDistributionsUpdateDeclarationsRequestKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnualAccountsDistributionsUpdateDeclarationsRequestKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnualAccountsDistributionsUpdateDeclarationsRequestKind ReadAsPropertyName(
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
            return new AnnualAccountsDistributionsUpdateDeclarationsRequestKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnualAccountsDistributionsUpdateDeclarationsRequestKind value,
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
