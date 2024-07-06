
using Screpts.ConsumableItems;
using Screpts.Infrastructure.AssetManagment;
using Screpts.Inventory;

namespace Screpts.Infrastructure.Factory
{
    public class GameFactory : IGameFactory
    {
        private readonly IAssetProvider _assetProvider;

        public GameFactory(IAssetProvider assetProvider) 
        {
            _assetProvider = assetProvider;
        }

        public void CreateItem(string name, Cell cell)
        {
            Item item = _assetProvider.InstantiateItem(name, at: cell.Container);
            cell.SetItem(item);
        }
    }
}