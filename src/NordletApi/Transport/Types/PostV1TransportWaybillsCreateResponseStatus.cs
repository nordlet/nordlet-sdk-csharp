using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1TransportWaybillsCreateResponseStatus.PostV1TransportWaybillsCreateResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1TransportWaybillsCreateResponseStatus : IStringEnum
{
    public static readonly PostV1TransportWaybillsCreateResponseStatus Draft = new(Values.Draft);

    public static readonly PostV1TransportWaybillsCreateResponseStatus Issued = new(Values.Issued);

    public static readonly PostV1TransportWaybillsCreateResponseStatus Cancelled = new(
        Values.Cancelled
    );

    public PostV1TransportWaybillsCreateResponseStatus(string value)
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
    public static PostV1TransportWaybillsCreateResponseStatus FromCustom(string value)
    {
        return new PostV1TransportWaybillsCreateResponseStatus(value);
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
        PostV1TransportWaybillsCreateResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1TransportWaybillsCreateResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1TransportWaybillsCreateResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1TransportWaybillsCreateResponseStatus(string value) =>
        new(value);

    internal class PostV1TransportWaybillsCreateResponseStatusSerializer
        : JsonConverter<PostV1TransportWaybillsCreateResponseStatus>
    {
        public override PostV1TransportWaybillsCreateResponseStatus Read(
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
            return new PostV1TransportWaybillsCreateResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1TransportWaybillsCreateResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1TransportWaybillsCreateResponseStatus ReadAsPropertyName(
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
            return new PostV1TransportWaybillsCreateResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1TransportWaybillsCreateResponseStatus value,
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

        public const string Issued = "issued";

        public const string Cancelled = "cancelled";
    }
}
