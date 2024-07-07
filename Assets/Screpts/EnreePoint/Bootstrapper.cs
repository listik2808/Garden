using Screpts.Infrastructure;
using Screpts.Infrastructure.AssetManagment;
using Screpts.Infrastructure.Factory;
using Screpts.Inventory;
using Screpts.Spawn;
using UnityEngine;

namespace Screpts.EnteePoint
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private OptionGreed _optionGreed;
        [SerializeField] private InventoryGreed _inventoryGreed;
        [SerializeField] private SpawnCell _spawnCell;
        [SerializeField] private Canvas _canvas;
        [SerializeField] private Observer _observer;
        private GameFactory _gameFactory;
        private AssetProvider _assetProvider;
        private ItemInstaller _itemInstaller;

        private void Start()
        {
            _assetProvider = new AssetProvider();
            _gameFactory = new GameFactory(_assetProvider,_canvas,_observer);
            _optionGreed.Initialization();
            _spawnCell.Create(_optionGreed.PrefabCell, _optionGreed.Container, _optionGreed.Countcell);
            _inventoryGreed.AddListCells(_spawnCell.Cells);
            _spawnCell.ActivateAllCells(_optionGreed.Countcell);
            _itemInstaller = new ItemInstaller(_inventoryGreed, _gameFactory);
            _itemInstaller.StarterKit();
        }
    }
}