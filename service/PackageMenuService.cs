public class PackageMenuService
{
    // ===== DEPENDENCY INJECTION ======
    private readonly PackageMenuRepository repository;
    public PackageMenuService(PackageMenuRepository _repository)
    {
        this.repository = _repository;
    }
    // ==================================
    
    public PackageMenu CreateMenu(PackageMenu menuRequest)
    {
        PackageMenu package = new();
        package.menu_type = menuRequest.menu_type;
        package.name = menuRequest.name;
        package.time = menuRequest.time;
        package.price = menuRequest.price;

        repository.DB.Add(package);

        return package;
    }
    public PackageMenu FindAnyMenu(string id)
    {
        foreach (PackageMenu package in repository.DB)
        {
            if(package.id == id)
            {
                return package;
            }
        }
        return null;
    } 
    public List<PackageMenu> FindAllMenu(){return repository.DB;}
    public PackageMenu UpdateMenu(PackageMenu menuRequest)
    {
        PackageMenu findMenu = FindAnyMenu(menuRequest.id);
        int targetIndex = repository.DB.FindIndex(x => x.id == findMenu.id);
        if(targetIndex == -1)
        {
            throw new Exception("MENU NOT FOUND");
        }

        PackageMenu packageResponse = findMenu;

        return packageResponse;
    }
    public void DeleteMenu(string id)
    {
        int targetIndex = repository.DB.FindIndex(x => x.id == id);
        if(targetIndex == -1)
        {
            throw new Exception("MENU NOT FOUND");
        }
        repository.DB.RemoveAt(targetIndex);
    }

}