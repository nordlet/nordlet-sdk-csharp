using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AnnualAccountsSetDeclarationsResponseAttachmentsItemKind.AnnualAccountsSetDeclarationsResponseAttachmentsItemKindSerializer)
)]
[Serializable]
public readonly record struct AnnualAccountsSetDeclarationsResponseAttachmentsItemKind : IStringEnum
{
    public static readonly AnnualAccountsSetDeclarationsResponseAttachmentsItemKind FullReport =
        new(Values.FullReport);

    public static readonly AnnualAccountsSetDeclarationsResponseAttachmentsItemKind Notes = new(
        Values.Notes
    );

    public static readonly AnnualAccountsSetDeclarationsResponseAttachmentsItemKind ManagementReport =
        new(Values.ManagementReport);

    public static readonly AnnualAccountsSetDeclarationsResponseAttachmentsItemKind AuditorStatement =
        new(Values.AuditorStatement);

    public static readonly AnnualAccountsSetDeclarationsResponseAttachmentsItemKind AppropriationResolution =
        new(Values.AppropriationResolution);

    public static readonly AnnualAccountsSetDeclarationsResponseAttachmentsItemKind ApprovalCertificate =
        new(Values.ApprovalCertificate);

    public static readonly AnnualAccountsSetDeclarationsResponseAttachmentsItemKind GeneralDataSheet =
        new(Values.GeneralDataSheet);

    public static readonly AnnualAccountsSetDeclarationsResponseAttachmentsItemKind Other = new(
        Values.Other
    );

    public AnnualAccountsSetDeclarationsResponseAttachmentsItemKind(string value)
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
    public static AnnualAccountsSetDeclarationsResponseAttachmentsItemKind FromCustom(string value)
    {
        return new AnnualAccountsSetDeclarationsResponseAttachmentsItemKind(value);
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
        AnnualAccountsSetDeclarationsResponseAttachmentsItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnualAccountsSetDeclarationsResponseAttachmentsItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnualAccountsSetDeclarationsResponseAttachmentsItemKind value
    ) => value.Value;

    public static explicit operator AnnualAccountsSetDeclarationsResponseAttachmentsItemKind(
        string value
    ) => new(value);

    internal class AnnualAccountsSetDeclarationsResponseAttachmentsItemKindSerializer
        : JsonConverter<AnnualAccountsSetDeclarationsResponseAttachmentsItemKind>
    {
        public override AnnualAccountsSetDeclarationsResponseAttachmentsItemKind Read(
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
            return new AnnualAccountsSetDeclarationsResponseAttachmentsItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnualAccountsSetDeclarationsResponseAttachmentsItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnualAccountsSetDeclarationsResponseAttachmentsItemKind ReadAsPropertyName(
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
            return new AnnualAccountsSetDeclarationsResponseAttachmentsItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnualAccountsSetDeclarationsResponseAttachmentsItemKind value,
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
