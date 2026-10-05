using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(RecognitionRunSalesResponseTrigger.RecognitionRunSalesResponseTriggerSerializer)
)]
[Serializable]
public readonly record struct RecognitionRunSalesResponseTrigger : IStringEnum
{
    public static readonly RecognitionRunSalesResponseTrigger Manual = new(Values.Manual);

    public static readonly RecognitionRunSalesResponseTrigger ScheduleDue = new(Values.ScheduleDue);

    public static readonly RecognitionRunSalesResponseTrigger PeriodClose = new(Values.PeriodClose);

    public static readonly RecognitionRunSalesResponseTrigger DeliveryAct = new(Values.DeliveryAct);

    public static readonly RecognitionRunSalesResponseTrigger Progress = new(Values.Progress);

    public static readonly RecognitionRunSalesResponseTrigger Modification = new(
        Values.Modification
    );

    public RecognitionRunSalesResponseTrigger(string value)
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
    public static RecognitionRunSalesResponseTrigger FromCustom(string value)
    {
        return new RecognitionRunSalesResponseTrigger(value);
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

    public static bool operator ==(RecognitionRunSalesResponseTrigger value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RecognitionRunSalesResponseTrigger value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RecognitionRunSalesResponseTrigger value) => value.Value;

    public static explicit operator RecognitionRunSalesResponseTrigger(string value) => new(value);

    internal class RecognitionRunSalesResponseTriggerSerializer
        : JsonConverter<RecognitionRunSalesResponseTrigger>
    {
        public override RecognitionRunSalesResponseTrigger Read(
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
            return new RecognitionRunSalesResponseTrigger(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RecognitionRunSalesResponseTrigger value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RecognitionRunSalesResponseTrigger ReadAsPropertyName(
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
            return new RecognitionRunSalesResponseTrigger(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RecognitionRunSalesResponseTrigger value,
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
