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
        int tableNumCounter = 1; // buat auto assign jika dari request null
        Table newTable = new()
        {
            id_session = null,
            status = ETableStatus.AVAILLABLE,
            table_num = tableRequest.table_num ?? $"{tableNumCounter++}"
        };
        repository.DB.Add(newTable);
        return newTable;
    }
    public Table FindAnyTable(string id) // READ
    {   
        foreach (Table table in repository.DB)
        {
            if(table.table_num == id)
              return table;
        }
        throw new Exception($"Not found any table with id: {id}");

    }
    public List<Table> FindAllTable()
    {
        return repository.DB;
    }
    public Table UpdateTable(Table tableRequest) // UPDATE
    {
        int targetIndex = repository.DB.FindIndex(x => x.table_num == tableRequest.table_num);
        if(targetIndex == -1)
        {
            throw new Exception("TABLE NOT FOUND");
        }
        repository.DB[targetIndex] = tableRequest;

        // return response
        return tableRequest;
    }
    public void DeleteTable(string tableNum) // DELETE
    {
        int targetIndex = repository.DB.FindIndex(x => x.table_num == tableNum); // cari index
        repository.DB.RemoveAt(targetIndex); // delete
        Console.WriteLine($"REMOVED : {tableNum}");
    }
    public Table AssignTable(string id, string id_session_request)
    {
        int targetIndex = repository.DB.FindIndex(table => table.table_num == id);
        if(targetIndex == -1)
        {
            throw new Exception();
        }

        Table targetTable = repository.DB[targetIndex];
        targetTable.status = ETableStatus.OCCUPIED;
        targetTable.id_session = id_session_request;
        repository.DB[targetIndex] = targetTable;

        return targetTable;
    }
}