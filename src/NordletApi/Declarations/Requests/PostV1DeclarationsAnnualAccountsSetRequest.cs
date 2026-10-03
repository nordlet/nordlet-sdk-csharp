using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsAnnualAccountsSetRequest
{
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("adopted")]
    public required bool Adopted { get; set; }

    [JsonPropertyName("adoptionDate")]
    public string? AdoptionDate { get; set; }

    [JsonPropertyName("dateOfPreparation")]
    public required string DateOfPreparation { get; set; }

    [JsonPropertyName("audited")]
    public bool? Audited { get; set; }

    [JsonPropertyName("auditReportQualified")]
    public bool? AuditReportQualified { get; set; }

    [JsonPropertyName("auditorNotElected")]
    public bool? AuditorNotElected { get; set; }

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

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
