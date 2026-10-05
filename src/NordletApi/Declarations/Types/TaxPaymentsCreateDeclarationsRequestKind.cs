using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TaxPaymentsCreateDeclarationsRequestKind.TaxPaymentsCreateDeclarationsRequestKindSerializer)
)]
[Serializable]
public readonly record struct TaxPaymentsCreateDeclarationsRequestKind : IStringEnum
{
    public static readonly TaxPaymentsCreateDeclarationsRequestKind Advance = new(Values.Advance);

    public static readonly TaxPaymentsCreateDeclarationsRequestKind Withholding = new(
        Values.Withholding
    );

    public static readonly TaxPaymentsCreateDeclarationsRequestKind Final = new(Values.Final);

    public static readonly TaxPaymentsCreateDeclarationsRequestKind Refund = new(Values.Refund);

    public TaxPaymentsCreateDeclarationsRequestKind(string value)
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
    public static TaxPaymentsCreateDeclarationsRequestKind FromCustom(string value)
    {
        return new TaxPaymentsCreateDeclarationsRequestKind(value);
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
        TaxPaymentsCreateDeclarationsRequestKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TaxPaymentsCreateDeclarationsRequestKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TaxPaymentsCreateDeclarationsRequestKind value) =>
        value.Value;

    public static explicit operator TaxPaymentsCreateDeclarationsRequestKind(string value) =>
        new(value);

    internal class TaxPaymentsCreateDeclarationsRequestKindSerializer
        : JsonConverter<TaxPaymentsCreateDeclarationsRequestKind>
    {
        public override TaxPaymentsCreateDeclarationsRequestKind Read(
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
            return new TaxPaymentsCreateDeclarationsRequestKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TaxPaymentsCreateDeclarationsRequestKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TaxPaymentsCreateDeclarationsRequestKind ReadAsPropertyName(
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
            return new TaxPaymentsCreateDeclarationsRequestKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TaxPaymentsCreateDeclarationsRequestKind value,
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
