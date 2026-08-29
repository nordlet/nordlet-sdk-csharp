using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ReferenceEuVatRatesSyncResponseStatus.PostV1ReferenceEuVatRatesSyncResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1ReferenceEuVatRatesSyncResponseStatus : IStringEnum
{
    public static readonly PostV1ReferenceEuVatRatesSyncResponseStatus Running = new(
        Values.Running
    );

    public static readonly PostV1ReferenceEuVatRatesSyncResponseStatus Succeeded = new(
        Values.Succeeded
    );

    public static readonly PostV1ReferenceEuVatRatesSyncResponseStatus Failed = new(Values.Failed);

    public PostV1ReferenceEuVatRatesSyncResponseStatus(string value)
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
    public static PostV1ReferenceEuVatRatesSyncResponseStatus FromCustom(string value)
    {
        return new PostV1ReferenceEuVatRatesSyncResponseStatus(value);
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
        PostV1ReferenceEuVatRatesSyncResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ReferenceEuVatRatesSyncResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ReferenceEuVatRatesSyncResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1ReferenceEuVatRatesSyncResponseStatus(string value) =>
        new(value);

    internal class PostV1ReferenceEuVatRatesSyncResponseStatusSerializer
        : JsonConverter<PostV1ReferenceEuVatRatesSyncResponseStatus>
    {
        public override PostV1ReferenceEuVatRatesSyncResponseStatus Read(
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
            return new PostV1ReferenceEuVatRatesSyncResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ReferenceEuVatRatesSyncResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ReferenceEuVatRatesSyncResponseStatus ReadAsPropertyName(
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
            return new PostV1ReferenceEuVatRatesSyncResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ReferenceEuVatRatesSyncResponseStatus value,
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
        public const string Running = "running";

        public const string Succeeded = "succeeded";

        public const string Failed = "failed";
    }
}
