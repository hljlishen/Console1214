namespace Console.DBLink
{
    internal abstract class DbLinkFactory
    {
        public abstract IDatabaseDrive CreateDatabaseDrive(string connectString);

        public abstract IDateTimeFormater CreateDateTimeFormater();

        public abstract DatabaseType GetDataBaseType();
    }

    internal class MySqlFactory : DbLinkFactory
    {
        public override IDatabaseDrive CreateDatabaseDrive(string connectString)
        {
            throw new System.NotImplementedException();
        }

        public override IDateTimeFormater CreateDateTimeFormater()
        {
            throw new System.NotImplementedException();
        }

        public override DatabaseType GetDataBaseType()
        {
            throw new System.NotImplementedException();
        }
    }

    internal class AccessFactory : DbLinkFactory
    {
        public override IDatabaseDrive CreateDatabaseDrive(string connectString)
        {
            throw new System.NotImplementedException();
        }

        public override IDateTimeFormater CreateDateTimeFormater()
        {
            throw new System.NotImplementedException();
        }

        public override DatabaseType GetDataBaseType()
        {
            throw new System.NotImplementedException();
        }
    }

    internal class SqlServerFactory : DbLinkFactory
    {

        public override IDatabaseDrive CreateDatabaseDrive(string connectString) => SqlServerDrive.GetInstance(connectString);

        public override IDateTimeFormater CreateDateTimeFormater() => new StanderdStyleDateTimeFormater();
        public override DatabaseType GetDataBaseType() => DatabaseType.SqlServer;
    }
}