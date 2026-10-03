using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType.PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType
    : IStringEnum
{
    public static readonly PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType ManagingCurrent =
        new(Values.ManagingCurrent);

    public static readonly PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType ManagingFormer =
        new(Values.ManagingFormer);

    public static readonly PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType SupervisoryCurrent =
        new(Values.SupervisoryCurrent);

    public static readonly PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType SupervisoryFormer =
        new(Values.SupervisoryFormer);

    public PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType(string value)
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
    public static PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType(value);
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
        PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType(
        string value
    ) => new(value);

    internal class PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorTypeSerializer
        : JsonConverter<PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType>
    {
        public override PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType Read(
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
            return new PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType ReadAsPropertyName(
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
            return new PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsAnnualAccountsSignaturesCreateRequestDirectorType value,
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
        public const string ManagingCurrent = "managing_current";

        public const string ManagingFormer = "managing_former";

        public const string SupervisoryCurrent = "supervisory_current";

        public const string SupervisoryFormer = "supervisory_former";
    }
}
