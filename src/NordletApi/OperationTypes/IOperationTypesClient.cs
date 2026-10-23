namespace NordletApi;

public partial interface IOperationTypesClient
{
    /// <summary>
    /// Create an operation type: a `code` with the flags that say what it is for (`isSale`, `isPurchase`, ...), an optional `invoiceType` (`invoice`, `credit_note`, `proforma`, `advance`) and optional account codes. An invoice names it in `operationTypeId`: a sale invoice needs `isSale` and a matching `invoiceType`, a purchase invoice `isPurchase`, and the type's account codes then replace the default posting accounts when the invoice is issued (`sales/invoices/issue`) or registered (`purchases/invoices/register`). `includeInVatRegister: false` keeps the type's invoices out of the Lithuanian i.SAF and FR0600, `includeInSaft: false` out of the SAF-T file. Account codes must exist and be postable and `payerPartnerId` must be an active partner (422 otherwise); a repeated `code` is refused with 409.
    /// </summary>
    WithRawResponseTask<CreateOperationTypesResponse> CreateAsync(
        CreateOperationTypesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change an operation type's fields; omitted ones keep their value. A `code` already used by another type is refused with 409, a body without changes with 400.
    /// </summary>
    WithRawResponseTask<UpdateOperationTypesResponse> UpdateAsync(
        UpdateOperationTypesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Read one operation type.
    /// </summary>
    WithRawResponseTask<GetOperationTypesResponse> GetAsync(
        GetOperationTypesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete an operation type that no sale invoice, purchase invoice or document series refers to. Otherwise the call is refused with 409; deactivate the type with `operation-types/update` instead.
    /// </summary>
    WithRawResponseTask<DeleteOperationTypesResponse> DeleteAsync(
        DeleteOperationTypesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List operation types. Filterable by `code`, `name`, `isSale`, `isPurchase` and `isActive`; sortable by `code`, `name`, `sortOrder` and `createdAt`.
    /// </summary>
    WithRawResponseTask<ListOperationTypesResponse> ListAsync(
        ListOperationTypesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
