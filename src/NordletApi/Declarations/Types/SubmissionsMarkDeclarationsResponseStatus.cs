using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SubmissionsMarkDeclarationsResponseStatus.SubmissionsMarkDeclarationsResponseStatusSerializer)
)]
[Serializable]
public readonly record struct SubmissionsMarkDeclarationsResponseStatus : IStringEnum
{
    public static readonly SubmissionsMarkDeclarationsResponseStatus Generated = new(
        Values.Generated
    );

    public static readonly SubmissionsMarkDeclarationsResponseStatus Submitted = new(
        Values.Submitted
    );

    public static readonly SubmissionsMarkDeclarationsResponseStatus Accepted = new(
        Values.Accepted
    );

    public static readonly SubmissionsMarkDeclarationsResponseStatus Rejected = new(
        Values.Rejected
    );

    public SubmissionsMarkDeclarationsResponseStatus(string value)
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
    public static SubmissionsMarkDeclarationsResponseStatus FromCustom(string value)
    {
        return new SubmissionsMarkDeclarationsResponseStatus(value);
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
        SubmissionsMarkDeclarationsResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SubmissionsMarkDeclarationsResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SubmissionsMarkDeclarationsResponseStatus value) =>
        value.Value;

    public static explicit operator SubmissionsMarkDeclarationsResponseStatus(string value) =>
        new(value);

    internal class SubmissionsMarkDeclarationsResponseStatusSerializer
        : JsonConverter<SubmissionsMarkDeclarationsResponseStatus>
    {
        public override SubmissionsMarkDeclarationsResponseStatus Read(
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
            return new SubmissionsMarkDeclarationsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubmissionsMarkDeclarationsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubmissionsMarkDeclarationsResponseStatus ReadAsPropertyName(
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
            return new SubmissionsMarkDeclarationsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubmissionsMarkDeclarationsResponseStatus value,
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
        public const string Generated = "generated";

        public const string Submitted = "submitted";

        public const string Accepted = "accepted";

        public const string Rejected = "rejected";
    }
}
