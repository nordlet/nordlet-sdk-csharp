using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AnnualAccountsAttachmentsAddDeclarationsRequestKind.AnnualAccountsAttachmentsAddDeclarationsRequestKindSerializer)
)]
[Serializable]
public readonly record struct AnnualAccountsAttachmentsAddDeclarationsRequestKind : IStringEnum
{
    public static readonly AnnualAccountsAttachmentsAddDeclarationsRequestKind FullReport = new(
        Values.FullReport
    );

    public static readonly AnnualAccountsAttachmentsAddDeclarationsRequestKind Notes = new(
        Values.Notes
    );

    public static readonly AnnualAccountsAttachmentsAddDeclarationsRequestKind ManagementReport =
        new(Values.ManagementReport);

    public static readonly AnnualAccountsAttachmentsAddDeclarationsRequestKind AuditorStatement =
        new(Values.AuditorStatement);

    public static readonly AnnualAccountsAttachmentsAddDeclarationsRequestKind AppropriationResolution =
        new(Values.AppropriationResolution);

    public static readonly AnnualAccountsAttachmentsAddDeclarationsRequestKind ApprovalCertificate =
        new(Values.ApprovalCertificate);

    public static readonly AnnualAccountsAttachmentsAddDeclarationsRequestKind GeneralDataSheet =
        new(Values.GeneralDataSheet);

    public static readonly AnnualAccountsAttachmentsAddDeclarationsRequestKind Other = new(
        Values.Other
    );

    public AnnualAccountsAttachmentsAddDeclarationsRequestKind(string value)
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
    public static AnnualAccountsAttachmentsAddDeclarationsRequestKind FromCustom(string value)
    {
        return new AnnualAccountsAttachmentsAddDeclarationsRequestKind(value);
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
        AnnualAccountsAttachmentsAddDeclarationsRequestKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnualAccountsAttachmentsAddDeclarationsRequestKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnualAccountsAttachmentsAddDeclarationsRequestKind value
    ) => value.Value;

    public static explicit operator AnnualAccountsAttachmentsAddDeclarationsRequestKind(
        string value
    ) => new(value);

    internal class AnnualAccountsAttachmentsAddDeclarationsRequestKindSerializer
        : JsonConverter<AnnualAccountsAttachmentsAddDeclarationsRequestKind>
    {
        public override AnnualAccountsAttachmentsAddDeclarationsRequestKind Read(
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
            return new AnnualAccountsAttachmentsAddDeclarationsRequestKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnualAccountsAttachmentsAddDeclarationsRequestKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnualAccountsAttachmentsAddDeclarationsRequestKind ReadAsPropertyName(
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
            return new AnnualAccountsAttachmentsAddDeclarationsRequestKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnualAccountsAttachmentsAddDeclarationsRequestKind value,
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
