namespace Blockchain;

public static class BlockchainDbProperties
{
    public static string DbTablePrefix { get; set; } = "Blockchain";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Blockchain";
}
