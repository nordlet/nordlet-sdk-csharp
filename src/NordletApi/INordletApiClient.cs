namespace NordletApi;

public partial interface INordletApiClient
{
    public IReferenceClient Reference { get; }
    public IPartnersClient Partners { get; }
    public ICatalogClient Catalog { get; }
    public ISalesClient Sales { get; }
    public IPurchasesClient Purchases { get; }
    public IDeclarationsClient Declarations { get; }
    public ILedgerClient Ledger { get; }
    public IAssetsClient Assets { get; }
    public IHrClient Hr { get; }
    public IPayrollClient Payroll { get; }
    public IAgreementsClient Agreements { get; }
    public IInventoryClient Inventory { get; }
    public IProductionClient Production { get; }
    public IEcommerceClient Ecommerce { get; }
    public ICashClient Cash { get; }
    public ITransportClient Transport { get; }
    public IPosClient Pos { get; }
    public IAuditClient Audit { get; }
    public IWebhooksClient Webhooks { get; }
    public IBankClient Bank { get; }
    public IFilesClient Files { get; }
    public IReportsClient Reports { get; }
    public IConsolidationClient Consolidation { get; }
    public IPublicClient Public { get; }
    public IAccountClient Account { get; }
}
