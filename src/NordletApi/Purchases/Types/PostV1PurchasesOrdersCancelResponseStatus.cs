using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PurchasesOrdersCancelResponseStatus.PostV1PurchasesOrdersCancelResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PurchasesOrdersCancelResponseStatus : IStringEnum
{
    public static readonly PostV1PurchasesOrdersCancelResponseStatus Draft = new(Values.Draft);

    public static readonly PostV1PurchasesOrdersCancelResponseStatus Submitted = new(
        Values.Submitted
    );

    public static readonly PostV1PurchasesOrdersCancelResponseStatus Approved = new(
        Values.Approved
    );

    public static readonly PostV1PurchasesOrdersCancelResponseStatus PartiallyReceived = new(
        Values.PartiallyReceived
    );

    public static readonly PostV1PurchasesOrdersCancelResponseStatus Received = new(
        Values.Received
    );

    public static readonly PostV1PurchasesOrdersCancelResponseStatus Closed = new(Values.Closed);

    public static readonly PostV1PurchasesOrdersCancelResponseStatus Cancelled = new(
        Values.Cancelled
    );

    public PostV1PurchasesOrdersCancelResponseStatus(string value)
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
    public static PostV1PurchasesOrdersCancelResponseStatus FromCustom(string value)
    {
        return new PostV1PurchasesOrdersCancelResponseStatus(value);
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
        PostV1PurchasesOrdersCancelResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PurchasesOrdersCancelResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PurchasesOrdersCancelResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1PurchasesOrdersCancelResponseStatus(string value) =>
        new(value);

    internal class PostV1PurchasesOrdersCancelResponseStatusSerializer
        : JsonConverter<PostV1PurchasesOrdersCancelResponseStatus>
    {
        public override PostV1PurchasesOrdersCancelResponseStatus Read(
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
            return new PostV1PurchasesOrdersCancelResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PurchasesOrdersCancelResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PurchasesOrdersCancelResponseStatus ReadAsPropertyName(
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
            return new PostV1PurchasesOrdersCancelResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PurchasesOrdersCancelResponseStatus value,
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
