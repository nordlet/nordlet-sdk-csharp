using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsAutomationListResponseRowsItemCertificate.PostV1DeclarationsAutomationListResponseRowsItemCertificateSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsAutomationListResponseRowsItemCertificate
    : IStringEnum
{
    public static readonly PostV1DeclarationsAutomationListResponseRowsItemCertificate Ok = new(
        Values.Ok
    );

    public static readonly PostV1DeclarationsAutomationListResponseRowsItemCertificate Expiring =
        new(Values.Expiring);

    public static readonly PostV1DeclarationsAutomationListResponseRowsItemCertificate Expired =
        new(Values.Expired);

    public static readonly PostV1DeclarationsAutomationListResponseRowsItemCertificate Unknown =
        new(Values.Unknown);

    public static readonly PostV1DeclarationsAutomationListResponseRowsItemCertificate Missing =
        new(Values.Missing);

    public static readonly PostV1DeclarationsAutomationListResponseRowsItemCertificate NotNeeded =
        new(Values.NotNeeded);

    public PostV1DeclarationsAutomationListResponseRowsItemCertificate(string value)
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
    public static PostV1DeclarationsAutomationListResponseRowsItemCertificate FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsAutomationListResponseRowsItemCertificate(value);
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
        PostV1DeclarationsAutomationListResponseRowsItemCertificate value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsAutomationListResponseRowsItemCertificate value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsAutomationListResponseRowsItemCertificate value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsAutomationListResponseRowsItemCertificate(
        string value
    ) => new(value);

    internal class PostV1DeclarationsAutomationListResponseRowsItemCertificateSerializer
        : JsonConverter<PostV1DeclarationsAutomationListResponseRowsItemCertificate>
    {
        public override PostV1DeclarationsAutomationListResponseRowsItemCertificate Read(
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
            return new PostV1DeclarationsAutomationListResponseRowsItemCertificate(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsAutomationListResponseRowsItemCertificate value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsAutomationListResponseRowsItemCertificate ReadAsPropertyName(
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
            return new PostV1DeclarationsAutomationListResponseRowsItemCertificate(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsAutomationListResponseRowsItemCertificate value,
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
        public const string Ok = "ok";

        public const string Expiring = "expiring";

        public const string Expired = "expired";

        public const string Unknown = "unknown";

        public const string Missing = "missing";

        public const string NotNeeded = "not-needed";
    }
}
