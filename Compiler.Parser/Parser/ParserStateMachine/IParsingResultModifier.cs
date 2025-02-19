using System.Collections.Generic;
using Common;

namespace Parser.Parser.ParserStateMachine
{
    public interface IParsingResultModifier
    {
        LexicalToken GetNextToken();
        bool TryGetNextToken(out LexicalToken lexicalToken);
        bool IsValidVariableToken(LexicalToken token);
        bool IdentifierExists(string variableValue);
        void SetProgramName(string programName);
        void AddVariables(List<string> identifiers, string dataType);
        void DeclareVariables();
        void AddStatementsSection();
        void GenerateSimpleAssignment(LexicalToken token, LexicalToken firstVariable);
        void GenerateAssignmentWithOperations(LexicalToken token, LexicalToken firstVariable, LexicalToken secondVariable, LexicalToken operation);

        void GenerateExitWithLastOperationResult();
    }
}