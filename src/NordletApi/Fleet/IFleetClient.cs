namespace NordletApi;

public partial interface IFleetClient
{
    /// <summary>
    /// Register a vehicle. The plate number is stored in upper case and must be unique in the company (409 otherwise); `fixedAssetId` must name an existing fixed asset. Uploaded `documents` are attached to the vehicle.
    /// </summary>
    WithRawResponseTask<VehiclesCreateFleetResponse> VehiclesCreateAsync(
        VehiclesCreateFleetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change a vehicle's details or set its `status` to `active`, `sold` or `scrapped`; omitted fields keep their value. A plate number already used by another vehicle is refused with 409.
    /// </summary>
    WithRawResponseTask<VehiclesUpdateFleetResponse> VehiclesUpdateAsync(
        VehiclesUpdateFleetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Read one vehicle with its current assignment, when an employee holds it today.
    /// </summary>
    WithRawResponseTask<VehiclesGetFleetResponse> VehiclesGetAsync(
        VehiclesGetFleetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List vehicles with their current assignment. Filterable by `plateNumber`, `make`, `model` and `status`; sortable by `plateNumber`, `make` and `createdAt`.
    /// </summary>
    WithRawResponseTask<VehiclesListFleetResponse> VehiclesListAsync(
        VehiclesListFleetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Assign a vehicle to an employee from `fromDate`, open-ended or until `toDate`. A period that overlaps another assignment of the same vehicle is refused with 409, a `toDate` before `fromDate` with 422. `privateUse` makes the car a benefit in kind in `fleet/natura/preview`, and `employerPaysFuel` picks its rate.
    /// </summary>
    WithRawResponseTask<AssignmentsCreateFleetResponse> AssignmentsCreateAsync(
        AssignmentsCreateFleetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// End an open assignment on `toDate`. An assignment that already has an end date is refused with 409, a `toDate` before its `fromDate` with 422.
    /// </summary>
    WithRawResponseTask<AssignmentsEndFleetResponse> AssignmentsEndAsync(
        AssignmentsEndFleetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List vehicle assignments with the plate number and the employee's name. Filterable by `vehicleId`, `employeeId` and `privateUse`; sortable by `fromDate` and `createdAt`.
    /// </summary>
    WithRawResponseTask<AssignmentsListFleetResponse> AssignmentsListAsync(
        AssignmentsListFleetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Preview the car benefit in kind of a month for a Lithuanian company: every assignment with `privateUse` that overlaps the month is valued at 0.75 % of the vehicle's market value when the employer pays the fuel, else 0.70 %, one row per employee and vehicle, with the total. A company registered in another country is refused with 422. The same amounts are added to a payroll run created with `includeNatura` (`payroll/runs/create`).
    /// </summary>
    WithRawResponseTask<NaturaPreviewFleetResponse> NaturaPreviewAsync(
        NaturaPreviewFleetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
