using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1TransportWaybillsUpdateResponseStatus.PostV1TransportWaybillsUpdateResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1TransportWaybillsUpdateResponseStatus : IStringEnum
{
    public static readonly PostV1TransportWaybillsUpdateResponseStatus Draft = new(Values.Draft);

    public static readonly PostV1TransportWaybillsUpdateResponseStatus Issued = new(Values.Issued);

    public static readonly PostV1TransportWaybillsUpdateResponseStatus Cancelled = new(
        Values.Cancelled
    );

    public PostV1TransportWaybillsUpdateResponseStatus(string value)
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
    public static PostV1TransportWaybillsUpdateResponseStatus FromCustom(string value)
    {
        return new PostV1TransportWaybillsUpdateResponseStatus(value);
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
        PostV1TransportWaybillsUpdateResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1TransportWaybillsUpdateResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1TransportWaybillsUpdateResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1TransportWaybillsUpdateResponseStatus(string value) =>
        new(value);

    internal class PostV1TransportWaybillsUpdateResponseStatusSerializer
        : JsonConverter<PostV1TransportWaybillsUpdateResponseStatus>
    {
        public override PostV1TransportWaybillsUpdateResponseStatus Read(
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
            return new PostV1TransportWaybillsUpdateResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1TransportWaybillsUpdateResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1TransportWaybillsUpdateResponseStatus ReadAsPropertyName(
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
            return new PostV1TransportWaybillsUpdateResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1TransportWaybillsUpdateResponseStatus value,
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
