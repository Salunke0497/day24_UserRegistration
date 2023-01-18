using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24UserRegistration
{
    public class ExceptionRegularRegistration :Exception
    {
        public enum RegularRegistrationType
        {
            INVALID_NAME,
            INVALID_Email,
            INVALID_Mobile,
            INVALID_PASSWORD
        }
        public RegularRegistrationType type;
        public ExceptionRegularRegistration(RegularRegistrationType type, string input) : base(input)
        {
            this.type = type;
        }
    }
}
