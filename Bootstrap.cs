
namespace App.Bootstrap
{
    public static class Bootstrap
    {
        public static Router AppConfig()
        {
            TableRepository tableRepo = new();
            PackageMenuRepository menuRepo = new();
            SessionRepository sessionRepo = new();
            PenaltyRepository penaltyRepo = new();
            TransactionRepository transactionRepo = new();

            // 1️. Buat semua service
            var tableService = new TableService(tableRepo);
            var menuService = new PackageMenuService(menuRepo);
            var penaltyService = new PenaltyService(penaltyRepo);
            var trxService = new TransactionService(transactionRepo);
            var sessionService = new SessionService(trxService, sessionRepo, menuRepo, penaltyRepo, tableRepo);

            // 2️. Buat semua handler, inject service masing-masing
            var tableHandler = new TableHandler(tableService);
            var menuHandler = new PackageMenuHandler(menuService);
            var sessionHandler = new SessionHandler(sessionService);
            var penaltyHandler = new PenaltyHandler(penaltyService);
            var trxHandler = new TrxHandler(trxService);

            // 3️. Buat Dashboard, inject service jika perlu
            var dashboard = new TuiDashboard(
                sessionService,
                tableService
            );

            // 4️⃣ Buat Router, inject semua handler + dashboard
            var router = new Router(
                dashboard,
                tableHandler,
                menuHandler,
                sessionHandler,
                penaltyHandler,
                trxHandler
            );

            return router;
        }
    }
}
