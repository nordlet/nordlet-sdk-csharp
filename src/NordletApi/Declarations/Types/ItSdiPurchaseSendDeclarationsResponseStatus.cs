using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(ItSdiPurchaseSendDeclarationsResponseStatus.ItSdiPurchaseSendDeclarationsResponseStatusSerializer)
)]
[Serializable]
public readonly record struct ItSdiPurchaseSendDeclarationsResponseStatus : IStringEnum
{
    public static readonly ItSdiPurchaseSendDeclarationsResponseStatus Sent = new(Values.Sent);

    public static readonly ItSdiPurchaseSendDeclarationsResponseStatus Accepted = new(
        Values.Accepted
    );

    public static readonly ItSdiPurchaseSendDeclarationsResponseStatus Rejected = new(
        Values.Rejected
    );

    public ItSdiPurchaseSendDeclarationsResponseStatus(string value)
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
    public static ItSdiPurchaseSendDeclarationsResponseStatus FromCustom(string value)
    {
        return new ItSdiPurchaseSendDeclarationsResponseStatus(value);
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
        ItSdiPurchaseSendDeclarationsResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ItSdiPurchaseSendDeclarationsResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ItSdiPurchaseSendDeclarationsResponseStatus value) =>
        value.Value;

    public static explicit operator ItSdiPurchaseSendDeclarationsResponseStatus(string value) =>
        new(value);

    internal class ItSdiPurchaseSendDeclarationsResponseStatusSerializer
        : JsonConverter<ItSdiPurchaseSendDeclarationsResponseStatus>
    {
        public override ItSdiPurchaseSendDeclarationsResponseStatus Read(
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
            return new ItSdiPurchaseSendDeclarationsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ItSdiPurchaseSendDeclarationsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ItSdiPurchaseSendDeclarationsResponseStatus ReadAsPropertyName(
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
            return new ItSdiPurchaseSendDeclarationsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ItSdiPurchaseSendDeclarationsResponseStatus value,
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
        public const string Sent = "sent";

        public const string Accepted = "accepted";

        public const string Rejected = "rejected";
    }
}
