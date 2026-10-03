using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsLtGpm312ComputeRequestPayoutTiming.PostV1DeclarationsLtGpm312ComputeRequestPayoutTimingSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsLtGpm312ComputeRequestPayoutTiming : IStringEnum
{
    public static readonly PostV1DeclarationsLtGpm312ComputeRequestPayoutTiming SameMonth = new(
        Values.SameMonth
    );

    public static readonly PostV1DeclarationsLtGpm312ComputeRequestPayoutTiming NextMonth = new(
        Values.NextMonth
    );

    public PostV1DeclarationsLtGpm312ComputeRequestPayoutTiming(string value)
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
    public static PostV1DeclarationsLtGpm312ComputeRequestPayoutTiming FromCustom(string value)
    {
        return new PostV1DeclarationsLtGpm312ComputeRequestPayoutTiming(value);
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
        PostV1DeclarationsLtGpm312ComputeRequestPayoutTiming value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsLtGpm312ComputeRequestPayoutTiming value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsLtGpm312ComputeRequestPayoutTiming value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsLtGpm312ComputeRequestPayoutTiming(
        string value
    ) => new(value);

    internal class PostV1DeclarationsLtGpm312ComputeRequestPayoutTimingSerializer
        : JsonConverter<PostV1DeclarationsLtGpm312ComputeRequestPayoutTiming>
    {
        public override PostV1DeclarationsLtGpm312ComputeRequestPayoutTiming Read(
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
            return new PostV1DeclarationsLtGpm312ComputeRequestPayoutTiming(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsLtGpm312ComputeRequestPayoutTiming value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsLtGpm312ComputeRequestPayoutTiming ReadAsPropertyName(
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
            return new PostV1DeclarationsLtGpm312ComputeRequestPayoutTiming(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsLtGpm312ComputeRequestPayoutTiming value,
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
        public const string SameMonth = "same-month";

        public const string NextMonth = "next-month";
    }
}
