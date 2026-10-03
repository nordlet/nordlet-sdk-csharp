using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType.PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType
    : IStringEnum
{
    public static readonly PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType ManagingCurrent =
        new(Values.ManagingCurrent);

    public static readonly PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType ManagingFormer =
        new(Values.ManagingFormer);

    public static readonly PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType SupervisoryCurrent =
        new(Values.SupervisoryCurrent);

    public static readonly PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType SupervisoryFormer =
        new(Values.SupervisoryFormer);

    public PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType(string value)
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
    public static PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType(value);
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
        PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType(
        string value
    ) => new(value);

    internal class PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorTypeSerializer
        : JsonConverter<PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType>
    {
        public override PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType Read(
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
            return new PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType ReadAsPropertyName(
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
            return new PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsAnnualAccountsSignaturesCreateResponseDirectorType value,
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
