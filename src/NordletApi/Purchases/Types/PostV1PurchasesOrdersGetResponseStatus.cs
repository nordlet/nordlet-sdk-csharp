using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PurchasesOrdersGetResponseStatus.PostV1PurchasesOrdersGetResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PurchasesOrdersGetResponseStatus : IStringEnum
{
    public static readonly PostV1PurchasesOrdersGetResponseStatus Draft = new(Values.Draft);

    public static readonly PostV1PurchasesOrdersGetResponseStatus Submitted = new(Values.Submitted);

    public static readonly PostV1PurchasesOrdersGetResponseStatus Approved = new(Values.Approved);

    public static readonly PostV1PurchasesOrdersGetResponseStatus PartiallyReceived = new(
        Values.PartiallyReceived
    );

    public static readonly PostV1PurchasesOrdersGetResponseStatus Received = new(Values.Received);

    public static readonly PostV1PurchasesOrdersGetResponseStatus Closed = new(Values.Closed);

    public static readonly PostV1PurchasesOrdersGetResponseStatus Cancelled = new(Values.Cancelled);

    public PostV1PurchasesOrdersGetResponseStatus(string value)
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
    public static PostV1PurchasesOrdersGetResponseStatus FromCustom(string value)
    {
        return new PostV1PurchasesOrdersGetResponseStatus(value);
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

    public static bool operator ==(PostV1PurchasesOrdersGetResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1PurchasesOrdersGetResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PurchasesOrdersGetResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1PurchasesOrdersGetResponseStatus(string value) =>
        new(value);

    internal class PostV1PurchasesOrdersGetResponseStatusSerializer
        : JsonConverter<PostV1PurchasesOrdersGetResponseStatus>
    {
        public override PostV1PurchasesOrdersGetResponseStatus Read(
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
            return new PostV1PurchasesOrdersGetResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PurchasesOrdersGetResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PurchasesOrdersGetResponseStatus ReadAsPropertyName(
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
            return new PostV1PurchasesOrdersGetResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PurchasesOrdersGetResponseStatus value,
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
