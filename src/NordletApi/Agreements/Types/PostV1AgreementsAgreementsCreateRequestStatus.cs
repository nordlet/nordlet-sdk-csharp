using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AgreementsAgreementsCreateRequestStatus.PostV1AgreementsAgreementsCreateRequestStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1AgreementsAgreementsCreateRequestStatus : IStringEnum
{
    public static readonly PostV1AgreementsAgreementsCreateRequestStatus Draft = new(Values.Draft);

    public static readonly PostV1AgreementsAgreementsCreateRequestStatus Active = new(
        Values.Active
    );

    public static readonly PostV1AgreementsAgreementsCreateRequestStatus Expired = new(
        Values.Expired
    );

    public static readonly PostV1AgreementsAgreementsCreateRequestStatus Terminated = new(
        Values.Terminated
    );

    public PostV1AgreementsAgreementsCreateRequestStatus(string value)
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
    public static PostV1AgreementsAgreementsCreateRequestStatus FromCustom(string value)
    {
        return new PostV1AgreementsAgreementsCreateRequestStatus(value);
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
        PostV1AgreementsAgreementsCreateRequestStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AgreementsAgreementsCreateRequestStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AgreementsAgreementsCreateRequestStatus value) =>
        value.Value;

    public static explicit operator PostV1AgreementsAgreementsCreateRequestStatus(string value) =>
        new(value);

    internal class PostV1AgreementsAgreementsCreateRequestStatusSerializer
        : JsonConverter<PostV1AgreementsAgreementsCreateRequestStatus>
    {
        public override PostV1AgreementsAgreementsCreateRequestStatus Read(
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
            return new PostV1AgreementsAgreementsCreateRequestStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AgreementsAgreementsCreateRequestStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AgreementsAgreementsCreateRequestStatus ReadAsPropertyName(
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
            return new PostV1AgreementsAgreementsCreateRequestStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AgreementsAgreementsCreateRequestStatus value,
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
