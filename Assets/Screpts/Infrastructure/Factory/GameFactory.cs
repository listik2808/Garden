using Screpts.ConsumableItems;
using Screpts.Infrastructure.AssetManagment;
using Screpts.Inventory;
using UnityEngine;

namespace Screpts.Infrastructure.Factory
{
    public class GameFactory : IGameFactory
    {
        private readonly IAssetProvider _assetProvider;
        private readonly Canvas _canvas;
        private readonly Observer _observer;

        public GameFactory(IAssetProvider assetProvider,Canvas canvas,Observer observer) 
        {
            _assetProvider = assetProvider;
            _canvas = canvas;
            _observer = observer;
        }

        public void CreateItem(string name, Cell cell)
        {
            Item item = _assetProvider.InstantiateItem(name, at: cell.transform);
            DragDrop dragDrop = item.GetComponent<DragDrop>();
            dragDrop.Construct(_canvas,cell);
            _observer.AddItem(item);
            cell.SetItem(item);
        }
    }
}