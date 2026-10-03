using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType.PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorTypeSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType
    : IStringEnum
{
    public static readonly PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType ManagingCurrent =
        new(Values.ManagingCurrent);

    public static readonly PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType ManagingFormer =
        new(Values.ManagingFormer);

    public static readonly PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType SupervisoryCurrent =
        new(Values.SupervisoryCurrent);

    public static readonly PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType SupervisoryFormer =
        new(Values.SupervisoryFormer);

    public PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType(string value)
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
    public static PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType(value);
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
        PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType(
        string value
    ) => new(value);

    internal class PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorTypeSerializer
        : JsonConverter<PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType>
    {
        public override PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType Read(
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
            return new PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType ReadAsPropertyName(
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
            return new PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsAnnualAccountsSignaturesUpdateResponseDirectorType value,
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
