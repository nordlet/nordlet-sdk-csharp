namespace NordletApi;

public partial interface IAccountClient
{
    /// <summary>
    /// Create a sign-in link for the e-mail address and send it; the link is valid for 15 minutes and is consumed with `account/login-link/consume`. When an unused link was requested for the same address within the last minute, the call answers `sent` without sending another. `locale` sets the language of the e-mail and of the link; `app` set to `invoice` makes the link open the invoice app instead of the Nordlet app; `acceptTerms`, `acceptDpa` and `referralCode` are stored with the link and used when the address has no account yet.
    /// </summary>
    WithRawResponseTask<LoginLinkRequestAccountResponse> LoginLinkRequestAsync(
        LoginLinkRequestAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Exchange a sign-in link token for a session; an unknown, used or expired token is refused with 401. When no account has the address, one is created (`isNewUser`), which is refused with 422 unless the link was requested with `acceptTerms` and `acceptDpa`; a `referralCode` on the link records who referred the new user. A link from `account/email/change-request` changes the signed-in user's address instead, refused with 409 when another account has it.
    /// </summary>
    WithRawResponseTask<LoginLinkConsumeAccountResponse> LoginLinkConsumeAsync(
        LoginLinkConsumeAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete the session the call was made with.
    /// </summary>
    WithRawResponseTask<LogoutAccountResponse> LogoutAsync(
        LogoutAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return the signed-in user, their active company and role in it, the companies they belong to and their consent state. `billing` is the billing account that pays for the active company (its payer, or the user when there is none or no company), with `isPayer` saying whether that is the user; `referralPoints` is the user's current points balance.
    /// </summary>
    WithRawResponseTask<MeAccountResponse> MeAsync(
        MeAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the members of the active company with their role.
    /// </summary>
    WithRawResponseTask<MembersListAccountResponse> MembersListAsync(
        MembersListAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change the role of a member of the active company; owners and admins may call it. Refused with 422 for the caller's own role and with 403 for the owner's, which only `account/members/transfer-ownership` changes.
    /// </summary>
    WithRawResponseTask<MembersSetRoleAccountResponse> MembersSetRoleAsync(
        MembersSetRoleAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Make another member the owner of the active company; the caller must be its owner and becomes an admin. Refused with 422 when `userId` is the caller. With `movePayer` the company's billing also moves to the new owner, which only the member currently paying for it may do (403).
    /// </summary>
    WithRawResponseTask<MembersTransferOwnershipAccountResponse> MembersTransferOwnershipAsync(
        MembersTransferOwnershipAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Remove a member from the active company; owners and admins may call it. Their sessions lose this company as the active one and the API keys they created for it are revoked. Refused with 422 for the caller themself and with 403 for the owner.
    /// </summary>
    WithRawResponseTask<MembersRemoveAccountResponse> MembersRemoveAsync(
        MembersRemoveAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create an invitation to the active company for an e-mail address with the given role and send it by e-mail in `locale`; owners and admins may call it. The invitation is valid for 7 days and replaces an earlier pending one for the same address. Refused with 409 when the address already belongs to a member.
    /// </summary>
    WithRawResponseTask<InvitesCreateAccountResponse> InvitesCreateAsync(
        InvitesCreateAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the pending invitations of the active company; `expired` marks those past their expiry.
    /// </summary>
    WithRawResponseTask<InvitesListAccountResponse> InvitesListAsync(
        InvitesListAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a pending invitation of the active company.
    /// </summary>
    WithRawResponseTask<InvitesRevokeAccountResponse> InvitesRevokeAsync(
        InvitesRevokeAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Read a pending invitation by its token: the invited address, role and company name, whether it has expired and whether an account with that address already exists (`userExists`), in which case `account/invites/accept` must be called signed in as that account.
    /// </summary>
    WithRawResponseTask<InvitesGetAccountResponse> InvitesGetAsync(
        InvitesGetAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Accept an invitation and return a session with the invited company active. When the address has no account, one is created with `name` and `locale`, which is refused with 422 unless `acceptTerms` and `acceptDpa` are true; when it has one, the call must be made signed in as that account (401 otherwise). An expired invitation is refused with 422.
    /// </summary>
    WithRawResponseTask<InvitesAcceptAccountResponse> InvitesAcceptAsync(
        InvitesAcceptAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Set the user's language: with an active company it is stored on their membership of that company (`scope` = `membership`), otherwise on the user (`scope` = `user`).
    /// </summary>
    WithRawResponseTask<LocaleSetAccountResponse> LocaleSetAsync(
        LocaleSetAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a company with the caller as its owner and payer, seed its chart of accounts from the template of `countryCode`, and make it the active company of the session. `timeZone` defaults to the country's, `isVatPayer` to true and `defaultInvoiceCurrency` to the base currency. Refused with 422 when `baseCurrency` is not a supported currency.
    /// </summary>
    WithRawResponseTask<CompaniesCreateAccountResponse> CompaniesCreateAsync(
        CompaniesCreateAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Make one of the caller's companies the active company of the session. Refused with 403 when the caller is not a member and with 422 when the company is archived or deleted.
    /// </summary>
    WithRawResponseTask<CompaniesSelectAccountResponse> CompaniesSelectAsync(
        CompaniesSelectAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return the profile of the active company.
    /// </summary>
    WithRawResponseTask<CompaniesProfileAccountResponse> CompaniesProfileAsync(
        CompaniesProfileAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change the profile of the active company; owners and admins may call it. Only the fields sent are changed, and the nullable ones can be sent as null to clear them. `logo` stores a base64-encoded image as a file of the company and sets `logoFileId`. The country, base currency, sandbox flag and cash-basis flag are fixed at creation.
    /// </summary>
    WithRawResponseTask<CompaniesUpdateAccountResponse> CompaniesUpdateAsync(
        CompaniesUpdateAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Set the company named by `companyId` to `archived`; the caller must be its owner. Every session that had it active loses it. Refused with 409 unless the company is active; `account/companies/activate` reverses it.
    /// </summary>
    WithRawResponseTask<CompaniesArchiveAccountResponse> CompaniesArchiveAsync(
        CompaniesArchiveAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Set the company named by `companyId` to `deleted`; the caller must be its owner, and every session that had it active loses it. A sandbox company is purged at once; any other is purged by the scheduled purge after `purgeAfter` (10 days) and can be restored until then with `account/companies/activate`. Refused with 409 when it is already deleted.
    /// </summary>
    WithRawResponseTask<CompaniesDeleteAccountResponse> CompaniesDeleteAsync(
        CompaniesDeleteAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Set an archived or deleted company named by `companyId` back to `active`; the caller must be its owner. Refused with 409 when it is already active.
    /// </summary>
    WithRawResponseTask<CompaniesActivateAccountResponse> CompaniesActivateAsync(
        CompaniesActivateAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create an API key for the active company and return the key itself once; owners, admins and developers may call it. `scopes` defaults to the caller's own scopes and may not exceed them (403); without `expiresInDays` the key does not expire.
    /// </summary>
    WithRawResponseTask<ApiKeysCreateAccountResponse> ApiKeysCreateAsync(
        ApiKeysCreateAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the API keys of the active company, including expired and revoked ones.
    /// </summary>
    WithRawResponseTask<ApiKeysListAccountResponse> ApiKeysListAsync(
        ApiKeysListAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a new key with the name and scopes of the key `id` and return it once; the old key keeps working for `overlapHours` and then expires, and its `replacedByKeyId` points to the new one. `expiresInDays` applies to the new key. Refused with 409 when the old key is revoked.
    /// </summary>
    WithRawResponseTask<ApiKeysRotateAccountResponse> ApiKeysRotateAsync(
        ApiKeysRotateAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Revoke an API key of the active company at once.
    /// </summary>
    WithRawResponseTask<ApiKeysRevokeAccountResponse> ApiKeysRevokeAsync(
        ApiKeysRevokeAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Record the signed-in user's acceptance of the current Terms of Service and Data Processing Agreement versions and return the consent state.
    /// </summary>
    WithRawResponseTask<ConsentAcceptAccountResponse> ConsentAcceptAsync(
        ConsentAcceptAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Set the signed-in user's name; null or a blank string clears it.
    /// </summary>
    WithRawResponseTask<ProfileUpdateAccountResponse> ProfileUpdateAsync(
        ProfileUpdateAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Send a confirmation link to `newEmail`; the address changes when that link is consumed with `account/login-link/consume`. When an unused link was sent to the address within the last minute, the call answers `sent` without sending another. Refused with 422 when it is already the user's address and with 409 when another account has it.
    /// </summary>
    WithRawResponseTask<EmailChangeRequestAccountResponse> EmailChangeRequestAsync(
        EmailChangeRequestAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the signed-in user's sessions that have not expired; `current` marks the one the call was made with.
    /// </summary>
    WithRawResponseTask<SessionsListAccountResponse> SessionsListAsync(
        SessionsListAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete one of the signed-in user's sessions.
    /// </summary>
    WithRawResponseTask<SessionsRevokeAccountResponse> SessionsRevokeAsync(
        SessionsRevokeAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete every session of the signed-in user except the one the call was made with, and return how many were deleted.
    /// </summary>
    WithRawResponseTask<SessionsRevokeOthersAccountResponse> SessionsRevokeOthersAsync(
        SessionsRevokeOthersAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return the user's profile, consent state, memberships, unexpired sessions, billing account, credit transactions and the audit entries they made in their companies (the most recent 5000 of each of the last two).
    /// </summary>
    WithRawResponseTask<ExportAccountResponse> ExportAsync(
        ExportAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Removes the user: sessions, sign-in links, memberships and pending invitations are deleted at once; the email and name are replaced by an anonymous placeholder immediately and the remaining row is removed after 30 days. Refused while the user still owns or pays for a company that is not deleted.
    /// </summary>
    WithRawResponseTask<DeleteAccountResponse> DeleteAsync(
        DeleteAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return the user's referral code (allocated on first call) and sign-up link, their points balance, the number of accounts they referred and the last 50 points entries. `rates.perEur` is the points the referrer earns per euro a referred user tops up, `rates.pointCents` the credit one point converts to with `account/referral/convert`.
    /// </summary>
    WithRawResponseTask<ReferralGetAccountResponse> ReferralGetAsync(
        ReferralGetAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Convert `points` of the user's referral points into credit on their billing account at `rates.pointCents` per point, booked as an `adjustment` credit transaction; a billing account past its trial is set to active when the new balance allows. Refused with 422 when the user has fewer points than requested.
    /// </summary>
    WithRawResponseTask<ReferralConvertAccountResponse> ReferralConvertAsync(
        ReferralConvertAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return the signed-in user's saved column list and page size for the table `tableKey`; both are null when nothing is saved.
    /// </summary>
    WithRawResponseTask<TableSettingsGetAccountResponse> TableSettingsGetAsync(
        TableSettingsGetAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Save the signed-in user's column list and page size for the table `tableKey`; only the fields sent are changed, and null clears one.
    /// </summary>
    WithRawResponseTask<TableSettingsSetAccountResponse> TableSettingsSetAsync(
        TableSettingsSetAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the signed-in user's saved table settings.
    /// </summary>
    WithRawResponseTask<TableSettingsListAccountResponse> TableSettingsListAsync(
        TableSettingsListAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
