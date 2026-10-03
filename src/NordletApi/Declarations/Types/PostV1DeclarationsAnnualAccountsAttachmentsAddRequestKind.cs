using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind.PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKindSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind
    : IStringEnum
{
    public static readonly PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind FullReport =
        new(Values.FullReport);

    public static readonly PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind Notes = new(
        Values.Notes
    );

    public static readonly PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind ManagementReport =
        new(Values.ManagementReport);

    public static readonly PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind AuditorStatement =
        new(Values.AuditorStatement);

    public static readonly PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind AppropriationResolution =
        new(Values.AppropriationResolution);

    public static readonly PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind ApprovalCertificate =
        new(Values.ApprovalCertificate);

    public static readonly PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind GeneralDataSheet =
        new(Values.GeneralDataSheet);

    public static readonly PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind Other = new(
        Values.Other
    );

    public PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind(string value)
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
    public static PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind FromCustom(string value)
    {
        return new PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind(value);
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
        PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind(
        string value
    ) => new(value);

    internal class PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKindSerializer
        : JsonConverter<PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind>
    {
        public override PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind Read(
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
            return new PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind ReadAsPropertyName(
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
            return new PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsAnnualAccountsAttachmentsAddRequestKind value,
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
        public const string FullReport = "full_report";

        public const string Notes = "notes";

        public const string ManagementReport = "management_report";

        public const string AuditorStatement = "auditor_statement";

        public const string AppropriationResolution = "appropriation_resolution";

        public const string ApprovalCertificate = "approval_certificate";

        public const string GeneralDataSheet = "general_data_sheet";

        public const string Other = "other";
    }
}
