using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchWizardException
{
    //class OutOfMannaException : Exception 
    //{
    //}
    // MSDN - guidelines
    // use the Exception snippet
    [Serializable]
    public class OutOfMannaException : Exception
    {
        public OutOfMannaException() { }
        public OutOfMannaException(string message) : base(message) { }
        public OutOfMannaException(string message, Exception inner) : base(message, inner) { }
        protected OutOfMannaException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
