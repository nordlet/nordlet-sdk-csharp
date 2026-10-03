using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming.PostV1DeclarationsLtGpm312ComputeResponsePayoutTimingSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming : IStringEnum
{
    public static readonly PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming SameMonth = new(
        Values.SameMonth
    );

    public static readonly PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming NextMonth = new(
        Values.NextMonth
    );

    public PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming(string value)
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
    public static PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming FromCustom(string value)
    {
        return new PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming(value);
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
        PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming(
        string value
    ) => new(value);

    internal class PostV1DeclarationsLtGpm312ComputeResponsePayoutTimingSerializer
        : JsonConverter<PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming>
    {
        public override PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming Read(
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
            return new PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming ReadAsPropertyName(
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
            return new PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsLtGpm312ComputeResponsePayoutTiming value,
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
