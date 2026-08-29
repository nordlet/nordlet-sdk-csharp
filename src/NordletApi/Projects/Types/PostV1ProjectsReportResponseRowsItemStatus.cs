using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1ProjectsReportResponseRowsItemStatus.PostV1ProjectsReportResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1ProjectsReportResponseRowsItemStatus : IStringEnum
{
    public static readonly PostV1ProjectsReportResponseRowsItemStatus Active = new(Values.Active);

    public static readonly PostV1ProjectsReportResponseRowsItemStatus Completed = new(
        Values.Completed
    );

    public static readonly PostV1ProjectsReportResponseRowsItemStatus Archived = new(
        Values.Archived
    );

    public PostV1ProjectsReportResponseRowsItemStatus(string value)
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
    public static PostV1ProjectsReportResponseRowsItemStatus FromCustom(string value)
    {
        return new PostV1ProjectsReportResponseRowsItemStatus(value);
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
        PostV1ProjectsReportResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1ProjectsReportResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1ProjectsReportResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator PostV1ProjectsReportResponseRowsItemStatus(string value) =>
        new(value);

    internal class PostV1ProjectsReportResponseRowsItemStatusSerializer
        : JsonConverter<PostV1ProjectsReportResponseRowsItemStatus>
    {
        public override PostV1ProjectsReportResponseRowsItemStatus Read(
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
            return new PostV1ProjectsReportResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1ProjectsReportResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1ProjectsReportResponseRowsItemStatus ReadAsPropertyName(
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
            return new PostV1ProjectsReportResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1ProjectsReportResponseRowsItemStatus value,
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
        public const string Active = "active";

        public const string Completed = "completed";

        public const string Archived = "archived";
    }
}
