using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwords.Application
{
    internal class PasswordMaker
    {
        public PasswordMaker(PasswordConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Generate()
        {
            Random rand = new Random();
            StringBuilder result = new StringBuilder();
            
            for (int i = 0; i < _configuration.Length; i++)
            {
                result.Append();
            }
            

            
        }
        private PasswordConfiguration _configuration;
        
    }
}
