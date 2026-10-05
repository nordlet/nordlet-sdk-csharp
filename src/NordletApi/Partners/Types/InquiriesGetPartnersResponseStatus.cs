using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InquiriesGetPartnersResponseStatus.InquiriesGetPartnersResponseStatusSerializer)
)]
[Serializable]
public readonly record struct InquiriesGetPartnersResponseStatus : IStringEnum
{
    public static readonly InquiriesGetPartnersResponseStatus New = new(Values.New);

    public static readonly InquiriesGetPartnersResponseStatus InProgress = new(Values.InProgress);

    public static readonly InquiriesGetPartnersResponseStatus Closed = new(Values.Closed);

    public InquiriesGetPartnersResponseStatus(string value)
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
    public static InquiriesGetPartnersResponseStatus FromCustom(string value)
    {
        return new InquiriesGetPartnersResponseStatus(value);
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

    public static bool operator ==(InquiriesGetPartnersResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InquiriesGetPartnersResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InquiriesGetPartnersResponseStatus value) => value.Value;

    public static explicit operator InquiriesGetPartnersResponseStatus(string value) => new(value);

    internal class InquiriesGetPartnersResponseStatusSerializer
        : JsonConverter<InquiriesGetPartnersResponseStatus>
    {
        public override InquiriesGetPartnersResponseStatus Read(
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
            return new InquiriesGetPartnersResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InquiriesGetPartnersResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InquiriesGetPartnersResponseStatus ReadAsPropertyName(
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
            return new InquiriesGetPartnersResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InquiriesGetPartnersResponseStatus value,
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
