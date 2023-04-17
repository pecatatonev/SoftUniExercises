public interface IId
{
    bool ValidateId(string input);
    string Id { get; }
}