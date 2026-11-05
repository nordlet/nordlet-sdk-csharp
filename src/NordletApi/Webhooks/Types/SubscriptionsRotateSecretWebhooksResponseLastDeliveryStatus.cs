using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus.SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatusSerializer)
)]
[Serializable]
public readonly record struct SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus
    : IStringEnum
{
    public static readonly SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus Pending =
        new(Values.Pending);

    public static readonly SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus Delivered =
        new(Values.Delivered);

    public static readonly SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus Failed = new(
        Values.Failed
    );

    public SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus(string value)
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
    public static SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus FromCustom(
        string value
    )
    {
        return new SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus(value);
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
        SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus value
    ) => value.Value;

    public static explicit operator SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus(
        string value
    ) => new(value);

    internal class SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatusSerializer
        : JsonConverter<SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus>
    {
        public override SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus Read(
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
            return new SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus ReadAsPropertyName(
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
            return new SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubscriptionsRotateSecretWebhooksResponseLastDeliveryStatus value,
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
        public const string Pending = "pending";

        public const string Delivered = "delivered";

        public const string Failed = "failed";
    }
}
