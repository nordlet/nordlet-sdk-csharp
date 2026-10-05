using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TaxPaymentsCreateDeclarationsResponseKind.TaxPaymentsCreateDeclarationsResponseKindSerializer)
)]
[Serializable]
public readonly record struct TaxPaymentsCreateDeclarationsResponseKind : IStringEnum
{
    public static readonly TaxPaymentsCreateDeclarationsResponseKind Advance = new(Values.Advance);

    public static readonly TaxPaymentsCreateDeclarationsResponseKind Withholding = new(
        Values.Withholding
    );

    public static readonly TaxPaymentsCreateDeclarationsResponseKind Final = new(Values.Final);

    public static readonly TaxPaymentsCreateDeclarationsResponseKind Refund = new(Values.Refund);

    public TaxPaymentsCreateDeclarationsResponseKind(string value)
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
    public static TaxPaymentsCreateDeclarationsResponseKind FromCustom(string value)
    {
        return new TaxPaymentsCreateDeclarationsResponseKind(value);
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
        TaxPaymentsCreateDeclarationsResponseKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TaxPaymentsCreateDeclarationsResponseKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TaxPaymentsCreateDeclarationsResponseKind value) =>
        value.Value;

    public static explicit operator TaxPaymentsCreateDeclarationsResponseKind(string value) =>
        new(value);

    internal class TaxPaymentsCreateDeclarationsResponseKindSerializer
        : JsonConverter<TaxPaymentsCreateDeclarationsResponseKind>
    {
        public override TaxPaymentsCreateDeclarationsResponseKind Read(
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
            return new TaxPaymentsCreateDeclarationsResponseKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TaxPaymentsCreateDeclarationsResponseKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TaxPaymentsCreateDeclarationsResponseKind ReadAsPropertyName(
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
            return new TaxPaymentsCreateDeclarationsResponseKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TaxPaymentsCreateDeclarationsResponseKind value,
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
        public const string Advance = "advance";

        public const string Withholding = "withholding";

        public const string Final = "final";

        public const string Refund = "refund";
    }
}
