namespace NordletApi;

public partial interface IAccountClient
{
    WithRawResponseTask<PostV1AccountLoginLinkRequestResponse> PostV1AccountLoginLinkRequestAsync(
        PostV1AccountLoginLinkRequestRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountLoginLinkConsumeResponse> PostV1AccountLoginLinkConsumeAsync(
        PostV1AccountLoginLinkConsumeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountLogoutResponse> PostV1AccountLogoutAsync(
        PostV1AccountLogoutRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountMeResponse> PostV1AccountMeAsync(
        PostV1AccountMeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountMembersListResponse> PostV1AccountMembersListAsync(
        PostV1AccountMembersListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountMembersSetRoleResponse> PostV1AccountMembersSetRoleAsync(
        PostV1AccountMembersSetRoleRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountMembersRemoveResponse> PostV1AccountMembersRemoveAsync(
        PostV1AccountMembersRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountInvitesCreateResponse> PostV1AccountInvitesCreateAsync(
        PostV1AccountInvitesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountInvitesListResponse> PostV1AccountInvitesListAsync(
        PostV1AccountInvitesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountInvitesRevokeResponse> PostV1AccountInvitesRevokeAsync(
        PostV1AccountInvitesRevokeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountInvitesGetResponse> PostV1AccountInvitesGetAsync(
        PostV1AccountInvitesGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountInvitesAcceptResponse> PostV1AccountInvitesAcceptAsync(
        PostV1AccountInvitesAcceptRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountLocaleSetResponse> PostV1AccountLocaleSetAsync(
        PostV1AccountLocaleSetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountCompaniesCreateResponse> PostV1AccountCompaniesCreateAsync(
        PostV1AccountCompaniesCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountCompaniesSelectResponse> PostV1AccountCompaniesSelectAsync(
        PostV1AccountCompaniesSelectRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountCompaniesProfileResponse> PostV1AccountCompaniesProfileAsync(
        PostV1AccountCompaniesProfileRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountCompaniesUpdateResponse> PostV1AccountCompaniesUpdateAsync(
        PostV1AccountCompaniesUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountCompaniesArchiveResponse> PostV1AccountCompaniesArchiveAsync(
        PostV1AccountCompaniesArchiveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountCompaniesDeleteResponse> PostV1AccountCompaniesDeleteAsync(
        PostV1AccountCompaniesDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountCompaniesActivateResponse> PostV1AccountCompaniesActivateAsync(
        PostV1AccountCompaniesActivateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountApiKeysCreateResponse> PostV1AccountApiKeysCreateAsync(
        PostV1AccountApiKeysCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountApiKeysListResponse> PostV1AccountApiKeysListAsync(
        PostV1AccountApiKeysListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountApiKeysRevokeResponse> PostV1AccountApiKeysRevokeAsync(
        PostV1AccountApiKeysRevokeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountConsentAcceptResponse> PostV1AccountConsentAcceptAsync(
        PostV1AccountConsentAcceptRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountProfileUpdateResponse> PostV1AccountProfileUpdateAsync(
        PostV1AccountProfileUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountEmailChangeRequestResponse> PostV1AccountEmailChangeRequestAsync(
        PostV1AccountEmailChangeRequestRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountSessionsListResponse> PostV1AccountSessionsListAsync(
        PostV1AccountSessionsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountSessionsRevokeResponse> PostV1AccountSessionsRevokeAsync(
        PostV1AccountSessionsRevokeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountSessionsRevokeOthersResponse> PostV1AccountSessionsRevokeOthersAsync(
        PostV1AccountSessionsRevokeOthersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountExportResponse> DownloadEverythingNordletStoresAboutTheSignedInUserAsync(
        PostV1AccountExportRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Removes the user: sessions, sign-in links, memberships and pending invitations are deleted at once; the email and name are replaced by an anonymous placeholder immediately and the remaining row is removed after 30 days. Refused while the user still owns or pays for a company that is not deleted.
    /// </summary>
    WithRawResponseTask<PostV1AccountDeleteResponse> DeleteTheSignedInUserAccountAsync(
        PostV1AccountDeleteRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountReferralGetResponse> PostV1AccountReferralGetAsync(
        PostV1AccountReferralGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountTableSettingsGetResponse> PostV1AccountTableSettingsGetAsync(
        PostV1AccountTableSettingsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountTableSettingsSetResponse> PostV1AccountTableSettingsSetAsync(
        PostV1AccountTableSettingsSetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PostV1AccountTableSettingsListResponse> PostV1AccountTableSettingsListAsync(
        PostV1AccountTableSettingsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
