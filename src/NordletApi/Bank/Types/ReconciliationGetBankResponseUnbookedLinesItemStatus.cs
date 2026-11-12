using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ReconciliationGetBankResponseUnbookedLinesItemStatus.ReconciliationGetBankResponseUnbookedLinesItemStatusSerializer)
)]
[Serializable]
public readonly record struct ReconciliationGetBankResponseUnbookedLinesItemStatus : IStringEnum
{
    public static readonly ReconciliationGetBankResponseUnbookedLinesItemStatus New = new(
        Values.New
    );

    public static readonly ReconciliationGetBankResponseUnbookedLinesItemStatus Matched = new(
        Values.Matched
    );

    public static readonly ReconciliationGetBankResponseUnbookedLinesItemStatus Ignored = new(
        Values.Ignored
    );

    public ReconciliationGetBankResponseUnbookedLinesItemStatus(string value)
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
    public static ReconciliationGetBankResponseUnbookedLinesItemStatus FromCustom(string value)
    {
        return new ReconciliationGetBankResponseUnbookedLinesItemStatus(value);
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
        ReconciliationGetBankResponseUnbookedLinesItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ReconciliationGetBankResponseUnbookedLinesItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ReconciliationGetBankResponseUnbookedLinesItemStatus value
    ) => value.Value;

    public static explicit operator ReconciliationGetBankResponseUnbookedLinesItemStatus(
        string value
    ) => new(value);

    internal class ReconciliationGetBankResponseUnbookedLinesItemStatusSerializer
        : JsonConverter<ReconciliationGetBankResponseUnbookedLinesItemStatus>
    {
        public override ReconciliationGetBankResponseUnbookedLinesItemStatus Read(
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
            return new ReconciliationGetBankResponseUnbookedLinesItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReconciliationGetBankResponseUnbookedLinesItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReconciliationGetBankResponseUnbookedLinesItemStatus ReadAsPropertyName(
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
            return new ReconciliationGetBankResponseUnbookedLinesItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReconciliationGetBankResponseUnbookedLinesItemStatus value,
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
        public const string New = "new";

        public const string Matched = "matched";

        public const string Ignored = "ignored";
    }
}
