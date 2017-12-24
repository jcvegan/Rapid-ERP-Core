namespace Rapid.Data {

    using Model;
    using Repository.Definition;
    using Repository.Implementation;

    using System.Threading;
    using System.Threading.Tasks;

    public class UnitOfWork : IUnitOfWork {
        private readonly ApplicationDbContext _context;

        public IDocumentTypeRepository DocumentTypes { get; private set; }

        public UnitOfWork(ApplicationDbContext context) {
            _context = context;
            DocumentTypes = new DocumentTypeRepository(_context);
        }

        public void Dispose() {
            _context?.Dispose();
        }

        public int Complete() {
            return _context.SaveChanges();
        }

        public async Task<int> CompleteAsync(CancellationToken cancellationToken) {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}