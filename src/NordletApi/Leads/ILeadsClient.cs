namespace NordletApi;

public partial interface ILeadsClient
{
    /// <summary>
    /// Creates a lead in status `new`, `contacted`, `qualified` or `lost`. `assignedUserId` must be a member of the company and `sourceId` and `typeId` must exist in it; `countryCode` and `currency` are stored in upper case; `documents` attach uploaded files not yet linked to a record, and `notes` become the lead's first notes with the caller as author. Emits `lead.created`.
    /// </summary>
    WithRawResponseTask<CreateLeadsResponse> CreateAsync(
        CreateLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns one lead with its source and type names.
    /// </summary>
    WithRawResponseTask<GetLeadsResponse> GetAsync(
        GetLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the given fields of a lead; the clearable fields accept null, `documents` attach more uploaded files, and `countryCode` and `currency` are stored in upper case. A lead that is already converted cannot change `status` (409).
    /// </summary>
    WithRawResponseTask<UpdateLeadsResponse> UpdateAsync(
        UpdateLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a lead with its notes and detaches its files, which stay in the company's files without a record.
    /// </summary>
    WithRawResponseTask<DeleteLeadsResponse> DeleteAsync(
        DeleteLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists leads with their source and type names; filterable by `name`, `contactName`, `email`, `phone`, `status`, `sourceId`, `typeId`, `countryCode`, `assignedUserId`, `partnerId`, `estimatedValue` and `createdAt`, sortable by `name`, `status`, `estimatedValue`, `createdAt` and `updatedAt`.
    /// </summary>
    WithRawResponseTask<ListLeadsResponse> ListAsync(
        ListLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Adds a note to a lead with the caller as author and refreshes the lead's `updatedAt`.
    /// </summary>
    WithRawResponseTask<NotesCreateLeadsResponse> NotesCreateAsync(
        NotesCreateLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a lead note.
    /// </summary>
    WithRawResponseTask<NotesDeleteLeadsResponse> NotesDeleteAsync(
        NotesDeleteLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the notes of a lead, newest first.
    /// </summary>
    WithRawResponseTask<NotesListLeadsResponse> NotesListAsync(
        NotesListLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the files attached to a lead, newest first.
    /// </summary>
    WithRawResponseTask<FilesListLeadsResponse> FilesListAsync(
        FilesListLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a lead source; a `name` already used by a source of the company is refused with 409.
    /// </summary>
    WithRawResponseTask<SourcesCreateLeadsResponse> SourcesCreateAsync(
        SourcesCreateLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the name or `isActive` flag of a lead source; a name already used by another source of the company is refused with 409.
    /// </summary>
    WithRawResponseTask<SourcesUpdateLeadsResponse> SourcesUpdateAsync(
        SourcesUpdateLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a lead source; one still referenced by a lead is refused with 409 and should be deactivated with `leads/sources/update` instead.
    /// </summary>
    WithRawResponseTask<SourcesDeleteLeadsResponse> SourcesDeleteAsync(
        SourcesDeleteLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists all lead sources of the company, active and inactive, ordered by name.
    /// </summary>
    WithRawResponseTask<SourcesListLeadsResponse> SourcesListAsync(
        SourcesListLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the id and name of the active lead sources, ordered by name.
    /// </summary>
    WithRawResponseTask<SourcesOptionsLeadsResponse> SourcesOptionsAsync(
        SourcesOptionsLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a lead type; a `name` already used by a type of the company is refused with 409.
    /// </summary>
    WithRawResponseTask<TypesCreateLeadsResponse> TypesCreateAsync(
        TypesCreateLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Changes the name or `isActive` flag of a lead type; a name already used by another type of the company is refused with 409.
    /// </summary>
    WithRawResponseTask<TypesUpdateLeadsResponse> TypesUpdateAsync(
        TypesUpdateLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes a lead type; one still referenced by a lead is refused with 409 and should be deactivated with `leads/types/update` instead.
    /// </summary>
    WithRawResponseTask<TypesDeleteLeadsResponse> TypesDeleteAsync(
        TypesDeleteLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists all lead types of the company, active and inactive, ordered by name.
    /// </summary>
    WithRawResponseTask<TypesListLeadsResponse> TypesListAsync(
        TypesListLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lists the id and name of the active lead types, ordered by name.
    /// </summary>
    WithRawResponseTask<TypesOptionsLeadsResponse> TypesOptionsAsync(
        TypesOptionsLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a customer partner from the lead, move the lead files to the partner, copy the lead notes into the partner notes and mark the lead as converted.
    /// </summary>
    WithRawResponseTask<ConvertLeadsResponse> ConvertAsync(
        ConvertLeadsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
