using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AccountMeResponseCompaniesItemStatus.PostV1AccountMeResponseCompaniesItemStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1AccountMeResponseCompaniesItemStatus : IStringEnum
{
    public static readonly PostV1AccountMeResponseCompaniesItemStatus Active = new(Values.Active);

    public static readonly PostV1AccountMeResponseCompaniesItemStatus Archived = new(
        Values.Archived
    );

    public static readonly PostV1AccountMeResponseCompaniesItemStatus Deleted = new(Values.Deleted);

    public PostV1AccountMeResponseCompaniesItemStatus(string value)
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
    public static PostV1AccountMeResponseCompaniesItemStatus FromCustom(string value)
    {
        return new PostV1AccountMeResponseCompaniesItemStatus(value);
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
        PostV1AccountMeResponseCompaniesItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AccountMeResponseCompaniesItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AccountMeResponseCompaniesItemStatus value) =>
        value.Value;

    public static explicit operator PostV1AccountMeResponseCompaniesItemStatus(string value) =>
        new(value);

    internal class PostV1AccountMeResponseCompaniesItemStatusSerializer
        : JsonConverter<PostV1AccountMeResponseCompaniesItemStatus>
    {
        public override PostV1AccountMeResponseCompaniesItemStatus Read(
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
            return new PostV1AccountMeResponseCompaniesItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AccountMeResponseCompaniesItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AccountMeResponseCompaniesItemStatus ReadAsPropertyName(
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
            return new PostV1AccountMeResponseCompaniesItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AccountMeResponseCompaniesItemStatus value,
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

        public const string Archived = "archived";

        public const string Deleted = "deleted";
    }
}
