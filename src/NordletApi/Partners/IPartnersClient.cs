namespace NordletApi;

public partial interface IPartnersClient
{
    WithRawResponseTask<PostV1PartnersAddressesCreateResponse> PostV1PartnersAddressesCreateAsync(
        PostV1PartnersAddressesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersAddressesUpdateResponse> PostV1PartnersAddressesUpdateAsync(
        PostV1PartnersAddressesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersAddressesDeleteResponse> PostV1PartnersAddressesDeleteAsync(
        PostV1PartnersAddressesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersAddressesListResponse> PostV1PartnersAddressesListAsync(
        PostV1PartnersAddressesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersContactsCreateResponse> PostV1PartnersContactsCreateAsync(
        PostV1PartnersContactsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersContactsUpdateResponse> PostV1PartnersContactsUpdateAsync(
        PostV1PartnersContactsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersContactsDeleteResponse> PostV1PartnersContactsDeleteAsync(
        PostV1PartnersContactsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersContactsListResponse> PostV1PartnersContactsListAsync(
        PostV1PartnersContactsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersBankAccountsCreateResponse> PostV1PartnersBankAccountsCreateAsync(
        PostV1PartnersBankAccountsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersBankAccountsUpdateResponse> PostV1PartnersBankAccountsUpdateAsync(
        PostV1PartnersBankAccountsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersBankAccountsDeleteResponse> PostV1PartnersBankAccountsDeleteAsync(
        PostV1PartnersBankAccountsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersBankAccountsListResponse> PostV1PartnersBankAccountsListAsync(
        PostV1PartnersBankAccountsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersFilesListResponse> PostV1PartnersFilesListAsync(
        PostV1PartnersFilesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersDebtRemindersPreviewResponse> RemindersTheOvernightDebtReminderJobWouldSendTodayForThisCompanyAsync(
        PostV1PartnersDebtRemindersPreviewRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersDebtRemindersListResponse> PostV1PartnersDebtRemindersListAsync(
        PostV1PartnersDebtRemindersListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersValidateVatResponse> PostV1PartnersValidateVatAsync(
        PostV1PartnersValidateVatRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersVatReviewsListResponse> PostV1PartnersVatReviewsListAsync(
        PostV1PartnersVatReviewsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersVatReviewsResolveResponse> PostV1PartnersVatReviewsResolveAsync(
        PostV1PartnersVatReviewsResolveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersCreateResponse> PostV1PartnersCreateAsync(
        PostV1PartnersCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersFindOrCreateResponse> PostV1PartnersFindOrCreateAsync(
        PostV1PartnersFindOrCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersGetResponse> PostV1PartnersGetAsync(
        PostV1PartnersGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersUpdateResponse> PostV1PartnersUpdateAsync(
        PostV1PartnersUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersDeleteResponse> PostV1PartnersDeleteAsync(
        PostV1PartnersDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Removes birth date, self-employment certificate number, email, phone, address, notes, contacts, addresses and bank accounts, then hides the partner. The name, code and VAT number stay because issued invoices must keep identifying the counterparty for the statutory retention period.
    /// </summary>
    WithRawResponseTask<PostV1PartnersAnonymizeResponse> BlankAPartnersPersonalDataAndHideTheRecordAsync(
        PostV1PartnersAnonymizeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersListResponse> PostV1PartnersListAsync(
        PostV1PartnersListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersGroupsCreateResponse> PostV1PartnersGroupsCreateAsync(
        PostV1PartnersGroupsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersGroupsUpdateResponse> PostV1PartnersGroupsUpdateAsync(
        PostV1PartnersGroupsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersGroupsDeleteResponse> PostV1PartnersGroupsDeleteAsync(
        PostV1PartnersGroupsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersGroupsListResponse> PostV1PartnersGroupsListAsync(
        PostV1PartnersGroupsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersStatusesCreateResponse> PostV1PartnersStatusesCreateAsync(
        PostV1PartnersStatusesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersStatusesUpdateResponse> PostV1PartnersStatusesUpdateAsync(
        PostV1PartnersStatusesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersStatusesDeleteResponse> PostV1PartnersStatusesDeleteAsync(
        PostV1PartnersStatusesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersStatusesListResponse> PostV1PartnersStatusesListAsync(
        PostV1PartnersStatusesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersInquiriesCreateResponse> PostV1PartnersInquiriesCreateAsync(
        PostV1PartnersInquiriesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersInquiriesUpdateResponse> PostV1PartnersInquiriesUpdateAsync(
        PostV1PartnersInquiriesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersInquiriesGetResponse> PostV1PartnersInquiriesGetAsync(
        PostV1PartnersInquiriesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersInquiriesListResponse> PostV1PartnersInquiriesListAsync(
        PostV1PartnersInquiriesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1PartnersCreditCheckResponse> PostV1PartnersCreditCheckAsync(
        PostV1PartnersCreditCheckRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LeadsCreateResponse> PostV1LeadsCreateAsync(
        PostV1LeadsCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LeadsGetResponse> PostV1LeadsGetAsync(
        PostV1LeadsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LeadsUpdateResponse> PostV1LeadsUpdateAsync(
        PostV1LeadsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LeadsDeleteResponse> PostV1LeadsDeleteAsync(
        PostV1LeadsDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LeadsListResponse> PostV1LeadsListAsync(
        PostV1LeadsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LeadsNotesCreateResponse> PostV1LeadsNotesCreateAsync(
        PostV1LeadsNotesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LeadsNotesDeleteResponse> PostV1LeadsNotesDeleteAsync(
        PostV1LeadsNotesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LeadsNotesListResponse> PostV1LeadsNotesListAsync(
        PostV1LeadsNotesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LeadsFilesListResponse> PostV1LeadsFilesListAsync(
        PostV1LeadsFilesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LeadsSourcesCreateResponse> PostV1LeadsSourcesCreateAsync(
        PostV1LeadsSourcesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LeadsSourcesUpdateResponse> PostV1LeadsSourcesUpdateAsync(
        PostV1LeadsSourcesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LeadsSourcesDeleteResponse> PostV1LeadsSourcesDeleteAsync(
        PostV1LeadsSourcesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LeadsSourcesListResponse> PostV1LeadsSourcesListAsync(
        PostV1LeadsSourcesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1LeadsSourcesOptionsResponse> PostV1LeadsSourcesOptionsAsync(
        PostV1LeadsSourcesOptionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a customer partner from the lead, move the lead files to the partner, copy the lead notes into the partner notes and mark the lead as converted.
    /// </summary>
    WithRawResponseTask<PostV1LeadsConvertResponse> PostV1LeadsConvertAsync(
        PostV1LeadsConvertRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
