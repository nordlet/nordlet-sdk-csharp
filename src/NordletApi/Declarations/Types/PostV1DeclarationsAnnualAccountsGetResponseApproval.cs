using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsAnnualAccountsGetResponseApproval : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("adopted")]
    public required bool Adopted { get; set; }

    [JsonPropertyName("adoptionDate")]
    public string? AdoptionDate { get; set; }

    [JsonPropertyName("dateOfPreparation")]
    public required string DateOfPreparation { get; set; }

    [JsonPropertyName("audited")]
    public required bool Audited { get; set; }

    [JsonPropertyName("auditReportQualified")]
    public bool? AuditReportQualified { get; set; }

    [JsonPropertyName("auditorNotElected")]
    public required bool AuditorNotElected { get; set; }

    [JsonPropertyName("notesText")]
    public string? NotesText { get; set; }

    [JsonPropertyName("managementReportText")]
    public string? ManagementReportText { get; set; }

    [JsonPropertyName("auditorReportText")]
    public string? AuditorReportText { get; set; }

    [JsonPropertyName("auditorReportDate")]
    public string? AuditorReportDate { get; set; }

    [JsonPropertyName("resultToReserves")]
    public string? ResultToReserves { get; set; }

    [JsonPropertyName("resultToLossCompensation")]
    public string? ResultToLossCompensation { get; set; }

    [JsonPropertyName("resultToRemainder")]
    public string? ResultToRemainder { get; set; }

    [JsonPropertyName("signatures")]
    public IEnumerable<PostV1DeclarationsAnnualAccountsGetResponseApprovalSignaturesItem> Signatures { get; set; } =
        new List<PostV1DeclarationsAnnualAccountsGetResponseApprovalSignaturesItem>();

    [JsonPropertyName("distributions")]
    public IEnumerable<PostV1DeclarationsAnnualAccountsGetResponseApprovalDistributionsItem> Distributions { get; set; } =
        new List<PostV1DeclarationsAnnualAccountsGetResponseApprovalDistributionsItem>();

    [JsonPropertyName("attachments")]
    public IEnumerable<PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItem> Attachments { get; set; } =
        new List<PostV1DeclarationsAnnualAccountsGetResponseApprovalAttachmentsItem>();

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
