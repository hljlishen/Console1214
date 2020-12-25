using System.Data;

namespace Console.DBLink
{
    public interface IDatabaseDrive
    {
        void ExecuteInsert(string insertSql);
        void ExecuteUpdate(string updateSql);
        void ExecuteDelete(string deleteSql);
        DataSet ExecuteSelect(string selectSql);
    }
}