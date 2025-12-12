public class PackageMenuService
{
    // ===== DEPENDENCY INJECTION ======
    private readonly PackageMenuRepository repository;
    public PackageMenuService(PackageMenuRepository _repository)
    {
        this.repository = _repository;
    }
    // ==================================
    
    public PackageMenu CreateMenu(PackageMenu menuRequest){ return null;}
    public PackageMenu FindAnyMenu(string id){return null;} 
    public PackageMenu UpdateMenu(PackageMenu menuRequest){return null;}
    public void DeleteMenu(string id){}

}