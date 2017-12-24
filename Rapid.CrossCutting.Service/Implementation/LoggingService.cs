namespace Rapid.CrossCutting.Service.Implementation {
    using Rapid.Data;
    using Rapid.Data.Model;
    using Definition;

    using System;

    public class LoggingService : ILoggingService {
        private readonly IUnitOfWork _unitOfWork;

        public LoggingService(ApplicationDbContext context) {
            _unitOfWork = new UnitOfWork(context);
        }

        public void Info(string message) {
            
        }

        public void Warning(string message) {
            throw new NotImplementedException();
        }

        public void Error(string message) {
            throw new NotImplementedException();
        }

        public void Exception(Exception exception) {
            throw new NotImplementedException();
        }
    }
}