using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(UpdateCalendarResponseCorrectionRequiredItem.UpdateCalendarResponseCorrectionRequiredItemSerializer)
)]
[Serializable]
public readonly record struct UpdateCalendarResponseCorrectionRequiredItem : IStringEnum
{
    public static readonly UpdateCalendarResponseCorrectionRequiredItem Reason = new(Values.Reason);

    public static readonly UpdateCalendarResponseCorrectionRequiredItem ReasonCode = new(
        Values.ReasonCode
    );

    public static readonly UpdateCalendarResponseCorrectionRequiredItem AuthorityReference = new(
        Values.AuthorityReference
    );

    public static readonly UpdateCalendarResponseCorrectionRequiredItem DiscoveredOn = new(
        Values.DiscoveredOn
    );

    public UpdateCalendarResponseCorrectionRequiredItem(string value)
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
    public static UpdateCalendarResponseCorrectionRequiredItem FromCustom(string value)
    {
        return new UpdateCalendarResponseCorrectionRequiredItem(value);
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
        UpdateCalendarResponseCorrectionRequiredItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdateCalendarResponseCorrectionRequiredItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(UpdateCalendarResponseCorrectionRequiredItem value) =>
        value.Value;

    public static explicit operator UpdateCalendarResponseCorrectionRequiredItem(string value) =>
        new(value);

    internal class UpdateCalendarResponseCorrectionRequiredItemSerializer
        : JsonConverter<UpdateCalendarResponseCorrectionRequiredItem>
    {
        public override UpdateCalendarResponseCorrectionRequiredItem Read(
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
            return new UpdateCalendarResponseCorrectionRequiredItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdateCalendarResponseCorrectionRequiredItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdateCalendarResponseCorrectionRequiredItem ReadAsPropertyName(
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
            return new UpdateCalendarResponseCorrectionRequiredItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdateCalendarResponseCorrectionRequiredItem value,
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
        public const string Reason = "reason";

        public const string ReasonCode = "reasonCode";

        public const string AuthorityReference = "authorityReference";

        public const string DiscoveredOn = "discoveredOn";
    }
}
