using Common;

namespace Parser.Validators
{
    public interface IOperationValidator
    {
        void ValidateAssignment(string resultType, string assigneeType);

        string ValidateOperation(string firstType, string secondType, LexicalToken operationToken);
    }
}