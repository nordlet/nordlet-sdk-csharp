using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EeTsdAnnexesSetDeclarationsResponseInputAnnex5 : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// 5000: gifts and donations of the month, except those of 5010
    /// </summary>
    [JsonPropertyName("gifts")]
    public string? Gifts { get; set; }

    /// <summary>
    /// 5010: gifts and donations of the month to persons on the TuMS § 11 lg 1 list or § 11 lg 10 associations (0 when none)
    /// </summary>
    [JsonPropertyName("giftsToListedPersons")]
    public string? GiftsToListedPersons { get; set; }

    /// <summary>
    /// TuMS § 49 lg 2 limit used this month for 5020: `socialTax` 3 % of the personalised social-taxed payments of the year (5030), `profit` 10 % of the last financial year’s profit (5040, 5050); the choice of December is final
    /// </summary>
    [JsonPropertyName("limit")]
    public EeTsdAnnexesSetDeclarationsResponseInputAnnex5Limit? Limit { get; set; }

    /// <summary>
    /// 5040: profit of the last financial year ended by 1 January, own profit only (0 for a loss); needed with `profit`
    /// </summary>
    [JsonPropertyName("lastYearProfit")]
    public string? LastYearProfit { get; set; }

    /// <summary>
    /// 5100: costs of the month for food, transport, accommodation or entertainment of guests or partners (0 to use the cumulative recalculation without spending)
    /// </summary>
    [JsonPropertyName("entertainment")]
    public string? Entertainment { get; set; }

    /// <summary>
    /// 5180: part II, taxable gifts and donations of a person on the TuMS § 11 lg 1 list; excludes the part I fields
    /// </summary>
    [JsonPropertyName("listedPersonTaxableGifts")]
    public string? ListedPersonTaxableGifts { get; set; }

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
