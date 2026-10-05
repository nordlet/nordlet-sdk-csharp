using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SubmissionsMarkDeclarationsRequestStatus.SubmissionsMarkDeclarationsRequestStatusSerializer)
)]
[Serializable]
public readonly record struct SubmissionsMarkDeclarationsRequestStatus : IStringEnum
{
    public static readonly SubmissionsMarkDeclarationsRequestStatus Submitted = new(
        Values.Submitted
    );

    public static readonly SubmissionsMarkDeclarationsRequestStatus Accepted = new(Values.Accepted);

    public static readonly SubmissionsMarkDeclarationsRequestStatus Rejected = new(Values.Rejected);

    public SubmissionsMarkDeclarationsRequestStatus(string value)
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
    public static SubmissionsMarkDeclarationsRequestStatus FromCustom(string value)
    {
        return new SubmissionsMarkDeclarationsRequestStatus(value);
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
        SubmissionsMarkDeclarationsRequestStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SubmissionsMarkDeclarationsRequestStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SubmissionsMarkDeclarationsRequestStatus value) =>
        value.Value;

    public static explicit operator SubmissionsMarkDeclarationsRequestStatus(string value) =>
        new(value);

    internal class SubmissionsMarkDeclarationsRequestStatusSerializer
        : JsonConverter<SubmissionsMarkDeclarationsRequestStatus>
    {
        public override SubmissionsMarkDeclarationsRequestStatus Read(
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
            return new SubmissionsMarkDeclarationsRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubmissionsMarkDeclarationsRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubmissionsMarkDeclarationsRequestStatus ReadAsPropertyName(
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
            return new SubmissionsMarkDeclarationsRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubmissionsMarkDeclarationsRequestStatus value,
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
        public const string Submitted = "submitted";

        public const string Accepted = "accepted";

        public const string Rejected = "rejected";
    }
}
