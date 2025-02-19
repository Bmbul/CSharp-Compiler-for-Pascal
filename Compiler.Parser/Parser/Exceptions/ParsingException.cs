using System;
using Common;

namespace Parser.Parser.Exceptions
{
    public class ParsingException : ApplicationException
    {
        public ParsingException(string exception) 
            : base(exception)
        {
        
        }
        
        public ParsingException(string exception, LexicalToken token) 
            : base($"{exception} | Got {token}")
        {
            
        }
    }
}