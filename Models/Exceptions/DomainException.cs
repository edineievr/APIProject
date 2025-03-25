using Microsoft.AspNetCore.Mvc;

namespace ProjetoAPI.Models.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
            
        }
    }
}
