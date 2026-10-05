using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TaxPaymentsUpdateDeclarationsRequestKind.TaxPaymentsUpdateDeclarationsRequestKindSerializer)
)]
[Serializable]
public readonly record struct TaxPaymentsUpdateDeclarationsRequestKind : IStringEnum
{
    public static readonly TaxPaymentsUpdateDeclarationsRequestKind Advance = new(Values.Advance);

    public static readonly TaxPaymentsUpdateDeclarationsRequestKind Withholding = new(
        Values.Withholding
    );

    public static readonly TaxPaymentsUpdateDeclarationsRequestKind Final = new(Values.Final);

    public static readonly TaxPaymentsUpdateDeclarationsRequestKind Refund = new(Values.Refund);

    public TaxPaymentsUpdateDeclarationsRequestKind(string value)
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
    public static TaxPaymentsUpdateDeclarationsRequestKind FromCustom(string value)
    {
        return new TaxPaymentsUpdateDeclarationsRequestKind(value);
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
        TaxPaymentsUpdateDeclarationsRequestKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TaxPaymentsUpdateDeclarationsRequestKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TaxPaymentsUpdateDeclarationsRequestKind value) =>
        value.Value;

    public static explicit operator TaxPaymentsUpdateDeclarationsRequestKind(string value) =>
        new(value);

    internal class TaxPaymentsUpdateDeclarationsRequestKindSerializer
        : JsonConverter<TaxPaymentsUpdateDeclarationsRequestKind>
    {
        public override TaxPaymentsUpdateDeclarationsRequestKind Read(
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
            return new TaxPaymentsUpdateDeclarationsRequestKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TaxPaymentsUpdateDeclarationsRequestKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TaxPaymentsUpdateDeclarationsRequestKind ReadAsPropertyName(
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
            return new TaxPaymentsUpdateDeclarationsRequestKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TaxPaymentsUpdateDeclarationsRequestKind value,
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
