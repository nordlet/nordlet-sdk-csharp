using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InquiriesCreatePartnersResponseStatus.InquiriesCreatePartnersResponseStatusSerializer)
)]
[Serializable]
public readonly record struct InquiriesCreatePartnersResponseStatus : IStringEnum
{
    public static readonly InquiriesCreatePartnersResponseStatus New = new(Values.New);

    public static readonly InquiriesCreatePartnersResponseStatus InProgress = new(
        Values.InProgress
    );

    public static readonly InquiriesCreatePartnersResponseStatus Closed = new(Values.Closed);

    public InquiriesCreatePartnersResponseStatus(string value)
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
    public static InquiriesCreatePartnersResponseStatus FromCustom(string value)
    {
        return new InquiriesCreatePartnersResponseStatus(value);
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

    public static bool operator ==(InquiriesCreatePartnersResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InquiriesCreatePartnersResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InquiriesCreatePartnersResponseStatus value) =>
        value.Value;

    public static explicit operator InquiriesCreatePartnersResponseStatus(string value) =>
        new(value);

    internal class InquiriesCreatePartnersResponseStatusSerializer
        : JsonConverter<InquiriesCreatePartnersResponseStatus>
    {
        public override InquiriesCreatePartnersResponseStatus Read(
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
            return new InquiriesCreatePartnersResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InquiriesCreatePartnersResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InquiriesCreatePartnersResponseStatus ReadAsPropertyName(
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
            return new InquiriesCreatePartnersResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InquiriesCreatePartnersResponseStatus value,
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
        public const string New = "new";

        public const string InProgress = "in_progress";

        public const string Closed = "closed";
    }
}
