namespace SaltHash
{
    public interface ISaltHash
    {
        string CreateSalt(int size);
        string GenerateHash(string password, string salt);
    }
}