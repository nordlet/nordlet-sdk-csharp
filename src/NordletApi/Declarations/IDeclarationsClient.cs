namespace NordletApi;

public partial interface IDeclarationsClient
{
    /// <summary>
    /// Builds the Lithuanian Intrastat report of a month for one flow as the IDAIS INTRASTATReportSubmission XML: dispatches from the issued sale invoices and purchase credit notes, arrivals from the registered purchase invoices and sale credit notes, grouped into report items. `transactionNature`, `deliveryTerms`, `transportMode` and `regionCode` are the defaults for lines without their own values; `statisticalValueRequired` adds the statistical value to each item. Answers 422 when the company is not a VAT payer. With `persist`, the file is stored and a submission for `lt-intrastat-arrivals` or `lt-intrastat-dispatches` is created.
    /// </summary>
    WithRawResponseTask<LtIntrastatComputeDeclarationsResponse> LtIntrastatComputeAsync(
        LtIntrastatComputeDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Builds the i.VAZ transport document message (iVAZ1.3.3) for up to 100 issued waybills and returns the XML. Answers 422 when the registration code of the company is not numeric or when a waybill is not issued. With `persist`, the file is stored and a submission for `lt-ivaz` is created.
    /// </summary>
    WithRawResponseTask<LtIvazGenerateDeclarationsResponse> LtIvazGenerateAsync(
        LtIvazGenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Checks the Intrastat reporting obligation of a year per flow: the value of goods traded with other Member States in the previous year, the month from which reporting is due (January when that value already passed the reporting threshold, else the month the cumulative value of the year passes it), whether the statistical value is required, and the monthly values. Answers 422 when no thresholds are stored for the year.
    /// </summary>
    WithRawResponseTask<LtIntrastatObligationDeclarationsResponse> LtIntrastatObligationAsync(
        LtIntrastatObligationDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Builds the Lithuanian i.SAF register XML of a month: `dataType` F covers both registers, S the issued sale invoices only, P the registered purchase invoices only. Returns the XML without storing it; `declarations/submissions/create` stores it as a submission.
    /// </summary>
    WithRawResponseTask<LtIsafGenerateDeclarationsResponse> LtIsafGenerateAsync(
        LtIsafGenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Computes the fields of the Lithuanian VAT return FR0600 for the period of `months` months starting in `month`, with the breakdown by VAT classifier behind them. `deductionPercent` is the share of input VAT deducted and is written to field 28.
    /// </summary>
    WithRawResponseTask<LtFr0600ComputeDeclarationsResponse> LtFr0600ComputeAsync(
        LtFr0600ComputeDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Computes fields 5 to 7 of the monthly GPM313 from the payroll run of the month the pay was earned: the run of the previous month with `payoutTiming` `next-month`, the run of the same month with `same-month`. `paymentDay` decides whether the withheld tax goes to field 6 (paid by the 15th) or field 7 (after it). Fields 8 to 12 are returned as zero.
    /// </summary>
    WithRawResponseTask<LtGpm313ComputeDeclarationsResponse> LtGpm313ComputeAsync(
        LtGpm313ComputeDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Computes the monthly SAM figures from the payroll run of the month: per employee the insured income, the employee and employer contributions together and the resulting tariff, plus the insured count and the totals. A missing run or a run still in draft is reported in the warnings.
    /// </summary>
    WithRawResponseTask<LtSamComputeDeclarationsResponse> LtSamComputeAsync(
        LtSamComputeDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the rows of the 1-SD (employment contracts that start in the date range) or of the 2-SD (contracts that ended in the range, with the final insured income and contributions from the payroll line of the termination month). Answers 422 when `fromDate` is after `toDate`.
    /// </summary>
    WithRawResponseTask<LtSdGenerateDeclarationsResponse> LtSdGenerateAsync(
        LtSdGenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Builds the Lithuanian SAF-T (version 2.01) XML for a date range: `dataType` F is the full file, GL, SI, PI, PA, MG and AS limit it to the general ledger, sale invoices, purchase invoices, payments, movements of goods or asset transactions. Answers 422 when `fromDate` is after `toDate`. With `persist`, the file is stored and a submission for `lt-saft` is created.
    /// </summary>
    WithRawResponseTask<LtSaftGenerateDeclarationsResponse> LtSaftGenerateAsync(
        LtSaftGenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Builds an i.VAZ amendment message for up to 100 issued waybills, carrying their current data as TransportDocumentAmendment elements. Answers 422 when the registration code of the company is not numeric or when a waybill is not issued. With `persist`, the file is stored and a submission for `lt-ivaz-amendment` is created.
    /// </summary>
    WithRawResponseTask<LtIvazAmendDeclarationsResponse> LtIvazAmendAsync(
        LtIvazAmendDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Builds an i.VAZ cancellation message for up to 100 waybills, each with a cancellation reason code and optional additional information. Answers 422 when the registration code of the company is not numeric; a waybill that was never issued is reported in the warnings. With `persist`, the file is stored and a submission for `lt-ivaz-cancellation` is created.
    /// </summary>
    WithRawResponseTask<LtIvazCancelDeclarationsResponse> LtIvazCancelAsync(
        LtIvazCancelDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Computes the rows of the Lithuanian FR0564 report of a month from the issued sale invoices and credit notes with the `intra_eu_b2b` or `reverse_charge` scheme: one row per buyer VAT number of another Member State, with goods and services split by the type of the catalogue item. Invoices not in EUR and buyers without a valid EU VAT number are left out and named in the warnings; the triangular column is always zero.
    /// </summary>
    WithRawResponseTask<LtFr0564ComputeDeclarationsResponse> LtFr0564ComputeAsync(
        LtFr0564ComputeDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Computes the rows of the annual GPM312 from the payroll runs of the payout months of the year (December of the previous year to November with `payoutTiming` `next-month`, January to December with `same-month`): one row per employee and payment type code, with the amount paid, the tax withheld and the rate applied.
    /// </summary>
    WithRawResponseTask<LtGpm312ComputeDeclarationsResponse> LtGpm312ComputeAsync(
        LtGpm312ComputeDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Computes the boxes of the Lithuanian annual corporate income tax return PLN204 for the fiscal year from the financial statements and the tax adjustments recorded with `declarations/tax-adjustments/create`: the PLN204S annex from the `non_deductible` adjustments and the PLN204Z annex from the `non_taxable_income` ones, by their `code`. The small-entity rate is applied when the size criteria allow it. Answers 422 when such an adjustment has no code or a code the annex does not list, or when no rate table covers the period.
    /// </summary>
    WithRawResponseTask<LtPln204ComputeDeclarationsResponse> LtPln204ComputeAsync(
        LtPln204ComputeDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Computes the Union OSS return of a quarter from the issued invoices and credit notes with the `oss_union` VAT scheme: one row per Member State of consumption and VAT rate, classified as standard or reduced, and a corrections section for the credit notes that credit invoices of earlier periods. Amounts are in EUR, converted at the official rate of the last day of the period. Answers 422 when the company is not established in the EU.
    /// </summary>
    WithRawResponseTask<EuOssComputeDeclarationsResponse> EuOssComputeAsync(
        EuOssComputeDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Computes the IOSS return of a month from the issued invoices and credit notes with the `ioss` VAT scheme, with the same rows, corrections and EUR conversion as `declarations/eu/oss/compute`. Answers 422 when the company is not established in the EU.
    /// </summary>
    WithRawResponseTask<EuIossComputeDeclarationsResponse> EuIossComputeAsync(
        EuIossComputeDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Builds the monthly return of the special scheme for transfers of own goods from the warehouse transfers between warehouses in two different EU Member States: one row per destination and dispatch country with the cost of the goods as the taxable amount in EUR, the transfers behind the rows, and the due date. Answers 422 when the company is not established in the EU.
    /// </summary>
    WithRawResponseTask<EuOwnGoodsTransfersComputeDeclarationsResponse> EuOwnGoodsTransfersComputeAsync(
        EuOwnGoodsTransfersComputeDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the transactions of a date range that fall under EU digital reporting: issued sale invoices and credit notes with the `intra_eu_b2b` or `reverse_charge` scheme to EU customers, and registered purchase invoices from suppliers in other Member States whose lines carry a self-assessed VAT classifier. Each transaction names the article it is reported under, the Member State it is reported to, its deadline and the data still missing. Answers 422 when the company is not identified for VAT in the EU.
    /// </summary>
    WithRawResponseTask<EuDigitalReportingListDeclarationsResponse> EuDigitalReportingListAsync(
        EuDigitalReportingListDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Which platform sellers are reportable for the year (Council Directive (EU) 2021/514, Annex V) and why the others are excluded, the data still missing, and how the company files the report in its Member State.
    /// </summary>
    WithRawResponseTask<EuDac7PreviewDeclarationsResponse> EuDac7PreviewAsync(
        EuDac7PreviewDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Builds the DAC7 (DPI) XML report of a year for the Member State of the company and returns it base64-encoded with the file name the administration expects. Answers 422 when no DAC7 filing channel exists for the company country. The sellers and the missing data behind it come from `declarations/eu/dac7/preview`.
    /// </summary>
    WithRawResponseTask<EuDac7XmlDeclarationsResponse> EuDac7XmlAsync(
        EuDac7XmlDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sums the cross-border sales to EU consumers (invoices under the `oss_union` scheme, and domestic-scheme invoices to partners without a VAT number in another Member State) of the current and the preceding calendar year as of `date` (default: the current date of the company) and compares both with the EUR 10 000 distance sales threshold.
    /// </summary>
    WithRawResponseTask<EuDistanceSalesThresholdGetDeclarationsResponse> EuDistanceSalesThresholdGetAsync(
        EuDistanceSalesThresholdGetDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sums the turnover of the company within the Union (issued invoices and credit notes other than export and out-of-scope supplies) for the current and the previous calendar year as of `date` (default: the current date of the company) and compares it with the EUR 100 000 cap of the cross-border SME scheme. The status is `not_applicable` for a registered VAT payer, otherwise `below`, `approaching` or `exceeded`.
    /// </summary>
    WithRawResponseTask<EuUnionTurnoverGetDeclarationsResponse> EuUnionTurnoverGetAsync(
        EuUnionTurnoverGetDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Builds the quarterly report of the cross-border SME scheme: the value of the issued supplies within the Union per Member State of supply (the VAT country of the invoice, else the country of the partner, else the home country), in the base currency of the company. Supplies that resolve to a non-EU country are left out and named in the warnings.
    /// </summary>
    WithRawResponseTask<EuSmeCrossBorderReportComputeDeclarationsResponse> EuSmeCrossBorderReportComputeAsync(
        EuSmeCrossBorderReportComputeDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the stored table of national SME VAT exemption thresholds per Member State, with sector thresholds and intra-EU acquisition triggers where recorded, and the national and Union-wide caps of the directive. No company data is read.
    /// </summary>
    WithRawResponseTask<EuSmeThresholdsListDeclarationsResponse> EuSmeThresholdsListAsync(
        EuSmeThresholdsListDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Compares the gross turnover of the company in the current calendar year as of `date` (default: the current date of the company) with the national SME exemption threshold of its country. The status is `not_applicable` for a registered VAT payer, `unknown` when no threshold is on file or its currency differs from the base currency, otherwise `below`, `approaching` or `exceeded`; when the country has an intra-EU acquisitions trigger, the acquisitions from and services to other Member States are compared with it too.
    /// </summary>
    WithRawResponseTask<EuSmeThresholdGetDeclarationsResponse> EuSmeThresholdGetAsync(
        EuSmeThresholdGetDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the national VAT return forms Nordlet can compute, with the country, form key, form name, filing frequency and source.
    /// </summary>
    WithRawResponseTask<EuVatReturnPacksListDeclarationsResponse> EuVatReturnPacksListAsync(
        EuVatReturnPacksListDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Computes the national VAT return of `countryCode` for the period of `months` months starting in `month`, as the numbered boxes of the form with labels and amounts. Answers 422 when no return pack is registered for the country; the packs are listed by `declarations/eu/vat-return/packs/list`.
    /// </summary>
    WithRawResponseTask<EuVatReturnComputeDeclarationsResponse> EuVatReturnComputeAsync(
        EuVatReturnComputeDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generate the Polish JPK_V7M(3) file (VAT declaration with evidence) for a month, per the MF schema in force since February 2026. Amounts must already be in PLN; rows are marked BFK until a KSeF integration supplies invoice numbers. Review the warnings before submitting via e-dokumenty.mf.gov.pl.
    /// </summary>
    WithRawResponseTask<PlJpkV7MGenerateDeclarationsResponse> PlJpkV7MGenerateAsync(
        PlJpkV7MGenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the rows of the Polish recapitulative statement VAT-UE for a month: section C intra-Community supplies of goods, section D intra-Community acquisitions, section E services taxed where the customer is established. Amounts are full złoty per counterparty. The VAT-UE(5) file itself goes out from the EU sales list deadline in the calendar.
    /// </summary>
    WithRawResponseTask<PlVatUeGenerateDeclarationsResponse> PlVatUeGenerateAsync(
        PlVatUeGenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the rows of the Polish INTRASTAT declaration for a month, arrivals or dispatches, grouped by CN code, partner country, country of origin, partner VAT number, nature of transaction, transport and delivery terms. Values are whole złoty converted at the invoice rate; credit notes with goods lines are returns (code 21). Goods without a CN code are left out and named in the warnings. The IST message itself goes out from the Intrastat deadline in the calendar.
    /// </summary>
    WithRawResponseTask<PlIntrastatGenerateDeclarationsResponse> PlIntrastatGenerateAsync(
        PlIntrastatGenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the invoices KSeF holds for this company as the buyer, for a window of acquisition timestamps. Each row carries the KSeF number and, when the document number matches a registered purchase invoice, the invoice it belongs to.
    /// </summary>
    WithRawResponseTask<PlKsefReceivedListDeclarationsResponse> PlKsefReceivedListAsync(
        PlKsefReceivedListDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Read one invoice out of KSeF by its national number. With a purchase invoice given, the KSeF number is written onto that invoice, which is what makes the purchase row of JPK_V7M carry NrKSeF instead of the BFK marker.
    /// </summary>
    WithRawResponseTask<PlKsefReceivedFetchDeclarationsResponse> PlKsefReceivedFetchAsync(
        PlKsefReceivedFetchDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// The UPO for a KSeF session. KSeF issues one receipt per session rather than per invoice, so the session reference number from the send is what identifies it.
    /// </summary>
    WithRawResponseTask<PlKsefReceiptDeclarationsResponse> PlKsefReceiptAsync(
        PlKsefReceiptDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// The differences between the accounting result and the taxable profit: non-deductible expenses, income added to or left out of the tax base, extra deductible expenses, donations, losses carried forward, reliefs and tax credits. The annual corporate income tax return is built from them.
    /// </summary>
    WithRawResponseTask<TaxAdjustmentsListDeclarationsResponse> TaxAdjustmentsListAsync(
        TaxAdjustmentsListDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Records a tax adjustment of one kind for a tax year, with an optional form `code`. Answers 422 when the amount is zero.
    /// </summary>
    WithRawResponseTask<TaxAdjustmentsCreateDeclarationsResponse> TaxAdjustmentsCreateAsync(
        TaxAdjustmentsCreateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the kind, code, amount or description of a recorded tax adjustment; fields left out keep their value and an empty `code` clears it. Answers 422 when the new amount is zero.
    /// </summary>
    WithRawResponseTask<TaxAdjustmentsUpdateDeclarationsResponse> TaxAdjustmentsUpdateAsync(
        TaxAdjustmentsUpdateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a recorded tax adjustment.
    /// </summary>
    WithRawResponseTask<TaxAdjustmentsDeleteDeclarationsResponse> TaxAdjustmentsDeleteAsync(
        TaxAdjustmentsDeleteDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// What the company has paid the administration towards a tax before the return is filed: payments on account, tax withheld at source by others, a final settlement, and a refund received. Returns report these on their own lines, so the amount they ask for is the balance.
    /// </summary>
    WithRawResponseTask<TaxPaymentsListDeclarationsResponse> TaxPaymentsListAsync(
        TaxPaymentsListDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Records a payment made towards a tax (`tax`) of a year, and of a month when given, as an advance payment, tax withheld by others, a final settlement or a refund received. Answers 422 when the amount is zero.
    /// </summary>
    WithRawResponseTask<TaxPaymentsCreateDeclarationsResponse> TaxPaymentsCreateAsync(
        TaxPaymentsCreateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the kind, amount, payment date, reference or description of a recorded tax payment; fields left out keep their value and an empty `reference` clears it. Answers 422 when the new amount is zero.
    /// </summary>
    WithRawResponseTask<TaxPaymentsUpdateDeclarationsResponse> TaxPaymentsUpdateAsync(
        TaxPaymentsUpdateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a recorded tax payment.
    /// </summary>
    WithRawResponseTask<TaxPaymentsDeleteDeclarationsResponse> TaxPaymentsDeleteAsync(
        TaxPaymentsDeleteDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Whether the general meeting adopted the annual accounts and on which date, the date the accounts were prepared, and which directors signed them. The annual accounts filed with the trade register are built from these facts.
    /// </summary>
    WithRawResponseTask<AnnualAccountsGetDeclarationsResponse> AnnualAccountsGetAsync(
        AnnualAccountsGetDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates or replaces the record of a year: whether and when the accounts were adopted, when they were prepared, whether they were audited (with the qualification flag and the auditor report date) or the auditor was not elected, the report texts and the appropriation of the result. Answers 422 when `adopted` is true without `adoptionDate`, when the adoption date is not after 31 December of the year, or when the date of preparation is after the adoption date.
    /// </summary>
    WithRawResponseTask<AnnualAccountsSetDeclarationsResponse> AnnualAccountsSetAsync(
        AnnualAccountsSetDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Adds a director to the signatures of the annual accounts of the year: signed, with the date and place of signature, or not signed, with the reason. Answers 422 when no annual accounts record exists for the year (`declarations/annual-accounts/set` first), when a signed entry lacks the date or the place, or when an unsigned entry lacks the reason.
    /// </summary>
    WithRawResponseTask<AnnualAccountsSignaturesCreateDeclarationsResponse> AnnualAccountsSignaturesCreateAsync(
        AnnualAccountsSignaturesCreateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replaces the name, type and signing facts of a recorded director signature. Answers 422 when a signed entry lacks the date or the place of signature, or when an unsigned entry lacks the reason.
    /// </summary>
    WithRawResponseTask<AnnualAccountsSignaturesUpdateDeclarationsResponse> AnnualAccountsSignaturesUpdateAsync(
        AnnualAccountsSignaturesUpdateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a recorded director signature.
    /// </summary>
    WithRawResponseTask<AnnualAccountsSignaturesDeleteDeclarationsResponse> AnnualAccountsSignaturesDeleteAsync(
        AnnualAccountsSignaturesDeleteDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Adds a profit distribution decision (decision date, kind, amount, description) to the annual accounts record of the year. Answers 422 when no annual accounts record exists for the year.
    /// </summary>
    WithRawResponseTask<AnnualAccountsDistributionsCreateDeclarationsResponse> AnnualAccountsDistributionsCreateAsync(
        AnnualAccountsDistributionsCreateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replaces the decision date, kind, amount and description of a recorded profit distribution.
    /// </summary>
    WithRawResponseTask<AnnualAccountsDistributionsUpdateDeclarationsResponse> AnnualAccountsDistributionsUpdateAsync(
        AnnualAccountsDistributionsUpdateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a recorded profit distribution.
    /// </summary>
    WithRawResponseTask<AnnualAccountsDistributionsDeleteDeclarationsResponse> AnnualAccountsDistributionsDeleteAsync(
        AnnualAccountsDistributionsDeleteDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Links a file uploaded through files/upload (its storageKey) to the annual accounts of the year as the notes, the management report, the auditor statement, the profit appropriation resolution, the approval certificate, the general data sheet, the full report as a pdf, or another document. Deposits that must carry these documents take them from here.
    /// </summary>
    WithRawResponseTask<AnnualAccountsAttachmentsAddDeclarationsResponse> AnnualAccountsAttachmentsAddAsync(
        AnnualAccountsAttachmentsAddDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Removes the attachment from the annual accounts and deletes its file record and the stored bytes.
    /// </summary>
    WithRawResponseTask<AnnualAccountsAttachmentsDeleteDeclarationsResponse> AnnualAccountsAttachmentsDeleteAsync(
        AnnualAccountsAttachmentsDeleteDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Compute the company income tax return TD4 of a tax year from the ledger and the recorded tax adjustments: the accounting profit, the add-backs, deductions, capital allowances and losses brought forward, the chargeable income, the corporation tax at the rate of the year and the double tax relief, as the fields the company keys into TAXISnet or Tax For All. The Tax Department publishes no upload layout for the TD4; the XML is a working file.
    /// </summary>
    WithRawResponseTask<CyTd4GenerateDeclarationsResponse> CyTd4GenerateAsync(
        CyTd4GenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the annual return HE32 of a year: the figures the Registrar’s e-filing screens ask for (company number, registered office, made-up-to date, share capital, register of members, directors and secretary, annual general meeting date, the accounts summary), the working file, and the printed form HE32(I) filled in as a PDF for signing and for keying into the Registrar’s system, which takes the return only through its own screens.
    /// </summary>
    WithRawResponseTask<CyHe32GenerateDeclarationsResponse> CyHe32GenerateAsync(
        CyHe32GenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build one of the German returns that ELSTER accepts only through a licensed ERiC transmission (E-Bilanz, Körperschaftsteuer, Gewerbesteuer with its Zerlegungserklärung, annual VAT return, Lohnsteuer-Anmeldung, Lohnsteuerbescheinigung) for the company to send through its own ELSTER-capable program. The period is the year, or YYYY-MM for the monthly Lohnsteuer-Anmeldung.
    /// </summary>
    WithRawResponseTask<DeReturnsGenerateDeclarationsResponse> DeReturnsGenerateAsync(
        DeReturnsGenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// The facts of one year that the German annual returns (Körperschaftsteuer, Gewerbesteuer, Umsatzsteuererklärung) need and the ledger does not hold: changes of shareholders, contracts with shareholders, the tax contribution account, loss carry-back, the donation carry-forward, the business premises with the municipalities for the apportionment of the trade tax, the land values or property tax and the participations for the trade tax additions and reductions, the foreign income per country for the Anlage AESt, the date of leaving the small-business scheme and the Anlage UN answers of a company seated abroad. A key that is absent has not been answered.
    /// </summary>
    WithRawResponseTask<DeReturnFactsGetDeclarationsResponse> DeReturnFactsGetAsync(
        DeReturnFactsGetDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replace the facts of one year for the German annual returns. The returns built afterwards read them; a key left out stays unanswered.
    /// </summary>
    WithRawResponseTask<DeReturnFactsSetDeclarationsResponse> DeReturnFactsSetAsync(
        DeReturnFactsSetDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the DEÜV notifications of a month (Anmeldung for every start, Abmeldung for every leaving, in December the Jahresmeldung for everyone employed on 31 December) as DSME records with the DBME, DBNA, DBGB and DBAN blocks of Anlage 4 in force from 2026, from the approved payroll runs and the employee record, for the company's own transmission channel.
    /// </summary>
    WithRawResponseTask<DeDeuevGenerateDeclarationsResponse> DeDeuevGenerateAsync(
        DeDeuevGenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the monthly contribution statement to the health insurers (Beitragsnachweis) from the payroll run: one fixed-length record BW02 per insurer, in the record layout in force from 2026, ready for the company's own transmission channel.
    /// </summary>
    WithRawResponseTask<DeBeitragsnachweisGenerateDeclarationsResponse> DeBeitragsnachweisGenerateAsync(
        DeBeitragsnachweisGenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Compute the oplysningsskema for selskaber (selskabsselvangivelsen) of an income year from the ledger and the recorded tax adjustments: accounting result before tax, tax adjustments, losses carried forward, taxable income, the 22 % corporation tax, reliefs and the balance, as the rubrikker the company keys into TastSelv Selskabsskat (DIAS). Skatteforvaltningen publishes no file format for the return; the XML is a working file.
    /// </summary>
    WithRawResponseTask<DkSelskabsskatGenerateDeclarationsResponse> DkSelskabsskatGenerateAsync(
        DkSelskabsskatGenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Send one employment register (töötamise register) entry for an employment contract to e-MTA over X-tee: the start of work, or its end with the reason recorded on the contract.
    /// </summary>
    WithRawResponseTask<EeEmploymentRegisterSendDeclarationsResponse> EeEmploymentRegisterSendAsync(
        EeEmploymentRegisterSendDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Nordlet's declaración responsable for its VERI*FACTU invoicing system (Orden HAC/1177/2024, art. 15), as a PDF and as plain text.
    /// </summary>
    WithRawResponseTask<EsVerifactuDeclaracionResponsableDeclarationsResponse> EsVerifactuDeclaracionResponsableAsync(
        EsVerifactuDeclaracionResponsableDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the Form CT1 of an accounting year as the ROS version 26 XML and the accompanying financial statements as inline XBRL on the FRS 102 Irish Extension 2026 taxonomy Revenue accepts, both from the ledger, the recorded tax adjustments, the annual accounts record and the officers, for upload through the company’s own ROS account. Says whether the company is above the iXBRL deferral limits (balance sheet total €4.4 million, turnover €8.8 million, 50 employees).
    /// </summary>
    WithRawResponseTask<IeCt1GenerateDeclarationsResponse> IeCt1GenerateAsync(
        IeCt1GenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the working paper for the Form B1 annual return of a financial year - company details, registered office, directors and secretary from Account → Officers, the members from Account → Shareholders, the issued share capital and the figures of the financial statements - in the order the CORE screens ask for them. The CRO publishes no file format for the B1, so it is keyed into CORE.
    /// </summary>
    WithRawResponseTask<IeB1GenerateDeclarationsResponse> IeB1GenerateAsync(
        IeB1GenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the TD16-TD19 integration document for a registered purchase invoice and send it to the Sistema di Interscambio. Since July 2022 a purchase from a supplier established abroad is reported this way instead of the esterometro. The Italian VAT rate to self-assess is a judgement about the supply: pass vatRatePercent unless the purchase lines already carry it, otherwise the request is refused rather than guessed.
    /// </summary>
    WithRawResponseTask<ItSdiPurchaseSendDeclarationsResponse> ItSdiPurchaseSendAsync(
        ItSdiPurchaseSendDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Render the TD16-TD19 integration document for a registered purchase invoice without sending it, so the rate and the document type can be checked first.
    /// </summary>
    WithRawResponseTask<ItSdiPurchasePreviewDeclarationsResponse> ItSdiPurchasePreviewAsync(
        ItSdiPurchasePreviewDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Upload the SAF-T file to i.SAF-T over the iSAFTUploaderService web service and start its processing. The file, the case reference and the status are kept as a declaration submission (submissionId), whose outcome Nordlet then checks with i.SAF-T. The submission itself is confirmed separately, because after confirmation the file can no longer be corrected. A range and data type already sent is sent again only with amend: true.
    /// </summary>
    WithRawResponseTask<LtSaftSendDeclarationsResponse> LtSaftSendAsync(
        LtSaftSendDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Render the Sodra 1-SD or 2-SD notice for the contracts starting or ending in the range as an .ffdata document for EDAS.
    /// </summary>
    WithRawResponseTask<LtSdFfdataDeclarationsResponse> LtSdFfdataAsync(
        LtSdFfdataDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Render the annual corporate income tax return PLN204 as an .ffdata document, including the PLN204S and PLN204Z annexes, from the ledger and the tax adjustments recorded for that year.
    /// </summary>
    WithRawResponseTask<LtPln204FfdataDeclarationsResponse> LtPln204FfdataAsync(
        LtPln204FfdataDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Compute the company income tax return and self-assessment of a year of assessment from the ledger and the recorded tax adjustments: the accounting profit before tax, the add-backs and deductions, the approved donations, capital allowances and losses carried forward, the chargeable income, the 35 % charge, the relief against the tax and the allocation of the distributable profit to the five tax accounts. The Malta Tax and Customs Administration issues the return as a personalised spreadsheet to the registered tax practitioner and publishes no layout, so the XML is a working file and the figures are keyed into that spreadsheet.
    /// </summary>
    WithRawResponseTask<MtCompanyTaxGenerateDeclarationsResponse> MtCompanyTaxGenerateAsync(
        MtCompanyTaxGenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the annual return of a year: the company number, registered office and made-up-to date, the share capital, the register of members, the directors and the company secretary and the accounts summary, as the figures the Malta Business Registry asks for on its own screens, plus the printed Annual Return Form of the Seventh Schedule filled in as a PDF for signing.
    /// </summary>
    WithRawResponseTask<MtAnnualReturnGenerateDeclarationsResponse> MtAnnualReturnGenerateAsync(
        MtAnnualReturnGenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generate JPK_FA(4), the on-demand structure with every sales invoice issued in a period, its VAT bases per rate and one row per invoice line. Filed only when the tax office asks for it.
    /// </summary>
    WithRawResponseTask<PlJpkFaGenerateDeclarationsResponse> PlJpkFaGenerateAsync(
        PlJpkFaGenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generate JPK_KR(1), the on-demand structure with the chart of accounts and its opening balances and turnover, the journal and the double entries behind it. Filed only when the tax office asks for it.
    /// </summary>
    WithRawResponseTask<PlJpkKrGenerateDeclarationsResponse> PlJpkKrGenerateAsync(
        PlJpkKrGenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generate JPK_MAG(2), the on-demand structure with the warehouse documents of one warehouse: goods received from outside (PZ) or internally (PW) and issued to a customer (WZ) or internally (RW). Filed only when the tax office asks for it.
    /// </summary>
    WithRawResponseTask<PlJpkMagGenerateDeclarationsResponse> PlJpkMagGenerateAsync(
        PlJpkMagGenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generate PIT-11(29) for every person on the payroll of one year: the pay, the deductible costs, the advance withheld and the social and health contributions taken off it. One document per person, because that is how the form is filed, addressed to the tax office of the place of residence of that person (employee field plKodUrzedu); a person without that code is refused with 422.
    /// </summary>
    WithRawResponseTask<PlPit11GenerateDeclarationsResponse> PlPit11GenerateAsync(
        PlPit11GenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generate CIT-8(34), the annual corporate income tax return, from the ledger of the year and the recorded tax adjustments. The tax office code and the small-taxpayer setting come from the e-Deklaracje compliance settings, the seat address from the JPK gateway settings. Names the annexes the figures would need, which are not produced.
    /// </summary>
    WithRawResponseTask<PlCit8GenerateDeclarationsResponse> PlCit8GenerateAsync(
        PlCit8GenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Compute the monthly ZUS DRA settlement from the payroll run of one month: the pension, disability, sickness, accident and health insurance contributions and the Labour Fund, Solidarity Fund and guaranteed benefits fund charges, each split between the insured person and the payer. The amounts are carried into Płatnik or ePłatnik by hand.
    /// </summary>
    WithRawResponseTask<PlZusDraComputeDeclarationsResponse> PlZusDraComputeAsync(
        PlZusDraComputeDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the KEDU file for one month: the ZUS DRA settlement and one ZUS RCA report per person on the payroll, in the schema kedu_5_4 that Płatnik and ePłatnik import. The payer REGON, short name and declaration deadline code come from the ZUS compliance settings; the insurance title code and working time of each person from the employee record.
    /// </summary>
    WithRawResponseTask<PlZusDraKeduDeclarationsResponse> PlZusDraKeduAsync(
        PlZusDraKeduDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Fill the published ZUS DRA form for one month and return it as a PDF. The amounts, the payer identity and the deadline code are the same ones the KEDU file carries; blocks the payroll does not hold (paid benefits, bridging pensions, income declaration of a self-paying person) stay empty.
    /// </summary>
    WithRawResponseTask<PlZusDraPdfDeclarationsResponse> PlZusDraPdfAsync(
        PlZusDraPdfDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the RO e-Transport declaration for an issued waybill: goods with their tariff codes and masses, the commercial partner, the route and the vehicle. The XML follows the ANAF eTransport v2 schema and is kept as a file on the waybill. Anything listed in blockers has to be filled in before /etransport/send will accept it.
    /// </summary>
    WithRawResponseTask<RoEtransportBuildDeclarationsResponse> RoEtransportBuildAsync(
        RoEtransportBuildDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Hand the RO e-Transport declaration for an issued waybill to ANAF under the SPV OAuth token in compliance settings, and return the upload index the UIT is read back with. Answers 422 while any field the ANAF validator requires is still missing.
    /// </summary>
    WithRawResponseTask<RoEtransportSubmitDeclarationsResponse> RoEtransportSubmitAsync(
        RoEtransportSubmitDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Read the outcome of an e-Transport declaration from ANAF by its upload index, under the SPV OAuth token in compliance settings. Returns the UIT code once the declaration validates.
    /// </summary>
    WithRawResponseTask<RoEtransportStatusDeclarationsResponse> RoEtransportStatusAsync(
        RoEtransportStatusDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the annual wage declaration (Lohndeklaration) to the AHV-IV-FAK from the approved payroll runs of the year as the CSV that AHVeasy imports under Lohndeklaration → CSV-Import der Lohndaten: one row per employee with the 18 columns of the AHVeasy template, the AHV-liable wage and the ALV wage.
    /// </summary>
    WithRawResponseTask<LiLohndeklarationGenerateDeclarationsResponse> LiLohndeklarationGenerateAsync(
        LiLohndeklarationGenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the annual wage list (Lohnliste) of a Liechtenstein employer from the approved payroll runs of the year as the XLSX file the tax administration's eLohnausweis / eLohnlisten application imports: one row per employee with PEID, name, birth date, address, gross wage, wage tax withheld and the settlement period.
    /// </summary>
    WithRawResponseTask<LiLohnlistenGenerateDeclarationsResponse> LiLohnlistenGenerateAsync(
        LiLohnlistenGenerateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the filing systems the company can configure: those of the company country (or of `country` when given), the EU-wide systems and the cross-border e-invoicing systems `it_sdi`, `pl_ksef` and `ro_efactura`. Each row carries the stored values, with a secret or certificate field shown as `__secret_set__` and the fields taken from the company profile filled from it.
    /// </summary>
    WithRawResponseTask<ConfigsListDeclarationsResponse> ConfigsListAsync(
        ConfigsListDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Stores the settings of one filing system for the company, merging the given fields into the stored ones. A secret or certificate value is encrypted before it is stored, an empty string clears a field, and `__secret_set__` leaves a stored secret unchanged. Answers 422 for an unknown system.
    /// </summary>
    WithRawResponseTask<ConfigsUpdateDeclarationsResponse> ConfigsUpdateAsync(
        ConfigsUpdateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Stores a PEM certificate, a PEM private key or a PKCS#12 bundle (base64 in `content`, opened with `passphrase` when it needs one) in the settings of the filing system and replaces the earlier upload of the same kind; for a PEM certificate the fingerprint, subject, issuer and validity dates are recorded. Answers 422 when the system is unknown or does not authenticate with a certificate. Returns the full certificate list of the company.
    /// </summary>
    WithRawResponseTask<CertificatesUploadDeclarationsResponse> CertificatesUploadAsync(
        CertificatesUploadDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the certificates and private keys stored for the filing systems of the company, ordered by system and field, each with its validity facts and health (`ok`, `expiring`, `expired` or `unknown`).
    /// </summary>
    WithRawResponseTask<CertificatesListDeclarationsResponse> CertificatesListAsync(
        CertificatesListDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Removes the certificate or the private key (`fieldKey`) of a filing system from the settings of the company and from the certificate list, and returns the remaining certificates.
    /// </summary>
    WithRawResponseTask<CertificatesDeleteDeclarationsResponse> CertificatesDeleteAsync(
        CertificatesDeleteDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the filing deadlines Nordlet can file by itself for the country of the company: for each, whether automatic filing is switched on, whether the rule applies to the company profile, whether its filing system is configured, the state of its certificate and whether it would go to the test or the production service.
    /// </summary>
    WithRawResponseTask<AutomationListDeclarationsResponse> AutomationListAsync(
        AutomationListDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Switches automatic filing of one deadline on or off for the company and returns the list of `declarations/automation/list`. Answers 422 when the deadline is not one Nordlet files, or when switching on while the filing system is connected to the test service of the administration (unless the company is a sandbox), is not configured, or has no valid certificate.
    /// </summary>
    WithRawResponseTask<AutomationUpdateDeclarationsResponse> AutomationUpdateAsync(
        AutomationUpdateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sends a submission that is still in status `generated` through its filing system once more, with the stored file or, when none was stored yet, a freshly generated one, and returns the updated submission. Answers 409 when the submission is already submitted, accepted or rejected.
    /// </summary>
    WithRawResponseTask<SubmissionsRetryDeclarationsResponse> SubmissionsRetryAsync(
        SubmissionsRetryDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Builds the Lithuanian i.SAF register file of a month (`dataType` F both registers, S sale invoices only, P purchase invoices only), stores it and creates a submission in status `generated` for the obligation `lt-isaf`, the only obligation accepted. The XML alone comes from `declarations/lt/isaf/generate`; the submission is moved on with `declarations/submissions/mark`.
    /// </summary>
    WithRawResponseTask<SubmissionsCreateDeclarationsResponse> SubmissionsCreateAsync(
        SubmissionsCreateDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Records by hand that a submission was sent, accepted or rejected, with the reference and message of the administration when given. The allowed moves are `generated` to `submitted` and `submitted` to `accepted` or `rejected`; any other move answers 409. A submission without a transport system is marked as sent manually.
    /// </summary>
    WithRawResponseTask<SubmissionsMarkDeclarationsResponse> SubmissionsMarkAsync(
        SubmissionsMarkDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the declaration submissions of the company, newest first, filterable by `obligation`, `status`, `periodYear` and `periodMonth` and sortable by `createdAt` or `periodYear`.
    /// </summary>
    WithRawResponseTask<SubmissionsListDeclarationsResponse> SubmissionsListAsync(
        SubmissionsListDeclarationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
