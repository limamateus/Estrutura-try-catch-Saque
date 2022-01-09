using System;
using System.Collections.Generic;


namespace Estrutura_try_catch_Saque.Entites.Exceptions
{
    class DomainExpection : ApplicationException
    {

        public DomainExpection(string message) : base(message)
        {

        }
    }
}
