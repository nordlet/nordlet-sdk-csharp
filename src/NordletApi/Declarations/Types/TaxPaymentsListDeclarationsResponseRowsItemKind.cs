using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(TaxPaymentsListDeclarationsResponseRowsItemKind.TaxPaymentsListDeclarationsResponseRowsItemKindSerializer)
)]
[Serializable]
public readonly record struct TaxPaymentsListDeclarationsResponseRowsItemKind : IStringEnum
{
    public static readonly TaxPaymentsListDeclarationsResponseRowsItemKind Advance = new(
        Values.Advance
    );

    public static readonly TaxPaymentsListDeclarationsResponseRowsItemKind Withholding = new(
        Values.Withholding
    );

    public static readonly TaxPaymentsListDeclarationsResponseRowsItemKind Final = new(
        Values.Final
    );

    public static readonly TaxPaymentsListDeclarationsResponseRowsItemKind Refund = new(
        Values.Refund
    );

    public TaxPaymentsListDeclarationsResponseRowsItemKind(string value)
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
    public static TaxPaymentsListDeclarationsResponseRowsItemKind FromCustom(string value)
    {
        return new TaxPaymentsListDeclarationsResponseRowsItemKind(value);
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
        TaxPaymentsListDeclarationsResponseRowsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TaxPaymentsListDeclarationsResponseRowsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TaxPaymentsListDeclarationsResponseRowsItemKind value) =>
        value.Value;

    public static explicit operator TaxPaymentsListDeclarationsResponseRowsItemKind(string value) =>
        new(value);

    internal class TaxPaymentsListDeclarationsResponseRowsItemKindSerializer
        : JsonConverter<TaxPaymentsListDeclarationsResponseRowsItemKind>
    {
        public override TaxPaymentsListDeclarationsResponseRowsItemKind Read(
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
            return new TaxPaymentsListDeclarationsResponseRowsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TaxPaymentsListDeclarationsResponseRowsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TaxPaymentsListDeclarationsResponseRowsItemKind ReadAsPropertyName(
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
            return new TaxPaymentsListDeclarationsResponseRowsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TaxPaymentsListDeclarationsResponseRowsItemKind value,
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
