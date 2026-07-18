using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesRecognitionRunResponseTrigger.PostV1SalesRecognitionRunResponseTriggerSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesRecognitionRunResponseTrigger : IStringEnum
{
    public static readonly PostV1SalesRecognitionRunResponseTrigger Manual = new(Values.Manual);

    public static readonly PostV1SalesRecognitionRunResponseTrigger ScheduleDue = new(
        Values.ScheduleDue
    );

    public static readonly PostV1SalesRecognitionRunResponseTrigger PeriodClose = new(
        Values.PeriodClose
    );

    public static readonly PostV1SalesRecognitionRunResponseTrigger DeliveryAct = new(
        Values.DeliveryAct
    );

    public static readonly PostV1SalesRecognitionRunResponseTrigger Progress = new(Values.Progress);

    public static readonly PostV1SalesRecognitionRunResponseTrigger Modification = new(
        Values.Modification
    );

    public PostV1SalesRecognitionRunResponseTrigger(string value)
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
    public static PostV1SalesRecognitionRunResponseTrigger FromCustom(string value)
    {
        return new PostV1SalesRecognitionRunResponseTrigger(value);
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
        PostV1SalesRecognitionRunResponseTrigger value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesRecognitionRunResponseTrigger value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1SalesRecognitionRunResponseTrigger value) =>
        value.Value;

    public static explicit operator PostV1SalesRecognitionRunResponseTrigger(string value) =>
        new(value);

    internal class PostV1SalesRecognitionRunResponseTriggerSerializer
        : JsonConverter<PostV1SalesRecognitionRunResponseTrigger>
    {
        public override PostV1SalesRecognitionRunResponseTrigger Read(
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
            return new PostV1SalesRecognitionRunResponseTrigger(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesRecognitionRunResponseTrigger value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesRecognitionRunResponseTrigger ReadAsPropertyName(
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
            return new PostV1SalesRecognitionRunResponseTrigger(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesRecognitionRunResponseTrigger value,
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
