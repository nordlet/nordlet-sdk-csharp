using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TaxPaymentsUpdateDeclarationsResponseKind.TaxPaymentsUpdateDeclarationsResponseKindSerializer)
)]
[Serializable]
public readonly record struct TaxPaymentsUpdateDeclarationsResponseKind : IStringEnum
{
    public static readonly TaxPaymentsUpdateDeclarationsResponseKind Advance = new(Values.Advance);

    public static readonly TaxPaymentsUpdateDeclarationsResponseKind Withholding = new(
        Values.Withholding
    );

    public static readonly TaxPaymentsUpdateDeclarationsResponseKind Final = new(Values.Final);

    public static readonly TaxPaymentsUpdateDeclarationsResponseKind Refund = new(Values.Refund);

    public TaxPaymentsUpdateDeclarationsResponseKind(string value)
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
    public static TaxPaymentsUpdateDeclarationsResponseKind FromCustom(string value)
    {
        return new TaxPaymentsUpdateDeclarationsResponseKind(value);
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
        TaxPaymentsUpdateDeclarationsResponseKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TaxPaymentsUpdateDeclarationsResponseKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TaxPaymentsUpdateDeclarationsResponseKind value) =>
        value.Value;

    public static explicit operator TaxPaymentsUpdateDeclarationsResponseKind(string value) =>
        new(value);

    internal class TaxPaymentsUpdateDeclarationsResponseKindSerializer
        : JsonConverter<TaxPaymentsUpdateDeclarationsResponseKind>
    {
        public override TaxPaymentsUpdateDeclarationsResponseKind Read(
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
            return new TaxPaymentsUpdateDeclarationsResponseKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TaxPaymentsUpdateDeclarationsResponseKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TaxPaymentsUpdateDeclarationsResponseKind ReadAsPropertyName(
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
            return new TaxPaymentsUpdateDeclarationsResponseKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TaxPaymentsUpdateDeclarationsResponseKind value,
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
