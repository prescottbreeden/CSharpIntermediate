using System;

namespace CSharpIntermediate
{
  public class DbMigrator
  {
    private readonly ILogger _logger;
    public DbMigrator(ILogger logger)
    {
      _logger = logger;
    }

    public ILogger _Logger { get; }

    public void Migrate()
    {
      _logger.LogInfo("Migration started at " + DateTime.Now);

      // details of migrating the databse 

      _logger.LogInfo("Migration finished at " + DateTime.Now);
    }
  }
}

