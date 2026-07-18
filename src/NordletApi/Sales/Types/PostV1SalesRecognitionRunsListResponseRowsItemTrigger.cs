using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1SalesRecognitionRunsListResponseRowsItemTrigger.PostV1SalesRecognitionRunsListResponseRowsItemTriggerSerializer)
)]
[Serializable]
public readonly record struct PostV1SalesRecognitionRunsListResponseRowsItemTrigger : IStringEnum
{
    public static readonly PostV1SalesRecognitionRunsListResponseRowsItemTrigger Manual = new(
        Values.Manual
    );

    public static readonly PostV1SalesRecognitionRunsListResponseRowsItemTrigger ScheduleDue = new(
        Values.ScheduleDue
    );

    public static readonly PostV1SalesRecognitionRunsListResponseRowsItemTrigger PeriodClose = new(
        Values.PeriodClose
    );

    public static readonly PostV1SalesRecognitionRunsListResponseRowsItemTrigger DeliveryAct = new(
        Values.DeliveryAct
    );

    public static readonly PostV1SalesRecognitionRunsListResponseRowsItemTrigger Progress = new(
        Values.Progress
    );

    public static readonly PostV1SalesRecognitionRunsListResponseRowsItemTrigger Modification = new(
        Values.Modification
    );

    public PostV1SalesRecognitionRunsListResponseRowsItemTrigger(string value)
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
    public static PostV1SalesRecognitionRunsListResponseRowsItemTrigger FromCustom(string value)
    {
        return new PostV1SalesRecognitionRunsListResponseRowsItemTrigger(value);
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
        PostV1SalesRecognitionRunsListResponseRowsItemTrigger value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1SalesRecognitionRunsListResponseRowsItemTrigger value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1SalesRecognitionRunsListResponseRowsItemTrigger value
    ) => value.Value;

    public static explicit operator PostV1SalesRecognitionRunsListResponseRowsItemTrigger(
        string value
    ) => new(value);

    internal class PostV1SalesRecognitionRunsListResponseRowsItemTriggerSerializer
        : JsonConverter<PostV1SalesRecognitionRunsListResponseRowsItemTrigger>
    {
        public override PostV1SalesRecognitionRunsListResponseRowsItemTrigger Read(
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
            return new PostV1SalesRecognitionRunsListResponseRowsItemTrigger(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1SalesRecognitionRunsListResponseRowsItemTrigger value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1SalesRecognitionRunsListResponseRowsItemTrigger ReadAsPropertyName(
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
            return new PostV1SalesRecognitionRunsListResponseRowsItemTrigger(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1SalesRecognitionRunsListResponseRowsItemTrigger value,
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
