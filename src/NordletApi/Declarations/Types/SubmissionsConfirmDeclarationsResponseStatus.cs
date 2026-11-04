using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SubmissionsConfirmDeclarationsResponseStatus.SubmissionsConfirmDeclarationsResponseStatusSerializer)
)]
[Serializable]
public readonly record struct SubmissionsConfirmDeclarationsResponseStatus : IStringEnum
{
    public static readonly SubmissionsConfirmDeclarationsResponseStatus Generated = new(
        Values.Generated
    );

    public static readonly SubmissionsConfirmDeclarationsResponseStatus Submitted = new(
        Values.Submitted
    );

    public static readonly SubmissionsConfirmDeclarationsResponseStatus Accepted = new(
        Values.Accepted
    );

    public static readonly SubmissionsConfirmDeclarationsResponseStatus Rejected = new(
        Values.Rejected
    );

    public SubmissionsConfirmDeclarationsResponseStatus(string value)
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
    public static SubmissionsConfirmDeclarationsResponseStatus FromCustom(string value)
    {
        return new SubmissionsConfirmDeclarationsResponseStatus(value);
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
        SubmissionsConfirmDeclarationsResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SubmissionsConfirmDeclarationsResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SubmissionsConfirmDeclarationsResponseStatus value) =>
        value.Value;

    public static explicit operator SubmissionsConfirmDeclarationsResponseStatus(string value) =>
        new(value);

    internal class SubmissionsConfirmDeclarationsResponseStatusSerializer
        : JsonConverter<SubmissionsConfirmDeclarationsResponseStatus>
    {
        public override SubmissionsConfirmDeclarationsResponseStatus Read(
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
            return new SubmissionsConfirmDeclarationsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubmissionsConfirmDeclarationsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubmissionsConfirmDeclarationsResponseStatus ReadAsPropertyName(
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
            return new SubmissionsConfirmDeclarationsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubmissionsConfirmDeclarationsResponseStatus value,
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
