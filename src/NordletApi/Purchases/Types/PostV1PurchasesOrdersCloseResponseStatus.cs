using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PurchasesOrdersCloseResponseStatus.PostV1PurchasesOrdersCloseResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PurchasesOrdersCloseResponseStatus : IStringEnum
{
    public static readonly PostV1PurchasesOrdersCloseResponseStatus Draft = new(Values.Draft);

    public static readonly PostV1PurchasesOrdersCloseResponseStatus Submitted = new(
        Values.Submitted
    );

    public static readonly PostV1PurchasesOrdersCloseResponseStatus Approved = new(Values.Approved);

    public static readonly PostV1PurchasesOrdersCloseResponseStatus PartiallyReceived = new(
        Values.PartiallyReceived
    );

    public static readonly PostV1PurchasesOrdersCloseResponseStatus Received = new(Values.Received);

    public static readonly PostV1PurchasesOrdersCloseResponseStatus Closed = new(Values.Closed);

    public static readonly PostV1PurchasesOrdersCloseResponseStatus Cancelled = new(
        Values.Cancelled
    );

    public PostV1PurchasesOrdersCloseResponseStatus(string value)
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
    public static PostV1PurchasesOrdersCloseResponseStatus FromCustom(string value)
    {
        return new PostV1PurchasesOrdersCloseResponseStatus(value);
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
        PostV1PurchasesOrdersCloseResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PurchasesOrdersCloseResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PurchasesOrdersCloseResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1PurchasesOrdersCloseResponseStatus(string value) =>
        new(value);

    internal class PostV1PurchasesOrdersCloseResponseStatusSerializer
        : JsonConverter<PostV1PurchasesOrdersCloseResponseStatus>
    {
        public override PostV1PurchasesOrdersCloseResponseStatus Read(
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
            return new PostV1PurchasesOrdersCloseResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PurchasesOrdersCloseResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PurchasesOrdersCloseResponseStatus ReadAsPropertyName(
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
            return new PostV1PurchasesOrdersCloseResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PurchasesOrdersCloseResponseStatus value,
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
