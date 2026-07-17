using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ConsolidationReportResponseMembersItemMethod.PostV1ConsolidationReportResponseMembersItemMethodSerializer)
)]
[Serializable]
public readonly record struct PostV1ConsolidationReportResponseMembersItemMethod : IStringEnum
{
    public static readonly PostV1ConsolidationReportResponseMembersItemMethod Full = new(
        Values.Full
    );

    public static readonly PostV1ConsolidationReportResponseMembersItemMethod Proportional = new(
        Values.Proportional
    );

    public static readonly PostV1ConsolidationReportResponseMembersItemMethod Equity = new(
        Values.Equity
    );

    public PostV1ConsolidationReportResponseMembersItemMethod(string value)
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
    public static PostV1ConsolidationReportResponseMembersItemMethod FromCustom(string value)
    {
        return new PostV1ConsolidationReportResponseMembersItemMethod(value);
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
        PostV1ConsolidationReportResponseMembersItemMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ConsolidationReportResponseMembersItemMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1ConsolidationReportResponseMembersItemMethod value
    ) => value.Value;

    public static explicit operator PostV1ConsolidationReportResponseMembersItemMethod(
        string value
    ) => new(value);

    internal class PostV1ConsolidationReportResponseMembersItemMethodSerializer
        : JsonConverter<PostV1ConsolidationReportResponseMembersItemMethod>
    {
        public override PostV1ConsolidationReportResponseMembersItemMethod Read(
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
            return new PostV1ConsolidationReportResponseMembersItemMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ConsolidationReportResponseMembersItemMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ConsolidationReportResponseMembersItemMethod ReadAsPropertyName(
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
            return new PostV1ConsolidationReportResponseMembersItemMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ConsolidationReportResponseMembersItemMethod value,
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
        public const string Full = "full";

        public const string Proportional = "proportional";

        public const string Equity = "equity";
    }
}
