using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(FxRevaluationRunLedgerResponseLinesItemKind.FxRevaluationRunLedgerResponseLinesItemKindSerializer)
)]
[Serializable]
public readonly record struct FxRevaluationRunLedgerResponseLinesItemKind : IStringEnum
{
    public static readonly FxRevaluationRunLedgerResponseLinesItemKind Receivable = new(
        Values.Receivable
    );

    public static readonly FxRevaluationRunLedgerResponseLinesItemKind Payable = new(
        Values.Payable
    );

    public static readonly FxRevaluationRunLedgerResponseLinesItemKind Bank = new(Values.Bank);

    public FxRevaluationRunLedgerResponseLinesItemKind(string value)
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
    public static FxRevaluationRunLedgerResponseLinesItemKind FromCustom(string value)
    {
        return new FxRevaluationRunLedgerResponseLinesItemKind(value);
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
        FxRevaluationRunLedgerResponseLinesItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FxRevaluationRunLedgerResponseLinesItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FxRevaluationRunLedgerResponseLinesItemKind value) =>
        value.Value;

    public static explicit operator FxRevaluationRunLedgerResponseLinesItemKind(string value) =>
        new(value);

    internal class FxRevaluationRunLedgerResponseLinesItemKindSerializer
        : JsonConverter<FxRevaluationRunLedgerResponseLinesItemKind>
    {
        public override FxRevaluationRunLedgerResponseLinesItemKind Read(
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
            return new FxRevaluationRunLedgerResponseLinesItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FxRevaluationRunLedgerResponseLinesItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FxRevaluationRunLedgerResponseLinesItemKind ReadAsPropertyName(
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
            return new FxRevaluationRunLedgerResponseLinesItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FxRevaluationRunLedgerResponseLinesItemKind value,
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
        public const string Receivable = "receivable";

        public const string Payable = "payable";

        public const string Bank = "bank";
    }
}
