using System.Security.Cryptography.X509Certificates;

public class TableService
{
    // ===== DEPENDENCY INJECTION ======
    private readonly TableRepository repository;
    public TableService(TableRepository _repository)
    {
        this.repository = _repository;
    }
    // ==================================
    
    public Table CreateNewTable(Table tableRequest) // CREATE
    {
        // WIP butuh validator (I/O)
        Table newTable = tableRequest;
        repository.DB.Add(newTable);
        return newTable;
    }
    public (bool,Table) FindAnyTable(string id) // READ
    {
        foreach (Table table in repository.DB)
        {
            if(table.table_num == id)
            return (true,table);
        }
        return (false,Table.NotFoundQuery());
    }
    public Table UpdateATable(Table updateRequest) // UPDATE
    {
        // tampung request ke variable
        string requestId = updateRequest.table_num; 
        (bool,Table) option = FindAnyTable(requestId);

        // validasi dari query yang ada
        Table validTable = HelperGeneral<Table>.ValidateSearchOutput(option.Item1,option.Item2);

        // buat response 
        Table tableResponse = validTable;

        // buat nyari index dan ngegantiin table yang ada
        int targetIndex = HelperGeneral<Table>.FindAnyListIndex(
            repository.DB,
            x => x.table_num,
            validTable.table_num
            );
        repository.DB[targetIndex] = updateRequest;

        // return response
        return tableResponse;
    }

    public void DeleteATable(string id) // DELETE
    {
        (bool,Table) option = FindAnyTable(id);
        Table validTable = HelperGeneral<Table>.ValidateSearchOutput(option.Item1,option.Item2);

        int targetIndex = HelperGeneral<Table>.FindAnyListIndex(
            repository.DB,
            x => x.table_num,
            validTable.table_num
            );

        repository.DB.RemoveAt(targetIndex);

        Console.WriteLine($"REMOVED : {validTable.table_num}");
    }


}