using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate.PostV1DeclarationsAutomationUpdateResponseRowsItemCertificateSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate
    : IStringEnum
{
    public static readonly PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate Ok = new(
        Values.Ok
    );

    public static readonly PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate Expiring =
        new(Values.Expiring);

    public static readonly PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate Expired =
        new(Values.Expired);

    public static readonly PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate Unknown =
        new(Values.Unknown);

    public static readonly PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate Missing =
        new(Values.Missing);

    public static readonly PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate NotNeeded =
        new(Values.NotNeeded);

    public PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate(string value)
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
    public static PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate(value);
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
        PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate(
        string value
    ) => new(value);

    internal class PostV1DeclarationsAutomationUpdateResponseRowsItemCertificateSerializer
        : JsonConverter<PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate>
    {
        public override PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate Read(
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
            return new PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate ReadAsPropertyName(
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
            return new PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsAutomationUpdateResponseRowsItemCertificate value,
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
