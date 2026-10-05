using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecognitionRunsListSalesResponseRowsItemTrigger.RecognitionRunsListSalesResponseRowsItemTriggerSerializer)
)]
[Serializable]
public readonly record struct RecognitionRunsListSalesResponseRowsItemTrigger : IStringEnum
{
    public static readonly RecognitionRunsListSalesResponseRowsItemTrigger Manual = new(
        Values.Manual
    );

    public static readonly RecognitionRunsListSalesResponseRowsItemTrigger ScheduleDue = new(
        Values.ScheduleDue
    );

    public static readonly RecognitionRunsListSalesResponseRowsItemTrigger PeriodClose = new(
        Values.PeriodClose
    );

    public static readonly RecognitionRunsListSalesResponseRowsItemTrigger DeliveryAct = new(
        Values.DeliveryAct
    );

    public static readonly RecognitionRunsListSalesResponseRowsItemTrigger Progress = new(
        Values.Progress
    );

    public static readonly RecognitionRunsListSalesResponseRowsItemTrigger Modification = new(
        Values.Modification
    );

    public RecognitionRunsListSalesResponseRowsItemTrigger(string value)
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
    public static RecognitionRunsListSalesResponseRowsItemTrigger FromCustom(string value)
    {
        return new RecognitionRunsListSalesResponseRowsItemTrigger(value);
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
        RecognitionRunsListSalesResponseRowsItemTrigger value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecognitionRunsListSalesResponseRowsItemTrigger value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RecognitionRunsListSalesResponseRowsItemTrigger value) =>
        value.Value;

    public static explicit operator RecognitionRunsListSalesResponseRowsItemTrigger(string value) =>
        new(value);

    internal class RecognitionRunsListSalesResponseRowsItemTriggerSerializer
        : JsonConverter<RecognitionRunsListSalesResponseRowsItemTrigger>
    {
        public override RecognitionRunsListSalesResponseRowsItemTrigger Read(
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
            return new RecognitionRunsListSalesResponseRowsItemTrigger(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecognitionRunsListSalesResponseRowsItemTrigger value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecognitionRunsListSalesResponseRowsItemTrigger ReadAsPropertyName(
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
            return new RecognitionRunsListSalesResponseRowsItemTrigger(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecognitionRunsListSalesResponseRowsItemTrigger value,
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
        public const string Manual = "manual";

        public const string ScheduleDue = "schedule_due";

        public const string PeriodClose = "period_close";

        public const string DeliveryAct = "delivery_act";

        public const string Progress = "progress";

        public const string Modification = "modification";
    }
}
