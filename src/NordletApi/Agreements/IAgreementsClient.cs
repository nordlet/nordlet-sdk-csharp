namespace NordletApi;

public partial interface IAgreementsClient
{
    /// <summary>
    /// Return whether automatic agreement billing is switched on for the company.
    /// </summary>
    WithRawResponseTask<SettingsGetAgreementsResponse> SettingsGetAsync(
        SettingsGetAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Switch automatic agreement billing on or off for the company. With it on, a scheduled job runs the same billing as `agreements/agreements/billing/run` for the company once a day.
    /// </summary>
    WithRawResponseTask<SettingsUpdateAgreementsResponse> SettingsUpdateAsync(
        SettingsUpdateAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create an agreement type with a `code` and a `name`. Answers 409 when the company already has a type with that code.
    /// </summary>
    WithRawResponseTask<TypesCreateAgreementsResponse> TypesCreateAsync(
        TypesCreateAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the company's agreement types. Filterable and sortable by `code` and `name`.
    /// </summary>
    WithRawResponseTask<TypesListAgreementsResponse> TypesListAsync(
        TypesListAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create an agreement for exactly one party, a partner, an employee or a bank account, which must exist in the company (400 otherwise). Without `kind`, an employee agreement is `employment`, a bank account agreement is `bank` and a partner agreement is `other`; a `documentRef` (the `storageKey` of an uploaded file) attaches that file to the agreement. Answers 409 when the company already has an agreement with that `number`.
    /// </summary>
    WithRawResponseTask<AgreementsCreateAgreementsResponse> AgreementsCreateAsync(
        AgreementsCreateAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return one agreement with its items.
    /// </summary>
    WithRawResponseTask<AgreementsGetAgreementsResponse> AgreementsGetAsync(
        AgreementsGetAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Change the given fields of an agreement and return it with its items. The party, `number`, `startDate`, `currency` and items are not changed by this call.
    /// </summary>
    WithRawResponseTask<AgreementsUpdateAgreementsResponse> AgreementsUpdateAsync(
        AgreementsUpdateAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Mark an agreement as deleted. It is no longer returned, changed or billed.
    /// </summary>
    WithRawResponseTask<AgreementsDeleteAgreementsResponse> AgreementsDeleteAsync(
        AgreementsDeleteAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the company's agreements without their items, each with `partnerName`. Filterable by `number`, `name`, `partnerId`, `employeeId`, `bankAccountId`, `kind`, `typeId`, `status`, `startDate`, `endDate` and `value`; sortable by `number`, `startDate`, `createdAt`, `name`, `partyName` (the partner name, else the employee name, else the bank account name), `kind`, `endDate`, `status`, `value` and `documentRef` (default `startDate` descending).
    /// </summary>
    WithRawResponseTask<AgreementsListAgreementsResponse> AgreementsListAsync(
        AgreementsListAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a draft sale invoice for the next unbilled period of an active agreement that has a partner and a `billingPeriod`. The period follows the monthly, quarterly or annual grid from `startDate`, continues after the last period already invoiced for the agreement, and is prorated by days when it starts late or is cut by `endDate`; an `autoRenew` agreement has its `endDate` moved forward by whole terms instead (`renewedEndDate`). The lines come from the agreement items, else one line of `value`, with revenue recognised ratably over the period. Answers 422 when the agreement is not active, has no partner, billing period, items or value, carries VAT while the company is not a VAT payer, is fully billed through its end date, or when the next period starts after `asOfDate` (default today). Emits `agreement.invoice_generated`.
    /// </summary>
    WithRawResponseTask<AgreementsGenerateInvoiceAgreementsResponse> AgreementsGenerateInvoiceAsync(
        AgreementsGenerateInvoiceAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// The schedule of the supplier invoices an agreement with a `billingPeriod` leads you to expect, such as a lease: each period from `startDate` up to `to` (default today), on the grid of `agreements/agreements/generate-invoice` (prorated by days when cut by `endDate`, an `autoRenew` agreement continuing by whole terms), with `expectedNet`, the sum of quantity times unit price of the agreement items, else `value`, times the prorated share, rounded to the cent (null when an item has no unit price or the agreement has neither), and the purchase invoices registered for the period: those created or updated with this `agreementId` and the period's `periodStart` as `agreementPeriodStart`. A period without one is `missing`. Answers 404 for an unknown agreement and 422 when it has no `billingPeriod`.
    /// </summary>
    WithRawResponseTask<AgreementsExpectedInvoicesAgreementsResponse> AgreementsExpectedInvoicesAsync(
        AgreementsExpectedInvoicesAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Keep the repayment schedule of a loan or lease agreement as the lender or lessor gives it: one row per instalment with its `dueDate`, the `principal` it repays and the `interest` it pays. The rows replace the agreement's earlier schedule; an empty list removes it. Nordlet does not compute instalments, because the interest rate, day count and rounding are the lender's. Answers 404 for an unknown agreement and 422 when two rows have the same `dueDate`.
    /// </summary>
    WithRawResponseTask<AgreementsPaymentScheduleSetAgreementsResponse> AgreementsPaymentScheduleSetAsync(
        AgreementsPaymentScheduleSetAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// The repayment schedule kept with `agreements/agreements/payment-schedule/set`, by due date, with each instalment's total and, when the agreement has a `value` (the amount lent or financed), the principal outstanding after it. Answers 404 for an unknown agreement.
    /// </summary>
    WithRawResponseTask<AgreementsPaymentScheduleGetAgreementsResponse> AgreementsPaymentScheduleGetAsync(
        AgreementsPaymentScheduleGetAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generate the invoices due up to `asOfDate` (default today) for every active agreement of the company that has a partner and a billing period, one invoice per period and at most 60 per agreement in one run, in the same way as `agreements/agreements/generate-invoice`. An agreement that is fully billed and whose `endDate` has passed is set to `expired`. A failing agreement is listed in `errors` and does not stop the run. Each invoice emits `agreement.invoice_generated`.
    /// </summary>
    WithRawResponseTask<AgreementsBillingRunAgreementsResponse> AgreementsBillingRunAsync(
        AgreementsBillingRunAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create an insurance policy. Answers 422 when `toDate` is before `fromDate`, 400 when `insurerPartnerId` is not a partner of the company, and 409 when the company already has a policy with that `policyNumber`.
    /// </summary>
    WithRawResponseTask<InsurancePoliciesCreateAgreementsResponse> InsurancePoliciesCreateAsync(
        InsurancePoliciesCreateAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the company's insurance policies. Filterable by `policyNumber`, `insurerPartnerId` and `toDate`; sortable by `policyNumber` and `toDate` (default `toDate` descending).
    /// </summary>
    WithRawResponseTask<InsurancePoliciesListAgreementsResponse> InsurancePoliciesListAsync(
        InsurancePoliciesListAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Mark an insurance policy as deleted.
    /// </summary>
    WithRawResponseTask<InsurancePoliciesDeleteAgreementsResponse> InsurancePoliciesDeleteAsync(
        InsurancePoliciesDeleteAgreementsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
