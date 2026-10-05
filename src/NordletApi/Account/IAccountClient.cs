namespace NordletApi;

public partial interface IAccountClient
{
    WithRawResponseTask<LoginLinkRequestAccountResponse> LoginLinkRequestAsync(
        LoginLinkRequestAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<LoginLinkConsumeAccountResponse> LoginLinkConsumeAsync(
        LoginLinkConsumeAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<LogoutAccountResponse> LogoutAsync(
        LogoutAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MeAccountResponse> MeAsync(
        MeAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MembersListAccountResponse> MembersListAsync(
        MembersListAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MembersSetRoleAccountResponse> MembersSetRoleAsync(
        MembersSetRoleAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MembersTransferOwnershipAccountResponse> MembersTransferOwnershipAsync(
        MembersTransferOwnershipAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<MembersRemoveAccountResponse> MembersRemoveAsync(
        MembersRemoveAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvitesCreateAccountResponse> InvitesCreateAsync(
        InvitesCreateAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvitesListAccountResponse> InvitesListAsync(
        InvitesListAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvitesRevokeAccountResponse> InvitesRevokeAsync(
        InvitesRevokeAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvitesGetAccountResponse> InvitesGetAsync(
        InvitesGetAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<InvitesAcceptAccountResponse> InvitesAcceptAsync(
        InvitesAcceptAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<LocaleSetAccountResponse> LocaleSetAsync(
        LocaleSetAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CompaniesCreateAccountResponse> CompaniesCreateAsync(
        CompaniesCreateAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CompaniesSelectAccountResponse> CompaniesSelectAsync(
        CompaniesSelectAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CompaniesProfileAccountResponse> CompaniesProfileAsync(
        CompaniesProfileAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CompaniesUpdateAccountResponse> CompaniesUpdateAsync(
        CompaniesUpdateAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CompaniesArchiveAccountResponse> CompaniesArchiveAsync(
        CompaniesArchiveAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CompaniesDeleteAccountResponse> CompaniesDeleteAsync(
        CompaniesDeleteAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<CompaniesActivateAccountResponse> CompaniesActivateAsync(
        CompaniesActivateAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ApiKeysCreateAccountResponse> ApiKeysCreateAsync(
        ApiKeysCreateAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ApiKeysListAccountResponse> ApiKeysListAsync(
        ApiKeysListAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ApiKeysRotateAccountResponse> ApiKeysRotateAsync(
        ApiKeysRotateAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ApiKeysRevokeAccountResponse> ApiKeysRevokeAsync(
        ApiKeysRevokeAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ConsentAcceptAccountResponse> ConsentAcceptAsync(
        ConsentAcceptAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ProfileUpdateAccountResponse> ProfileUpdateAsync(
        ProfileUpdateAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EmailChangeRequestAccountResponse> EmailChangeRequestAsync(
        EmailChangeRequestAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SessionsListAccountResponse> SessionsListAsync(
        SessionsListAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SessionsRevokeAccountResponse> SessionsRevokeAsync(
        SessionsRevokeAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SessionsRevokeOthersAccountResponse> SessionsRevokeOthersAsync(
        SessionsRevokeOthersAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

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

    WithRawResponseTask<ReferralGetAccountResponse> ReferralGetAsync(
        ReferralGetAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ReferralConvertAccountResponse> ReferralConvertAsync(
        ReferralConvertAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TableSettingsGetAccountResponse> TableSettingsGetAsync(
        TableSettingsGetAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TableSettingsSetAccountResponse> TableSettingsSetAsync(
        TableSettingsSetAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TableSettingsListAccountResponse> TableSettingsListAsync(
        TableSettingsListAccountRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
