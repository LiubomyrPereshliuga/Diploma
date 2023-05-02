using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }
        public ICategoryItemsRepository CategoryItems { get; set; }
        public IShopItemsRepository ShopItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository, ICategoryItemsRepository categoryItemsRepository, IShopItemsRepository shopItemsRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
            CategoryItems = categoryItemsRepository;
            ShopItems = shopItemsRepository;
        }
    }
}
