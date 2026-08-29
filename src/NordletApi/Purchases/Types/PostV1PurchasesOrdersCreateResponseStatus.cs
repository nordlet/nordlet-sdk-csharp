using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1PurchasesOrdersCreateResponseStatus.PostV1PurchasesOrdersCreateResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1PurchasesOrdersCreateResponseStatus : IStringEnum
{
    public static readonly PostV1PurchasesOrdersCreateResponseStatus Draft = new(Values.Draft);

    public static readonly PostV1PurchasesOrdersCreateResponseStatus Submitted = new(
        Values.Submitted
    );

    public static readonly PostV1PurchasesOrdersCreateResponseStatus Approved = new(
        Values.Approved
    );

    public static readonly PostV1PurchasesOrdersCreateResponseStatus PartiallyReceived = new(
        Values.PartiallyReceived
    );

    public static readonly PostV1PurchasesOrdersCreateResponseStatus Received = new(
        Values.Received
    );

    public static readonly PostV1PurchasesOrdersCreateResponseStatus Closed = new(Values.Closed);

    public static readonly PostV1PurchasesOrdersCreateResponseStatus Cancelled = new(
        Values.Cancelled
    );

    public PostV1PurchasesOrdersCreateResponseStatus(string value)
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
    public static PostV1PurchasesOrdersCreateResponseStatus FromCustom(string value)
    {
        return new PostV1PurchasesOrdersCreateResponseStatus(value);
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
        PostV1PurchasesOrdersCreateResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1PurchasesOrdersCreateResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1PurchasesOrdersCreateResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1PurchasesOrdersCreateResponseStatus(string value) =>
        new(value);

    internal class PostV1PurchasesOrdersCreateResponseStatusSerializer
        : JsonConverter<PostV1PurchasesOrdersCreateResponseStatus>
    {
        public override PostV1PurchasesOrdersCreateResponseStatus Read(
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
            return new PostV1PurchasesOrdersCreateResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1PurchasesOrdersCreateResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1PurchasesOrdersCreateResponseStatus ReadAsPropertyName(
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
            return new PostV1PurchasesOrdersCreateResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1PurchasesOrdersCreateResponseStatus value,
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
