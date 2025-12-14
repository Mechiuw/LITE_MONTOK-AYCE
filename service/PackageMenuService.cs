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

        PackageMenu packageResponse = findMenu;

        return packageResponse;
    }
    public void DeleteMenu(string id)
    {
        foreach (PackageMenu findMenu in repository.DB)
        {
            if(findMenu.id == id)
            {
                repository.DB.Remove(findMenu);
            }
        }
    }

}