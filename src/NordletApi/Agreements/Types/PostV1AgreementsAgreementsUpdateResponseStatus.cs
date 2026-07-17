using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AgreementsAgreementsUpdateResponseStatus.PostV1AgreementsAgreementsUpdateResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1AgreementsAgreementsUpdateResponseStatus : IStringEnum
{
    public static readonly PostV1AgreementsAgreementsUpdateResponseStatus Draft = new(Values.Draft);

    public static readonly PostV1AgreementsAgreementsUpdateResponseStatus Active = new(
        Values.Active
    );

    public static readonly PostV1AgreementsAgreementsUpdateResponseStatus Expired = new(
        Values.Expired
    );

    public static readonly PostV1AgreementsAgreementsUpdateResponseStatus Terminated = new(
        Values.Terminated
    );

    public PostV1AgreementsAgreementsUpdateResponseStatus(string value)
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
    public static PostV1AgreementsAgreementsUpdateResponseStatus FromCustom(string value)
    {
        return new PostV1AgreementsAgreementsUpdateResponseStatus(value);
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
        PostV1AgreementsAgreementsUpdateResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AgreementsAgreementsUpdateResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AgreementsAgreementsUpdateResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1AgreementsAgreementsUpdateResponseStatus(string value) =>
        new(value);

    internal class PostV1AgreementsAgreementsUpdateResponseStatusSerializer
        : JsonConverter<PostV1AgreementsAgreementsUpdateResponseStatus>
    {
        public override PostV1AgreementsAgreementsUpdateResponseStatus Read(
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
            return new PostV1AgreementsAgreementsUpdateResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AgreementsAgreementsUpdateResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AgreementsAgreementsUpdateResponseStatus ReadAsPropertyName(
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
            return new PostV1AgreementsAgreementsUpdateResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AgreementsAgreementsUpdateResponseStatus value,
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
        public const string Draft = "draft";

        public const string Active = "active";

        public const string Expired = "expired";

        public const string Terminated = "terminated";
    }
}
