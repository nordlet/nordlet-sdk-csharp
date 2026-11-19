using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(UsDeFranchiseTaxComputeDeclarationsResponseMethod.UsDeFranchiseTaxComputeDeclarationsResponseMethodSerializer)
)]
[Serializable]
public readonly record struct UsDeFranchiseTaxComputeDeclarationsResponseMethod : IStringEnum
{
    public static readonly UsDeFranchiseTaxComputeDeclarationsResponseMethod AuthorizedShares = new(
        Values.AuthorizedShares
    );

    public static readonly UsDeFranchiseTaxComputeDeclarationsResponseMethod AssumedParValueCapital =
        new(Values.AssumedParValueCapital);

    public static readonly UsDeFranchiseTaxComputeDeclarationsResponseMethod LargeCorporateFiler =
        new(Values.LargeCorporateFiler);

    public UsDeFranchiseTaxComputeDeclarationsResponseMethod(string value)
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
    public static UsDeFranchiseTaxComputeDeclarationsResponseMethod FromCustom(string value)
    {
        return new UsDeFranchiseTaxComputeDeclarationsResponseMethod(value);
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
        UsDeFranchiseTaxComputeDeclarationsResponseMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UsDeFranchiseTaxComputeDeclarationsResponseMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UsDeFranchiseTaxComputeDeclarationsResponseMethod value
    ) => value.Value;

    public static explicit operator UsDeFranchiseTaxComputeDeclarationsResponseMethod(
        string value
    ) => new(value);

    internal class UsDeFranchiseTaxComputeDeclarationsResponseMethodSerializer
        : JsonConverter<UsDeFranchiseTaxComputeDeclarationsResponseMethod>
    {
        public override UsDeFranchiseTaxComputeDeclarationsResponseMethod Read(
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
            return new UsDeFranchiseTaxComputeDeclarationsResponseMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UsDeFranchiseTaxComputeDeclarationsResponseMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UsDeFranchiseTaxComputeDeclarationsResponseMethod ReadAsPropertyName(
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
            return new UsDeFranchiseTaxComputeDeclarationsResponseMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UsDeFranchiseTaxComputeDeclarationsResponseMethod value,
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
        public const string AuthorizedShares = "authorized-shares";

        public const string AssumedParValueCapital = "assumed-par-value-capital";

        public const string LargeCorporateFiler = "large-corporate-filer";
    }
}
