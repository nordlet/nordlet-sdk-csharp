namespace NordletApi;

public partial interface IReportsClient
{
    WithRawResponseTask<TrialBalanceReportsResponse> TrialBalanceAsync(
        TrialBalanceReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SizeCategoryReportsResponse> SizeCategoryAsync(
        SizeCategoryReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FinancialStatementsReportsResponse> FinancialStatementsAsync(
        FinancialStatementsReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GeneralJournalReportsResponse> GeneralJournalAsync(
        GeneralJournalReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GlDetailReportsResponse> GlDetailAsync(
        GlDetailReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PartnerBalancesReportsResponse> PartnerBalancesAsync(
        PartnerBalancesReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DebtAgingReportsResponse> DebtAgingAsync(
        DebtAgingReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MonthlySummaryReportsResponse> MonthlySummaryAsync(
        MonthlySummaryReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StockBalanceReportsResponse> StockBalanceAsync(
        StockBalanceReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StockMovementReportsResponse> StockMovementAsync(
        StockMovementReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<VatSummaryReportsResponse> VatSummaryAsync(
        VatSummaryReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CashFlowReportsResponse> CashFlowAsync(
        CashFlowReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StockAgingReportsResponse> StockAgingAsync(
        StockAgingReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StockShortageReportsResponse> StockShortageAsync(
        StockShortageReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Export the ledger of one financial year as an SIE file (the Swedish standard accounting interchange format, specification 4B). The file carries the chart of accounts, the opening and closing balance of every balance sheet account and the turnover of every result account for the year and the year before it, and, when asked for, every posted voucher of the year with its lines. Cost centres travel as dimension 1 and projects as dimension 6. Services that build a Swedish annual report read this file.
    /// </summary>
    WithRawResponseTask<SieReportsResponse> SieAsync(
        SieReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Export the posted ledger of a period as a DATEV Buchungsstapel file (DATEV format, category 21, version 700). Every transaction becomes one or more bookings of an amount between an account and a contra account; a transaction with more than two lines is split into pairs whose totals match it. The file is semicolon separated and written in the Windows-1252 character set DATEV expects.
    /// </summary>
    WithRawResponseTask<DatevReportsResponse> DatevAsync(
        DatevReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Export the posted ledger of a period as a French FEC file (fichier des écritures comptables, order of 29 July 2013). One line per journal entry line, with the eighteen fields the order names, in their order, after a header line. Tab separated, UTF-8, comma as the decimal separator.
    /// </summary>
    WithRawResponseTask<FecReportsResponse> FecAsync(
        FecReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EuPurchasesReportsResponse> EuPurchasesAsync(
        EuPurchasesReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<VatDetailReportsResponse> VatDetailAsync(
        VatDetailReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PosSalesReportsResponse> PosSalesAsync(
        PosSalesReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OnlineSalesReportsResponse> OnlineSalesAsync(
        OnlineSalesReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<OssReportsResponse> OssAsync(
        OssReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AdvanceReconciliationReportsResponse> AdvanceReconciliationAsync(
        AdvanceReconciliationReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<WriteOffActsReportsResponse> WriteOffActsAsync(
        WriteOffActsReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CostCentersReportsResponse> CostCentersAsync(
        CostCentersReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CostCenterActivityReportsResponse> CostCenterActivityAsync(
        CostCenterActivityReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CostCenterItemsReportsResponse> CostCenterItemsAsync(
        CostCenterItemsReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<JobsCreateReportsResponse> JobsCreateAsync(
        JobsCreateReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<JobsGetReportsResponse> JobsGetAsync(
        JobsGetReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<JobsListReportsResponse> JobsListAsync(
        JobsListReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
