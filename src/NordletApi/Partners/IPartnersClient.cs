namespace NordletApi;

public partial interface IPartnersClient
{
    WithRawResponseTask<AddressesCreatePartnersResponse> AddressesCreateAsync(
        AddressesCreatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AddressesUpdatePartnersResponse> AddressesUpdateAsync(
        AddressesUpdatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AddressesDeletePartnersResponse> AddressesDeleteAsync(
        AddressesDeletePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<AddressesListPartnersResponse> AddressesListAsync(
        AddressesListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ContactsCreatePartnersResponse> ContactsCreateAsync(
        ContactsCreatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ContactsUpdatePartnersResponse> ContactsUpdateAsync(
        ContactsUpdatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ContactsDeletePartnersResponse> ContactsDeleteAsync(
        ContactsDeletePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ContactsListPartnersResponse> ContactsListAsync(
        ContactsListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<BankAccountsCreatePartnersResponse> BankAccountsCreateAsync(
        BankAccountsCreatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<BankAccountsUpdatePartnersResponse> BankAccountsUpdateAsync(
        BankAccountsUpdatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<BankAccountsDeletePartnersResponse> BankAccountsDeleteAsync(
        BankAccountsDeletePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<BankAccountsListPartnersResponse> BankAccountsListAsync(
        BankAccountsListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FilesListPartnersResponse> FilesListAsync(
        FilesListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DebtRemindersPreviewPartnersResponse> DebtRemindersPreviewAsync(
        DebtRemindersPreviewPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DebtRemindersListPartnersResponse> DebtRemindersListAsync(
        DebtRemindersListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ValidateVatPartnersResponse> ValidateVatAsync(
        ValidateVatPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<VatReviewsListPartnersResponse> VatReviewsListAsync(
        VatReviewsListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<VatReviewsResolvePartnersResponse> VatReviewsResolveAsync(
        VatReviewsResolvePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CreatePartnersResponse> CreateAsync(
        CreatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<FindOrCreatePartnersResponse> FindOrCreateAsync(
        FindOrCreatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GetPartnersResponse> GetAsync(
        GetPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<UpdatePartnersResponse> UpdateAsync(
        UpdatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<DeletePartnersResponse> DeleteAsync(
        DeletePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MergePartnersResponse> MergeAsync(
        MergePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Removes birth date, self-employment certificate number, email, phone, address, notes, contacts, addresses and bank accounts, then hides the partner. The name, code and VAT number stay because issued invoices must keep identifying the counterparty for the statutory retention period.
    /// </summary>
    WithRawResponseTask<AnonymizePartnersResponse> AnonymizeAsync(
        AnonymizePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ListPartnersResponse> ListAsync(
        ListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GroupsCreatePartnersResponse> GroupsCreateAsync(
        GroupsCreatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GroupsUpdatePartnersResponse> GroupsUpdateAsync(
        GroupsUpdatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GroupsDeletePartnersResponse> GroupsDeleteAsync(
        GroupsDeletePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<GroupsListPartnersResponse> GroupsListAsync(
        GroupsListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StatusesCreatePartnersResponse> StatusesCreateAsync(
        StatusesCreatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StatusesUpdatePartnersResponse> StatusesUpdateAsync(
        StatusesUpdatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StatusesDeletePartnersResponse> StatusesDeleteAsync(
        StatusesDeletePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<StatusesListPartnersResponse> StatusesListAsync(
        StatusesListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InquiriesCreatePartnersResponse> InquiriesCreateAsync(
        InquiriesCreatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InquiriesUpdatePartnersResponse> InquiriesUpdateAsync(
        InquiriesUpdatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InquiriesGetPartnersResponse> InquiriesGetAsync(
        InquiriesGetPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InquiriesListPartnersResponse> InquiriesListAsync(
        InquiriesListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CreditCheckPartnersResponse> CreditCheckAsync(
        CreditCheckPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
