using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    // This was created with the exception snippet
    [Serializable]
    public class TestSnippetException : Exception
    {
        public TestSnippetException() { }
        public TestSnippetException(string message) : base(message) { }
        public TestSnippetException(string message, TestSnippetException inner) : base(message, inner) { }
        protected TestSnippetException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
