using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(InquiriesListPartnersResponseRowsItemStatus.InquiriesListPartnersResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct InquiriesListPartnersResponseRowsItemStatus : IStringEnum
{
    public static readonly InquiriesListPartnersResponseRowsItemStatus New = new(Values.New);

    public static readonly InquiriesListPartnersResponseRowsItemStatus InProgress = new(
        Values.InProgress
    );

    public static readonly InquiriesListPartnersResponseRowsItemStatus Closed = new(Values.Closed);

    public InquiriesListPartnersResponseRowsItemStatus(string value)
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
    public static InquiriesListPartnersResponseRowsItemStatus FromCustom(string value)
    {
        return new InquiriesListPartnersResponseRowsItemStatus(value);
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
        InquiriesListPartnersResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InquiriesListPartnersResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InquiriesListPartnersResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator InquiriesListPartnersResponseRowsItemStatus(string value) =>
        new(value);

    internal class InquiriesListPartnersResponseRowsItemStatusSerializer
        : JsonConverter<InquiriesListPartnersResponseRowsItemStatus>
    {
        public override InquiriesListPartnersResponseRowsItemStatus Read(
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
            return new InquiriesListPartnersResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InquiriesListPartnersResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InquiriesListPartnersResponseRowsItemStatus ReadAsPropertyName(
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
            return new InquiriesListPartnersResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InquiriesListPartnersResponseRowsItemStatus value,
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
