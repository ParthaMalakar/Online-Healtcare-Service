using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminTokenRepo : IRepo<Token, string, Token>
    {
        public Token Add(Token obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Token> Get()
        {
            throw new NotImplementedException();
        }

        public Token Get(string id)
        {
            throw new NotImplementedException();
        }

        public Token Update(Token obj)
        {
            throw new NotImplementedException();
        }
    }
}
