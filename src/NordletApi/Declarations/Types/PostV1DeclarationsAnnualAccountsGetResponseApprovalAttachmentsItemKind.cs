using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind.PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKindSerializer)
)]
[Serializable]
public readonly record struct PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind
    : IStringEnum
{
    public static readonly PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind FullReport =
        new(Values.FullReport);

    public static readonly PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind Notes =
        new(Values.Notes);

    public static readonly PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind ManagementReport =
        new(Values.ManagementReport);

    public static readonly PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind AuditorStatement =
        new(Values.AuditorStatement);

    public static readonly PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind AppropriationResolution =
        new(Values.AppropriationResolution);

    public static readonly PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind ApprovalCertificate =
        new(Values.ApprovalCertificate);

    public static readonly PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind GeneralDataSheet =
        new(Values.GeneralDataSheet);

    public static readonly PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind Other =
        new(Values.Other);

    public PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind(string value)
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
    public static PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind FromCustom(
        string value
    )
    {
        return new PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind(value);
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
        PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind value
    ) => value.Value;

    public static explicit operator PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind(
        string value
    ) => new(value);

    internal class PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKindSerializer
        : JsonConverter<PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind>
    {
        public override PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind Read(
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
            return new PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind ReadAsPropertyName(
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
            return new PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItemKind value,
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
