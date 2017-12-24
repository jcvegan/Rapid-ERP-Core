// Jcvegan.com - Juan Carlos Vega Neira
// Rapid.CrossCutting.Service 2017
// ILoggingService.cs
// Todos los derechos reservados
namespace Rapid.CrossCutting.Service.Definition {
    using System;
    public interface ILoggingService {
        void Info(string message);
        void Warning(string message);
        void Error(string message);
        void Exception(Exception exception);
    }
}