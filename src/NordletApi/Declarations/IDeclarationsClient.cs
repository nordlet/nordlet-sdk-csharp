namespace NordletApi;

public partial interface IDeclarationsClient
{
    WithRawResponseTask<PostV1DeclarationsLtIntrastatComputeResponse> PostV1DeclarationsLtIntrastatComputeAsync(
        PostV1DeclarationsLtIntrastatComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtIvazGenerateResponse> PostV1DeclarationsLtIvazGenerateAsync(
        PostV1DeclarationsLtIvazGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtIntrastatObligationResponse> PostV1DeclarationsLtIntrastatObligationAsync(
        PostV1DeclarationsLtIntrastatObligationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtIsafGenerateResponse> PostV1DeclarationsLtIsafGenerateAsync(
        PostV1DeclarationsLtIsafGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtFr0600ComputeResponse> PostV1DeclarationsLtFr0600ComputeAsync(
        PostV1DeclarationsLtFr0600ComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtGpm313ComputeResponse> PostV1DeclarationsLtGpm313ComputeAsync(
        PostV1DeclarationsLtGpm313ComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtSamComputeResponse> PostV1DeclarationsLtSamComputeAsync(
        PostV1DeclarationsLtSamComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtSdGenerateResponse> PostV1DeclarationsLtSdGenerateAsync(
        PostV1DeclarationsLtSdGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtSaftGenerateResponse> PostV1DeclarationsLtSaftGenerateAsync(
        PostV1DeclarationsLtSaftGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtIvazAmendResponse> PostV1DeclarationsLtIvazAmendAsync(
        PostV1DeclarationsLtIvazAmendRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtIvazCancelResponse> PostV1DeclarationsLtIvazCancelAsync(
        PostV1DeclarationsLtIvazCancelRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtFr0564ComputeResponse> PostV1DeclarationsLtFr0564ComputeAsync(
        PostV1DeclarationsLtFr0564ComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtGpm312ComputeResponse> PostV1DeclarationsLtGpm312ComputeAsync(
        PostV1DeclarationsLtGpm312ComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsLtPln204ComputeResponse> PostV1DeclarationsLtPln204ComputeAsync(
        PostV1DeclarationsLtPln204ComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsEuOssComputeResponse> PostV1DeclarationsEuOssComputeAsync(
        PostV1DeclarationsEuOssComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsEuIossComputeResponse> PostV1DeclarationsEuIossComputeAsync(
        PostV1DeclarationsEuIossComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsEuDistanceSalesThresholdGetResponse> PostV1DeclarationsEuDistanceSalesThresholdGetAsync(
        PostV1DeclarationsEuDistanceSalesThresholdGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsEuUnionTurnoverGetResponse> PostV1DeclarationsEuUnionTurnoverGetAsync(
        PostV1DeclarationsEuUnionTurnoverGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsEuSmeCrossBorderReportComputeResponse> PostV1DeclarationsEuSmeCrossBorderReportComputeAsync(
        PostV1DeclarationsEuSmeCrossBorderReportComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsEuSmeThresholdsListResponse> PostV1DeclarationsEuSmeThresholdsListAsync(
        PostV1DeclarationsEuSmeThresholdsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsEuSmeThresholdGetResponse> PostV1DeclarationsEuSmeThresholdGetAsync(
        PostV1DeclarationsEuSmeThresholdGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsEuVatReturnPacksListResponse> PostV1DeclarationsEuVatReturnPacksListAsync(
        PostV1DeclarationsEuVatReturnPacksListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsEuVatReturnComputeResponse> PostV1DeclarationsEuVatReturnComputeAsync(
        PostV1DeclarationsEuVatReturnComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generate the Polish JPK_V7M(3) file (VAT declaration with evidence) for a month, per the MF schema in force since February 2026. Amounts must already be in PLN; rows are marked BFK until a KSeF integration supplies invoice numbers. Review the warnings before submitting via e-dokumenty.mf.gov.pl.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsPlJpkV7MGenerateResponse> PostV1DeclarationsPlJpkV7MGenerateAsync(
        PostV1DeclarationsPlJpkV7MGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the rows of the Polish recapitulative statement VAT-UE for a month: section C intra-Community supplies of goods, section D intra-Community acquisitions, section E services taxed where the customer is established. Amounts are full złoty per counterparty. The VAT-UE(5) file itself goes out from the EU sales list deadline in the calendar.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsPlVatUeGenerateResponse> PostV1DeclarationsPlVatUeGenerateAsync(
        PostV1DeclarationsPlVatUeGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the rows of the Polish INTRASTAT declaration for a month, arrivals or dispatches, grouped by CN code, partner country, country of origin, partner VAT number, nature of transaction, transport and delivery terms. Values are whole złoty converted at the invoice rate; credit notes with goods lines are returns (code 21). Goods without a CN code are left out and named in the warnings. The IST message itself goes out from the Intrastat deadline in the calendar.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsPlIntrastatGenerateResponse> PostV1DeclarationsPlIntrastatGenerateAsync(
        PostV1DeclarationsPlIntrastatGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the invoices KSeF holds for this company as the buyer, for a window of acquisition timestamps. Each row carries the KSeF number and, when the document number matches a registered purchase invoice, the invoice it belongs to.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsPlKsefReceivedListResponse> PostV1DeclarationsPlKsefReceivedListAsync(
        PostV1DeclarationsPlKsefReceivedListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Read one invoice out of KSeF by its national number. With a purchase invoice given, the KSeF number is written onto that invoice, which is what makes the purchase row of JPK_V7M carry NrKSeF instead of the BFK marker.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsPlKsefReceivedFetchResponse> PostV1DeclarationsPlKsefReceivedFetchAsync(
        PostV1DeclarationsPlKsefReceivedFetchRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// The UPO for a KSeF session. KSeF issues one receipt per session rather than per invoice, so the session reference number from the send is what identifies it.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsPlKsefReceiptResponse> PostV1DeclarationsPlKsefReceiptAsync(
        PostV1DeclarationsPlKsefReceiptRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// The differences between the accounting result and the taxable profit: non-deductible expenses, income added to or left out of the tax base, extra deductible expenses, donations, losses carried forward, reliefs and tax credits. The annual corporate income tax return is built from them.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsTaxAdjustmentsListResponse> TaxAdjustmentsRecordedForATaxYearAsync(
        PostV1DeclarationsTaxAdjustmentsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsTaxAdjustmentsCreateResponse> RecordATaxAdjustmentForATaxYearAsync(
        PostV1DeclarationsTaxAdjustmentsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsTaxAdjustmentsUpdateResponse> ChangeARecordedTaxAdjustmentAsync(
        PostV1DeclarationsTaxAdjustmentsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsTaxAdjustmentsDeleteResponse> RemoveARecordedTaxAdjustmentAsync(
        PostV1DeclarationsTaxAdjustmentsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// What the company has paid the administration towards a tax before the return is filed: payments on account, tax withheld at source by others, a final settlement, and a refund received. Returns report these on their own lines, so the amount they ask for is the balance.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsTaxPaymentsListResponse> PaymentsAlreadyMadeTowardsATaxOfAYearAsync(
        PostV1DeclarationsTaxPaymentsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsTaxPaymentsCreateResponse> RecordAPaymentMadeTowardsATaxAsync(
        PostV1DeclarationsTaxPaymentsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsTaxPaymentsUpdateResponse> ChangeARecordedTaxPaymentAsync(
        PostV1DeclarationsTaxPaymentsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsTaxPaymentsDeleteResponse> RemoveARecordedTaxPaymentAsync(
        PostV1DeclarationsTaxPaymentsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Whether the general meeting adopted the annual accounts and on which date, the date the accounts were prepared, and which directors signed them. The annual accounts filed with the trade register are built from these facts.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsAnnualAccountsGetResponse> AdoptionAndSigningFactsOfTheAnnualAccountsOfAYearAsync(
        PostV1DeclarationsAnnualAccountsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsAnnualAccountsSetResponse> RecordTheAdoptionAndPreparationOfTheAnnualAccountsOfAYearAsync(
        PostV1DeclarationsAnnualAccountsSetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsAnnualAccountsSignaturesCreateResponse> RecordWhetherADirectorSignedTheAnnualAccountsOfAYearAsync(
        PostV1DeclarationsAnnualAccountsSignaturesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsAnnualAccountsSignaturesUpdateResponse> ChangeARecordedDirectorSignatureAsync(
        PostV1DeclarationsAnnualAccountsSignaturesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsAnnualAccountsSignaturesDeleteResponse> RemoveARecordedDirectorSignatureAsync(
        PostV1DeclarationsAnnualAccountsSignaturesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsAnnualAccountsDistributionsCreateResponse> RecordADecisionToDistributeProfitADividendAnInterimDividendOrAPaymentTreatedAsOneAsync(
        PostV1DeclarationsAnnualAccountsDistributionsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsAnnualAccountsDistributionsUpdateResponse> ChangeARecordedProfitDistributionAsync(
        PostV1DeclarationsAnnualAccountsDistributionsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsAnnualAccountsDistributionsDeleteResponse> RemoveARecordedProfitDistributionAsync(
        PostV1DeclarationsAnnualAccountsDistributionsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Links a file uploaded through files/upload (its storageKey) to the annual accounts of the year as the notes, the management report, the auditor statement, the profit appropriation resolution, the approval certificate, the general data sheet, the full report as a pdf, or another document. Deposits that must carry these documents take them from here.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsAnnualAccountsAttachmentsAddResponse> AttachAnUploadedDocumentToTheAnnualAccountsOfAYearAsync(
        PostV1DeclarationsAnnualAccountsAttachmentsAddRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsAnnualAccountsAttachmentsDeleteResponse> RemoveADocumentAttachedToTheAnnualAccountsAndDeleteItsFileAsync(
        PostV1DeclarationsAnnualAccountsAttachmentsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Compute the company income tax return TD4 of a tax year from the ledger and the recorded tax adjustments: the accounting profit, the add-backs, deductions, capital allowances and losses brought forward, the chargeable income, the corporation tax at the rate of the year and the double tax relief, as the fields the company keys into TAXISnet or Tax For All. The Tax Department publishes no upload layout for the TD4; the XML is a working file.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsCyTd4GenerateResponse> PostV1DeclarationsCyTd4GenerateAsync(
        PostV1DeclarationsCyTd4GenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the annual return HE32 of a year: the figures the Registrar’s e-filing screens ask for (company number, registered office, made-up-to date, share capital, register of members, directors and secretary, annual general meeting date, the accounts summary), the working file, and the printed form HE32(I) filled in as a PDF for signing and for keying into the Registrar’s system, which takes the return only through its own screens.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsCyHe32GenerateResponse> PostV1DeclarationsCyHe32GenerateAsync(
        PostV1DeclarationsCyHe32GenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build one of the German returns that ELSTER accepts only through a licensed ERiC transmission (E-Bilanz, Körperschaftsteuer, Gewerbesteuer with its Zerlegungserklärung, annual VAT return, Lohnsteuer-Anmeldung, Lohnsteuerbescheinigung) for the company to send through its own ELSTER-capable program. The period is the year, or YYYY-MM for the monthly Lohnsteuer-Anmeldung.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsDeReturnsGenerateResponse> PostV1DeclarationsDeReturnsGenerateAsync(
        PostV1DeclarationsDeReturnsGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// The facts of one year that the German annual returns (Körperschaftsteuer, Gewerbesteuer, Umsatzsteuererklärung) need and the ledger does not hold: changes of shareholders, contracts with shareholders, the tax contribution account, loss carry-back, the donation carry-forward, the business premises with the municipalities for the apportionment of the trade tax, the land values or property tax and the participations for the trade tax additions and reductions, the foreign income per country for the Anlage AESt, the date of leaving the small-business scheme and the Anlage UN answers of a company seated abroad. A key that is absent has not been answered.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsDeReturnFactsGetResponse> PostV1DeclarationsDeReturnFactsGetAsync(
        PostV1DeclarationsDeReturnFactsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replace the facts of one year for the German annual returns. The returns built afterwards read them; a key left out stays unanswered.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsDeReturnFactsSetResponse> PostV1DeclarationsDeReturnFactsSetAsync(
        PostV1DeclarationsDeReturnFactsSetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the DEÜV notifications of a month (Anmeldung for every start, Abmeldung for every leaving, in December the Jahresmeldung for everyone employed on 31 December) as DSME records with the DBME, DBNA, DBGB and DBAN blocks of Anlage 4 in force from 2026, from the approved payroll runs and the employee record, for the company's own transmission channel.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsDeDeuevGenerateResponse> PostV1DeclarationsDeDeuevGenerateAsync(
        PostV1DeclarationsDeDeuevGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the monthly contribution statement to the health insurers (Beitragsnachweis) from the payroll run: one fixed-length record BW02 per insurer, in the record layout in force from 2026, ready for the company's own transmission channel.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsDeBeitragsnachweisGenerateResponse> PostV1DeclarationsDeBeitragsnachweisGenerateAsync(
        PostV1DeclarationsDeBeitragsnachweisGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Compute the oplysningsskema for selskaber (selskabsselvangivelsen) of an income year from the ledger and the recorded tax adjustments: accounting result before tax, tax adjustments, losses carried forward, taxable income, the 22 % corporation tax, reliefs and the balance, as the rubrikker the company keys into TastSelv Selskabsskat (DIAS). Skatteforvaltningen publishes no file format for the return; the XML is a working file.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsDkSelskabsskatGenerateResponse> PostV1DeclarationsDkSelskabsskatGenerateAsync(
        PostV1DeclarationsDkSelskabsskatGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Send one employment register (töötamise register) entry for an employment contract to e-MTA over X-tee: the start of work, or its end with the reason recorded on the contract.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsEeEmploymentRegisterSendResponse> PostV1DeclarationsEeEmploymentRegisterSendAsync(
        PostV1DeclarationsEeEmploymentRegisterSendRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Nordlet's declaración responsable for its VERI*FACTU invoicing system (Orden HAC/1177/2024, art. 15), as a PDF and as plain text.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsEsVerifactuDeclaracionResponsableResponse> PostV1DeclarationsEsVerifactuDeclaracionResponsableAsync(
        PostV1DeclarationsEsVerifactuDeclaracionResponsableRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the Form CT1 of an accounting year as the ROS version 26 XML and the accompanying financial statements as inline XBRL on the FRS 102 Irish Extension 2026 taxonomy Revenue accepts, both from the ledger, the recorded tax adjustments, the annual accounts record and the officers, for upload through the company’s own ROS account. Says whether the company is above the iXBRL deferral limits (balance sheet total €4.4 million, turnover €8.8 million, 50 employees).
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsIeCt1GenerateResponse> PostV1DeclarationsIeCt1GenerateAsync(
        PostV1DeclarationsIeCt1GenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the working paper for the Form B1 annual return of a financial year — company details, registered office, directors and secretary from Settings → Officers, the members from Settings → Shareholders, the issued share capital and the figures of the financial statements — in the order the CORE screens ask for them. The CRO publishes no file format for the B1, so it is keyed into CORE.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsIeB1GenerateResponse> PostV1DeclarationsIeB1GenerateAsync(
        PostV1DeclarationsIeB1GenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the TD16-TD19 integration document for a registered purchase invoice and send it to the Sistema di Interscambio. Since July 2022 a purchase from a supplier established abroad is reported this way instead of the esterometro. The Italian VAT rate to self-assess is a judgement about the supply: pass vatRatePercent unless the purchase lines already carry it, otherwise the request is refused rather than guessed.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsItSdiPurchaseSendResponse> PostV1DeclarationsItSdiPurchaseSendAsync(
        PostV1DeclarationsItSdiPurchaseSendRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Render the TD16-TD19 integration document for a registered purchase invoice without sending it, so the rate and the document type can be checked first.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsItSdiPurchasePreviewResponse> PostV1DeclarationsItSdiPurchasePreviewAsync(
        PostV1DeclarationsItSdiPurchasePreviewRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Upload the SAF-T file to i.SAF-T over the iSAFTUploaderService web service and start its processing. The submission itself is confirmed separately, because after confirmation the file can no longer be corrected.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsLtSaftSendResponse> PostV1DeclarationsLtSaftSendAsync(
        PostV1DeclarationsLtSaftSendRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Render the Sodra 1-SD or 2-SD notice for the contracts starting or ending in the range as an .ffdata document for EDAS.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsLtSdFfdataResponse> PostV1DeclarationsLtSdFfdataAsync(
        PostV1DeclarationsLtSdFfdataRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Render the annual corporate income tax return PLN204 as an .ffdata document, including the PLN204S and PLN204Z annexes, from the ledger and the tax adjustments recorded for that year.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsLtPln204FfdataResponse> PostV1DeclarationsLtPln204FfdataAsync(
        PostV1DeclarationsLtPln204FfdataRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Compute the company income tax return and self-assessment of a year of assessment from the ledger and the recorded tax adjustments: the accounting profit before tax, the add-backs and deductions, the approved donations, capital allowances and losses carried forward, the chargeable income, the 35 % charge, the relief against the tax and the allocation of the distributable profit to the five tax accounts. The Malta Tax and Customs Administration issues the return as a personalised spreadsheet to the registered tax practitioner and publishes no layout, so the XML is a working file and the figures are keyed into that spreadsheet.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsMtCompanyTaxGenerateResponse> PostV1DeclarationsMtCompanyTaxGenerateAsync(
        PostV1DeclarationsMtCompanyTaxGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the annual return of a year: the company number, registered office and made-up-to date, the share capital, the register of members, the directors and the company secretary and the accounts summary, as the figures the Malta Business Registry asks for on its own screens, plus the printed Annual Return Form of the Seventh Schedule filled in as a PDF for signing.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsMtAnnualReturnGenerateResponse> PostV1DeclarationsMtAnnualReturnGenerateAsync(
        PostV1DeclarationsMtAnnualReturnGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generate JPK_FA(4), the on-demand structure with every sales invoice issued in a period, its VAT bases per rate and one row per invoice line. Filed only when the tax office asks for it.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsPlJpkFaGenerateResponse> PostV1DeclarationsPlJpkFaGenerateAsync(
        PostV1DeclarationsPlJpkFaGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generate JPK_KR(1), the on-demand structure with the chart of accounts and its opening balances and turnover, the journal and the double entries behind it. Filed only when the tax office asks for it.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsPlJpkKrGenerateResponse> PostV1DeclarationsPlJpkKrGenerateAsync(
        PostV1DeclarationsPlJpkKrGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generate JPK_MAG(2), the on-demand structure with the warehouse documents of one warehouse: goods received from outside (PZ) or internally (PW) and issued to a customer (WZ) or internally (RW). Filed only when the tax office asks for it.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsPlJpkMagGenerateResponse> PostV1DeclarationsPlJpkMagGenerateAsync(
        PostV1DeclarationsPlJpkMagGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generate PIT-11(29) for every person on the payroll of one year: the pay, the deductible costs, the advance withheld and the social and health contributions taken off it. One document per person, because that is how the form is filed.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsPlPit11GenerateResponse> PostV1DeclarationsPlPit11GenerateAsync(
        PostV1DeclarationsPlPit11GenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generate CIT-8(34), the annual corporate income tax return, from the ledger of the year and the recorded tax adjustments. The tax office code and the small-taxpayer setting come from the e-Deklaracje compliance settings, the seat address from the JPK gateway settings. Names the annexes the figures would need, which are not produced.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsPlCit8GenerateResponse> PostV1DeclarationsPlCit8GenerateAsync(
        PostV1DeclarationsPlCit8GenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Compute the monthly ZUS DRA settlement from the payroll run of one month: the pension, disability, sickness, accident and health insurance contributions and the Labour Fund, Solidarity Fund and guaranteed benefits fund charges, each split between the insured person and the payer. The amounts are carried into Płatnik or ePłatnik by hand.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsPlZusDraComputeResponse> PostV1DeclarationsPlZusDraComputeAsync(
        PostV1DeclarationsPlZusDraComputeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the KEDU file for one month: the ZUS DRA settlement and one ZUS RCA report per person on the payroll, in the schema kedu_5_4 that Płatnik and ePłatnik import. The payer REGON, short name and declaration deadline code come from the ZUS compliance settings; the insurance title code and working time of each person from the employee record.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsPlZusDraKeduResponse> PostV1DeclarationsPlZusDraKeduAsync(
        PostV1DeclarationsPlZusDraKeduRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Fill the published ZUS DRA form for one month and return it as a PDF. The amounts, the payer identity and the deadline code are the same ones the KEDU file carries; blocks the payroll does not hold (paid benefits, bridging pensions, income declaration of a self-paying person) stay empty.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsPlZusDraPdfResponse> PostV1DeclarationsPlZusDraPdfAsync(
        PostV1DeclarationsPlZusDraPdfRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the RO e-Transport declaration for an issued waybill: goods with their tariff codes and masses, the commercial partner, the route and the vehicle. The XML follows the ANAF eTransport v2 schema and is kept as a file on the waybill. Anything listed in blockers has to be filled in before /etransport/send will accept it.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsRoEtransportBuildResponse> PostV1DeclarationsRoEtransportBuildAsync(
        PostV1DeclarationsRoEtransportBuildRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Hand the RO e-Transport declaration for an issued waybill to ANAF under the SPV OAuth token in compliance settings, and return the upload index the UIT is read back with. Answers 422 while any field the ANAF validator requires is still missing.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsRoEtransportSubmitResponse> PostV1DeclarationsRoEtransportSubmitAsync(
        PostV1DeclarationsRoEtransportSubmitRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Read the outcome of an e-Transport declaration from ANAF by its upload index, under the SPV OAuth token in compliance settings. Returns the UIT code once the declaration validates.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsRoEtransportStatusResponse> PostV1DeclarationsRoEtransportStatusAsync(
        PostV1DeclarationsRoEtransportStatusRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the annual wage declaration (Lohndeklaration) to the AHV-IV-FAK from the approved payroll runs of the year as the CSV that AHVeasy imports under Lohndeklaration → CSV-Import der Lohndaten: one row per employee with the 18 columns of the AHVeasy template, the AHV-liable wage and the ALV wage.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsLiLohndeklarationGenerateResponse> PostV1DeclarationsLiLohndeklarationGenerateAsync(
        PostV1DeclarationsLiLohndeklarationGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Build the annual wage list (Lohnliste) of a Liechtenstein employer from the approved payroll runs of the year as the XLSX file the tax administration's eLohnausweis / eLohnlisten application imports: one row per employee with PEID, name, birth date, address, gross wage, wage tax withheld and the settlement period.
    /// </summary>
    WithRawResponseTask<PostV1DeclarationsLiLohnlistenGenerateResponse> PostV1DeclarationsLiLohnlistenGenerateAsync(
        PostV1DeclarationsLiLohnlistenGenerateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsConfigsListResponse> PostV1DeclarationsConfigsListAsync(
        PostV1DeclarationsConfigsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsConfigsUpdateResponse> PostV1DeclarationsConfigsUpdateAsync(
        PostV1DeclarationsConfigsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsCertificatesUploadResponse> StoreTheCertificateOrPrivateKeyAFilingSystemAuthenticatesWithAsync(
        PostV1DeclarationsCertificatesUploadRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsCertificatesListResponse> PostV1DeclarationsCertificatesListAsync(
        PostV1DeclarationsCertificatesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsCertificatesDeleteResponse> PostV1DeclarationsCertificatesDeleteAsync(
        PostV1DeclarationsCertificatesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsAutomationListResponse> WhichDeadlinesNordletCanFileByItselfForThisCompanyAndWhichAreSwitchedOnAsync(
        PostV1DeclarationsAutomationListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsAutomationUpdateResponse> PostV1DeclarationsAutomationUpdateAsync(
        PostV1DeclarationsAutomationUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsSubmissionsRetryResponse> SendAFilingWhoseDeliveryFailedOnceMoreWithTheBytesThatWereGeneratedAsync(
        PostV1DeclarationsSubmissionsRetryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsSubmissionsCreateResponse> PostV1DeclarationsSubmissionsCreateAsync(
        PostV1DeclarationsSubmissionsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsSubmissionsMarkResponse> PostV1DeclarationsSubmissionsMarkAsync(
        PostV1DeclarationsSubmissionsMarkRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1DeclarationsSubmissionsListResponse> PostV1DeclarationsSubmissionsListAsync(
        PostV1DeclarationsSubmissionsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
