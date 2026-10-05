using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EuSmeThresholdGetDeclarationsResponseStatus.EuSmeThresholdGetDeclarationsResponseStatusSerializer)
)]
[Serializable]
public readonly record struct EuSmeThresholdGetDeclarationsResponseStatus : IStringEnum
{
    public static readonly EuSmeThresholdGetDeclarationsResponseStatus NotApplicable = new(
        Values.NotApplicable
    );

    public static readonly EuSmeThresholdGetDeclarationsResponseStatus Below = new(Values.Below);

    public static readonly EuSmeThresholdGetDeclarationsResponseStatus Approaching = new(
        Values.Approaching
    );

    public static readonly EuSmeThresholdGetDeclarationsResponseStatus Exceeded = new(
        Values.Exceeded
    );

    public static readonly EuSmeThresholdGetDeclarationsResponseStatus Unknown = new(
        Values.Unknown
    );

    public EuSmeThresholdGetDeclarationsResponseStatus(string value)
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
    public static EuSmeThresholdGetDeclarationsResponseStatus FromCustom(string value)
    {
        return new EuSmeThresholdGetDeclarationsResponseStatus(value);
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
        EuSmeThresholdGetDeclarationsResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EuSmeThresholdGetDeclarationsResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EuSmeThresholdGetDeclarationsResponseStatus value) =>
        value.Value;

    public static explicit operator EuSmeThresholdGetDeclarationsResponseStatus(string value) =>
        new(value);

    internal class EuSmeThresholdGetDeclarationsResponseStatusSerializer
        : JsonConverter<EuSmeThresholdGetDeclarationsResponseStatus>
    {
        public override EuSmeThresholdGetDeclarationsResponseStatus Read(
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
            return new EuSmeThresholdGetDeclarationsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EuSmeThresholdGetDeclarationsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EuSmeThresholdGetDeclarationsResponseStatus ReadAsPropertyName(
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
            return new EuSmeThresholdGetDeclarationsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EuSmeThresholdGetDeclarationsResponseStatus value,
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
        public const string NotApplicable = "not_applicable";

        public const string Below = "below";

        public const string Approaching = "approaching";

        public const string Exceeded = "exceeded";

        public const string Unknown = "unknown";
    }
}
