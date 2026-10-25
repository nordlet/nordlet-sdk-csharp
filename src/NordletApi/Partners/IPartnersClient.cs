namespace NordletApi;

public partial interface IPartnersClient
{
    /// <summary>
    /// Adds an address of type billing, shipping, registered or other to the partner in `partnerId`.
    /// </summary>
    WithRawResponseTask<AddressesCreatePartnersResponse> AddressesCreateAsync(
        AddressesCreatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the given fields of a partner address.
    /// </summary>
    WithRawResponseTask<AddressesUpdatePartnersResponse> AddressesUpdateAsync(
        AddressesUpdatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a partner address.
    /// </summary>
    WithRawResponseTask<AddressesDeletePartnersResponse> AddressesDeleteAsync(
        AddressesDeletePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists partner addresses; filterable by `partnerId`, `type` and `city`, sortable by `createdAt`.
    /// </summary>
    WithRawResponseTask<AddressesListPartnersResponse> AddressesListAsync(
        AddressesListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Adds a contact person to the partner in `partnerId`.
    /// </summary>
    WithRawResponseTask<ContactsCreatePartnersResponse> ContactsCreateAsync(
        ContactsCreatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the given fields of a partner contact.
    /// </summary>
    WithRawResponseTask<ContactsUpdatePartnersResponse> ContactsUpdateAsync(
        ContactsUpdatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a partner contact.
    /// </summary>
    WithRawResponseTask<ContactsDeletePartnersResponse> ContactsDeleteAsync(
        ContactsDeletePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists partner contacts; filterable by `partnerId`, `name` and `email`, sortable by `createdAt`.
    /// </summary>
    WithRawResponseTask<ContactsListPartnersResponse> ContactsListAsync(
        ContactsListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Adds a bank account to the partner in `partnerId`. The IBAN is stored without spaces in upper case; an IBAN the partner already has is refused with 409. With `isDefault` true the partner's other accounts lose their default mark.
    /// </summary>
    WithRawResponseTask<BankAccountsCreatePartnersResponse> BankAccountsCreateAsync(
        BankAccountsCreatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the given fields of a partner bank account. A new IBAN is stored without spaces in upper case and is refused with 409 when the partner already has it; when the account is the default after the change, the partner's other accounts lose their default mark.
    /// </summary>
    WithRawResponseTask<BankAccountsUpdatePartnersResponse> BankAccountsUpdateAsync(
        BankAccountsUpdatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a partner bank account.
    /// </summary>
    WithRawResponseTask<BankAccountsDeletePartnersResponse> BankAccountsDeleteAsync(
        BankAccountsDeletePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists partner bank accounts; filterable by `partnerId` and `iban`, sortable by `createdAt`.
    /// </summary>
    WithRawResponseTask<BankAccountsListPartnersResponse> BankAccountsListAsync(
        BankAccountsListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the files attached to a partner, newest first. `partners/create` attaches one with `documentRef`, and `leads/convert` moves the lead's files here.
    /// </summary>
    WithRawResponseTask<FilesListPartnersResponse> FilesListAsync(
        FilesListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Runs the overdue selection of the daily debt-reminder job for this company as of the company's current date and returns the overdue reminders it would send, without sending or recording anything. A partner is included when it has `autoDebtReminder`, is active, has an e-mail address, got no overdue reminder in the last `repeatDays` days (`partners/debt-reminders/settings/get`) and has issued invoices or advance invoices with `debtRemindersEnabled` past their due date with an unpaid remainder; the interest per invoice is the remainder times the partner's `lateInterestPercent` times the days late over 365, and the totals are per currency. Sent reminders are listed by `partners/debt-reminders/list`.
    /// </summary>
    WithRawResponseTask<DebtRemindersPreviewPartnersResponse> DebtRemindersPreviewAsync(
        DebtRemindersPreviewPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the debt reminders the daily job has sent, one row per partner and currency with the ids of the invoices it covered and its `kind` (`before_due` or `overdue`); filterable by `partnerId`, sortable by `sentAt`.
    /// </summary>
    WithRawResponseTask<DebtRemindersListPartnersResponse> DebtRemindersListAsync(
        DebtRemindersListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the debt-reminder schedule of the company: `daysBefore`, the days before the due date on which the first reminder is sent (null when no reminder is sent before the due date), and `repeatDays`, the days between overdue reminders to a partner.
    /// </summary>
    WithRawResponseTask<DebtRemindersSettingsGetPartnersResponse> DebtRemindersSettingsGetAsync(
        DebtRemindersSettingsGetPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the given fields of the company's debt-reminder schedule. `daysBefore` (1 to 90, or null to send nothing before the due date) makes the daily job send one "payment due soon" reminder per invoice that many days before its due date; `repeatDays` (1 to 90) is the number of days between overdue reminders to a partner. Only partners with `autoDebtReminder` get reminders, and only for invoices with `debtRemindersEnabled`. A body without fields is refused with 400.
    /// </summary>
    WithRawResponseTask<DebtRemindersSettingsUpdatePartnersResponse> DebtRemindersSettingsUpdateAsync(
        DebtRemindersSettingsUpdatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the next reminder the daily debt-reminder job would send for each unpaid issued invoice or advance invoice with `debtRemindersEnabled` of the partners that get reminders (`autoDebtReminder`, active, with an e-mail address), as of the company's current date and sorted by `date`. A `before_due` reminder is sent once per invoice, `daysBefore` days before its due date or on the first daily run after that while the due date is still ahead; `overdue` reminders start the day after the due date and repeat every `repeatDays` days per partner, counting only overdue reminders. Nothing is sent or recorded.
    /// </summary>
    WithRawResponseTask<DebtRemindersUpcomingPartnersResponse> DebtRemindersUpcomingAsync(
        DebtRemindersUpcomingPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Checks a VAT number against VIES, either a free `vatCode` or the VAT code of the partner in `partnerId` (exactly one of the two); a code without an EU country prefix and 2 to 12 alphanumeric characters is refused with 422, as is a partner without a VAT code, and a VIES outage answers 503. With a partner the outcome is written to it (`vatValid`, `vatValidatedAt`): an invalid number or a VIES name that shares no word with the partner's name opens or refreshes the partner's VAT review (`vat_review.opened`), a VIES failure opens one with reason `service_error`, and a valid matching number resolves the open review as `revalidated` (`vat_review.resolved`). Reviews are listed and closed with `partners/vat-reviews/list` and `partners/vat-reviews/resolve`.
    /// </summary>
    WithRawResponseTask<ValidateVatPartnersResponse> ValidateVatAsync(
        ValidateVatPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the VAT reviews opened by VIES checks of partners' VAT codes, with reason `invalid`, `name_mismatch` or `service_error`; filterable by `partnerId`, `status` and `reason`, sortable by `createdAt`.
    /// </summary>
    WithRawResponseTask<VatReviewsListPartnersResponse> VatReviewsListAsync(
        VatReviewsListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Closes an open VAT review as `confirmed_valid`, `confirmed_invalid` or `dismissed`, with an optional note. The first two also set the partner's `vatValid` and stamp `vatValidatedAt` when the partner still carries the reviewed VAT code; `dismissed` leaves the partner unchanged. A review that is already resolved answers 409; emits `vat_review.resolved`.
    /// </summary>
    WithRawResponseTask<VatReviewsResolvePartnersResponse> VatReviewsResolveAsync(
        VatReviewsResolvePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a partner. `groupId`, `statusId` and `priceListId` must belong to the company; without `legalCountryClass` the class is derived from the address country (`lt`, `eu` or `non_eu`); `documentRef` attaches an uploaded file that is not yet linked to a record; a `code` already used by a live partner of the company is refused with 409. A `vatCode` is checked against VIES at once and the result stored on the partner: an invalid number, a VIES name that shares no word with the partner's name, or a VIES failure opens a VAT review (`vat_review.opened`), while a code that is not an EU VAT number is stored unchecked (see `partners/validate-vat`).
    /// </summary>
    WithRawResponseTask<CreatePartnersResponse> CreateAsync(
        CreatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the live partner matched by `code`, then `vatCode`, then `email` (at least one is required), or creates one from the body with the same validation and VIES check as `partners/create`; `created` says which happened. A creation that loses a race on the partner code returns the partner the other call created.
    /// </summary>
    WithRawResponseTask<FindOrCreatePartnersResponse> FindOrCreateAsync(
        FindOrCreatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns one partner; a deleted partner answers 404.
    /// </summary>
    WithRawResponseTask<GetPartnersResponse> GetAsync(
        GetPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the given fields of a partner; the clearable fields accept null. A new address country re-derives `legalCountryClass` unless the class is given, and a `code` already used by another live partner of the company is refused with 409. A changed `vatCode` resets the VIES result and is checked at once as in `partners/create`; a removed code, or one that is not an EU VAT number, resolves the partner's open VAT review as `superseded` (`vat_review.resolved`).
    /// </summary>
    WithRawResponseTask<UpdatePartnersResponse> UpdateAsync(
        UpdatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Marks a partner as deleted; it no longer appears in lists or lookups.
    /// </summary>
    WithRawResponseTask<DeletePartnersResponse> DeleteAsync(
        DeletePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Moves every row that references the duplicate `sourceId` through a foreign key to partners (looked up in the database catalogue, within the company) to `targetId`, then marks the source partner as deleted; `moved` lists the tables, columns and row counts. Merging a partner into itself is 422, and when both partners hold the same unique entry (for example the same IBAN or item supplier row) the merge is refused with 409 until it is removed from one of them. When the kept partner has an open VAT review, the duplicate's open review is resolved as `superseded` (`vat_review.resolved`).
    /// </summary>
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

    /// <summary>
    /// Lists live partners; filterable by `name`, `code`, `vatCode`, `email`, `type`, `isCustomer`, `isSupplier`, `isActive`, `legalCountryClass`, `isEmployee`, `groupId`, `statusId` and `nextCallDate`, sortable by `name`, `code`, `createdAt`, `nextCallDate` and `rating`.
    /// </summary>
    WithRawResponseTask<ListPartnersResponse> ListAsync(
        ListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a partner group; a `code` already used by a group of the company is refused with 409.
    /// </summary>
    WithRawResponseTask<GroupsCreatePartnersResponse> GroupsCreateAsync(
        GroupsCreatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the code or name of a partner group; a code already used by another group of the company is refused with 409.
    /// </summary>
    WithRawResponseTask<GroupsUpdatePartnersResponse> GroupsUpdateAsync(
        GroupsUpdatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a partner group; a group still assigned to a live partner is refused with 409.
    /// </summary>
    WithRawResponseTask<GroupsDeletePartnersResponse> GroupsDeleteAsync(
        GroupsDeletePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the company's partner groups ordered by code.
    /// </summary>
    WithRawResponseTask<GroupsListPartnersResponse> GroupsListAsync(
        GroupsListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a partner status with a `sortOrder`; a `code` already used by a status of the company is refused with 409.
    /// </summary>
    WithRawResponseTask<StatusesCreatePartnersResponse> StatusesCreateAsync(
        StatusesCreatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the code, name or sort order of a partner status; a code already used by another status of the company is refused with 409.
    /// </summary>
    WithRawResponseTask<StatusesUpdatePartnersResponse> StatusesUpdateAsync(
        StatusesUpdatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a partner status; a status still assigned to a live partner is refused with 409.
    /// </summary>
    WithRawResponseTask<StatusesDeletePartnersResponse> StatusesDeleteAsync(
        StatusesDeletePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the company's partner statuses ordered by sort order, then code.
    /// </summary>
    WithRawResponseTask<StatusesListPartnersResponse> StatusesListAsync(
        StatusesListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Records an inquiry in status `new`, from a partner (`partnerId`) or from a contact given by `contactName` or `contactEmail`; without any of the three it is refused with 422. `assignedUserId` must be a member of the company. Emits `partner_inquiry.created`.
    /// </summary>
    WithRawResponseTask<InquiriesCreatePartnersResponse> InquiriesCreateAsync(
        InquiriesCreatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the given fields of an inquiry; `partnerId` and `assignedUserId` accept null. Setting `status` to `closed` stamps `closedAt`, and moving a closed inquiry to another status clears it.
    /// </summary>
    WithRawResponseTask<InquiriesUpdatePartnersResponse> InquiriesUpdateAsync(
        InquiriesUpdatePartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns one inquiry with the name of its partner.
    /// </summary>
    WithRawResponseTask<InquiriesGetPartnersResponse> InquiriesGetAsync(
        InquiriesGetPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists inquiries with their partner names; filterable by `status`, `channel`, `partnerId`, `assignedUserId` and `subject`, sortable by `createdAt` and `updatedAt`.
    /// </summary>
    WithRawResponseTask<InquiriesListPartnersResponse> InquiriesListAsync(
        InquiriesListPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Compares a partner's open receivables plus an optional `additionalAmount` with its `creditLimit`. The open receivables are the unpaid remainder of the partner's issued invoices, advance invoices and credit notes (credit notes negative), converted to the company's base currency at each invoice's `fxRate`. Without a credit limit `available` is null and `exceeded` is false.
    /// </summary>
    WithRawResponseTask<CreditCheckPartnersResponse> CreditCheckAsync(
        CreditCheckPartnersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
