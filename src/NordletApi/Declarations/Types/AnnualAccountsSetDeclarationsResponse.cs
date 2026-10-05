using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AnnualAccountsSetDeclarationsResponse : IJsonOnDeserialized
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
    public DateOnly? AdoptionDate { get; set; }

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
    public DateOnly? AuditorReportDate { get; set; }

    [JsonPropertyName("resultToReserves")]
    public string? ResultToReserves { get; set; }

    [JsonPropertyName("resultToLossCompensation")]
    public string? ResultToLossCompensation { get; set; }

    [JsonPropertyName("resultToRemainder")]
    public string? ResultToRemainder { get; set; }

    [JsonPropertyName("signatures")]
    public IEnumerable<AnnualAccountsSetDeclarationsResponseSignaturesItem> Signatures { get; set; } =
        new List<AnnualAccountsSetDeclarationsResponseSignaturesItem>();

    [JsonPropertyName("distributions")]
    public IEnumerable<AnnualAccountsSetDeclarationsResponseDistributionsItem> Distributions { get; set; } =
        new List<AnnualAccountsSetDeclarationsResponseDistributionsItem>();

    [JsonPropertyName("attachments")]
    public IEnumerable<AnnualAccountsSetDeclarationsResponseAttachmentsItem> Attachments { get; set; } =
        new List<AnnualAccountsSetDeclarationsResponseAttachmentsItem>();

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
