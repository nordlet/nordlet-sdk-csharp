using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind.AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKindSerializer)
)]
[Serializable]
public readonly record struct AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind
    : IStringEnum
{
    public static readonly AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind Dividend =
        new(Values.Dividend);

    public static readonly AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind InterimDividend =
        new(Values.InterimDividend);

    public static readonly AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind Other =
        new(Values.Other);

    public AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind(string value)
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
    public static AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind FromCustom(
        string value
    )
    {
        return new AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind(value);
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
        AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind value
    ) => value.Value;

    public static explicit operator AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind(
        string value
    ) => new(value);

    internal class AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKindSerializer
        : JsonConverter<AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind>
    {
        public override AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind Read(
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
            return new AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind ReadAsPropertyName(
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
            return new AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnualAccountsGetDeclarationsResponseApprovalDistributionsItemKind value,
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
