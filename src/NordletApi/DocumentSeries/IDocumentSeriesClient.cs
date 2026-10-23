namespace NordletApi;

public partial interface IDocumentSeriesClient
{
    /// <summary>
    /// Create a numbering series for sale invoices, credit notes, proformas or advance invoices (`documentType`). Numbers run from `nextNumber`, padded to `numberLength` digits, and are written as `prefix`-number or, with `printSeries` false, as the bare number; a series may be bound to an operation type (a default series of an operation type is picked for its documents that name no series) and to a warehouse, which `sales/invoices/issue` takes the goods from. `isDefault` makes it the default of its document type and clears the previous one. Answers 422 when only one end of the allocated range `allocatedFrom`..`allocatedTo` is given or the range is reversed, 409 when the prefix exists for the document type.
    /// </summary>
    WithRawResponseTask<CreateDocumentSeriesResponse> CreateAsync(
        CreateDocumentSeriesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change a document series; fields left out keep their value. `nextNumber` cannot go below its current value (409); `isDefault` clears the previous default of the document type. Answers 422 for an incomplete or reversed allocated range, 409 when the prefix is taken for the document type.
    /// </summary>
    WithRawResponseTask<UpdateDocumentSeriesResponse> UpdateAsync(
        UpdateDocumentSeriesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return one document series.
    /// </summary>
    WithRawResponseTask<GetDocumentSeriesResponse> GetAsync(
        GetDocumentSeriesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a document series no sale document uses. Answers 409 when invoices reference it; deactivate it with `isActive` instead.
    /// </summary>
    WithRawResponseTask<DeleteDocumentSeriesResponse> DeleteAsync(
        DeleteDocumentSeriesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List document series. Filterable by documentType, prefix, operationTypeId and isActive; sortable by prefix, documentType and createdAt.
    /// </summary>
    WithRawResponseTask<ListDocumentSeriesResponse> ListAsync(
        ListDocumentSeriesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
