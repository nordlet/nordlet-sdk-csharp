using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind.AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKindSerializer)
)]
[Serializable]
public readonly record struct AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind
    : IStringEnum
{
    public static readonly AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind FullReport =
        new(Values.FullReport);

    public static readonly AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind Notes =
        new(Values.Notes);

    public static readonly AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind ManagementReport =
        new(Values.ManagementReport);

    public static readonly AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind AuditorStatement =
        new(Values.AuditorStatement);

    public static readonly AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind AppropriationResolution =
        new(Values.AppropriationResolution);

    public static readonly AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind ApprovalCertificate =
        new(Values.ApprovalCertificate);

    public static readonly AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind GeneralDataSheet =
        new(Values.GeneralDataSheet);

    public static readonly AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind Other =
        new(Values.Other);

    public AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind(string value)
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
    public static AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind FromCustom(
        string value
    )
    {
        return new AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind(value);
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
        AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind value
    ) => value.Value;

    public static explicit operator AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind(
        string value
    ) => new(value);

    internal class AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKindSerializer
        : JsonConverter<AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind>
    {
        public override AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind Read(
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
            return new AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind ReadAsPropertyName(
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
            return new AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnualAccountsGetDeclarationsResponseApprovalAttachmentsItemKind value,
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
