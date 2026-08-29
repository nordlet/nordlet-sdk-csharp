using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PurchasesOrdersSubmitResponseStatus.PostV1PurchasesOrdersSubmitResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PurchasesOrdersSubmitResponseStatus : IStringEnum
{
    public static readonly PostV1PurchasesOrdersSubmitResponseStatus Draft = new(Values.Draft);

    public static readonly PostV1PurchasesOrdersSubmitResponseStatus Submitted = new(
        Values.Submitted
    );

    public static readonly PostV1PurchasesOrdersSubmitResponseStatus Approved = new(
        Values.Approved
    );

    public static readonly PostV1PurchasesOrdersSubmitResponseStatus PartiallyReceived = new(
        Values.PartiallyReceived
    );

    public static readonly PostV1PurchasesOrdersSubmitResponseStatus Received = new(
        Values.Received
    );

    public static readonly PostV1PurchasesOrdersSubmitResponseStatus Closed = new(Values.Closed);

    public static readonly PostV1PurchasesOrdersSubmitResponseStatus Cancelled = new(
        Values.Cancelled
    );

    public PostV1PurchasesOrdersSubmitResponseStatus(string value)
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
    public static PostV1PurchasesOrdersSubmitResponseStatus FromCustom(string value)
    {
        return new PostV1PurchasesOrdersSubmitResponseStatus(value);
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
        PostV1PurchasesOrdersSubmitResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PurchasesOrdersSubmitResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PurchasesOrdersSubmitResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1PurchasesOrdersSubmitResponseStatus(string value) =>
        new(value);

    internal class PostV1PurchasesOrdersSubmitResponseStatusSerializer
        : JsonConverter<PostV1PurchasesOrdersSubmitResponseStatus>
    {
        public override PostV1PurchasesOrdersSubmitResponseStatus Read(
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
            return new PostV1PurchasesOrdersSubmitResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PurchasesOrdersSubmitResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PurchasesOrdersSubmitResponseStatus ReadAsPropertyName(
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
            return new PostV1PurchasesOrdersSubmitResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PurchasesOrdersSubmitResponseStatus value,
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
        public const string Draft = "draft";

        public const string Submitted = "submitted";

        public const string Approved = "approved";

        public const string PartiallyReceived = "partially_received";

        public const string Received = "received";

        public const string Closed = "closed";

        public const string Cancelled = "cancelled";
    }
}
