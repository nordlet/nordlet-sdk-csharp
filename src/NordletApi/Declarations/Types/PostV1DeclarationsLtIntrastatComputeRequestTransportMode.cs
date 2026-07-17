using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsLtIntrastatComputeRequestTransportMode.PostV1DeclarationsLtIntrastatComputeRequestTransportModeSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsLtIntrastatComputeRequestTransportMode : IStringEnum
{
    public static readonly PostV1DeclarationsLtIntrastatComputeRequestTransportMode One = new(
        Values.One
    );

    public static readonly PostV1DeclarationsLtIntrastatComputeRequestTransportMode Two = new(
        Values.Two
    );

    public static readonly PostV1DeclarationsLtIntrastatComputeRequestTransportMode Three = new(
        Values.Three
    );

    public static readonly PostV1DeclarationsLtIntrastatComputeRequestTransportMode Four = new(
        Values.Four
    );

    public static readonly PostV1DeclarationsLtIntrastatComputeRequestTransportMode Five = new(
        Values.Five
    );

    public static readonly PostV1DeclarationsLtIntrastatComputeRequestTransportMode Seven = new(
        Values.Seven
    );

    public static readonly PostV1DeclarationsLtIntrastatComputeRequestTransportMode Eight = new(
        Values.Eight
    );

    public static readonly PostV1DeclarationsLtIntrastatComputeRequestTransportMode Nine = new(
        Values.Nine
    );

    public PostV1DeclarationsLtIntrastatComputeRequestTransportMode(string value)
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
    public static PostV1DeclarationsLtIntrastatComputeRequestTransportMode FromCustom(string value)
    {
        return new PostV1DeclarationsLtIntrastatComputeRequestTransportMode(value);
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
        PostV1DeclarationsLtIntrastatComputeRequestTransportMode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsLtIntrastatComputeRequestTransportMode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsLtIntrastatComputeRequestTransportMode value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsLtIntrastatComputeRequestTransportMode(
        string value
    ) => new(value);

    internal class PostV1DeclarationsLtIntrastatComputeRequestTransportModeSerializer
        : JsonConverter<PostV1DeclarationsLtIntrastatComputeRequestTransportMode>
    {
        public override PostV1DeclarationsLtIntrastatComputeRequestTransportMode Read(
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
            return new PostV1DeclarationsLtIntrastatComputeRequestTransportMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsLtIntrastatComputeRequestTransportMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsLtIntrastatComputeRequestTransportMode ReadAsPropertyName(
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
            return new PostV1DeclarationsLtIntrastatComputeRequestTransportMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsLtIntrastatComputeRequestTransportMode value,
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
        public const string One = "1";

        public const string Two = "2";

        public const string Three = "3";

        public const string Four = "4";

        public const string Five = "5";

        public const string Seven = "7";

        public const string Eight = "8";

        public const string Nine = "9";
    }
}
