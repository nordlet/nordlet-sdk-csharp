using NordletApi.Core;

namespace NordletApi;

public partial class NordletApiClient : INordletApiClient
{
    private readonly RawClient _client;

    public NordletApiClient(string? token = null, ClientOptions? clientOptions = null)
    {
        clientOptions ??= new ClientOptions();
        var platformHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "NordletApi" },
                { "X-Fern-SDK-Version", Version.Current },
            }
        );
        foreach (var header in platformHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        var clientOptionsWithAuth = clientOptions.Clone();
        var authHeaders = new Headers(
            new Dictionary<string, string>() { { "Authorization", $"Bearer {token ?? ""}" } }
        );
        foreach (var header in authHeaders)
        {
            clientOptionsWithAuth.Headers[header.Key] = header.Value;
        }
        _client = new RawClient(clientOptionsWithAuth);
        Reference = new ReferenceClient(_client);
        Partners = new PartnersClient(_client);
        Catalog = new CatalogClient(_client);
        Sales = new SalesClient(_client);
        Purchases = new PurchasesClient(_client);
        Capture = new CaptureClient(_client);
        Declarations = new DeclarationsClient(_client);
        Ledger = new LedgerClient(_client);
        Migration = new MigrationClient(_client);
        Assets = new AssetsClient(_client);
        Hr = new HrClient(_client);
        Fleet = new FleetClient(_client);
        Payroll = new PayrollClient(_client);
        Agreements = new AgreementsClient(_client);
        Inventory = new InventoryClient(_client);
        Production = new ProductionClient(_client);
        Ecommerce = new EcommerceClient(_client);
        Cash = new CashClient(_client);
        Projects = new ProjectsClient(_client);
        Transport = new TransportClient(_client);
        Pos = new PosClient(_client);
        Audit = new AuditClient(_client);
        Webhooks = new WebhooksClient(_client);
        Bank = new BankClient(_client);
        Files = new FilesClient(_client);
        Reports = new ReportsClient(_client);
        Consolidation = new ConsolidationClient(_client);
        Public = new PublicClient(_client);
        Billing = new BillingClient(_client);
        Account = new AccountClient(_client);
    }

    public IReferenceClient Reference { get; }

    public IPartnersClient Partners { get; }

    public ICatalogClient Catalog { get; }

    public ISalesClient Sales { get; }

    public IPurchasesClient Purchases { get; }

    public ICaptureClient Capture { get; }

    public IDeclarationsClient Declarations { get; }

    public ILedgerClient Ledger { get; }

    public IMigrationClient Migration { get; }

    public IAssetsClient Assets { get; }

    public IHrClient Hr { get; }

    public IFleetClient Fleet { get; }

    public IPayrollClient Payroll { get; }

    public IAgreementsClient Agreements { get; }

    public IInventoryClient Inventory { get; }

    public IProductionClient Production { get; }

    public IEcommerceClient Ecommerce { get; }

    public ICashClient Cash { get; }

    public IProjectsClient Projects { get; }

    public ITransportClient Transport { get; }

    public IPosClient Pos { get; }

    public IAuditClient Audit { get; }

    public IWebhooksClient Webhooks { get; }

    public IBankClient Bank { get; }

    public IFilesClient Files { get; }

    public IReportsClient Reports { get; }

    public IConsolidationClient Consolidation { get; }

    public IPublicClient Public { get; }

    public IBillingClient Billing { get; }

    public IAccountClient Account { get; }
}
