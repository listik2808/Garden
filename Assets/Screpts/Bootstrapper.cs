using Screpts.ConsumableItems;
using Screpts.Infrastructure.AssetManagment;
using Screpts.Infrastructure.Factory;
using Screpts.Inventory;
using Screpts.Spawn;
using System.Collections;
using UnityEngine;

namespace Screpts
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private OptionGreed _optionGreed;
        [SerializeField] private InventoryGreed _inventoryGreed;
        [SerializeField] private SpawnCell _spawnCell;
        private GameFactory _gameFactory;
        private AssetProvider _assetProvider;

        private void Start()
        {
            _assetProvider = new AssetProvider();
            _gameFactory = new GameFactory(_assetProvider);
            _optionGreed.Initialization();
            _spawnCell.Create(_optionGreed.PrefabCell, _optionGreed.Container, _optionGreed.Countcell);
            _inventoryGreed.AddListCells(_spawnCell.Cells);
            _spawnCell.ActivateAllCells(_optionGreed.Countcell);
            StarterKit(AssetPath.Cap, _inventoryGreed.Cells[0]);
            StarterKit(AssetPath.Helmet, _inventoryGreed.Cells[1]);
            StarterKit(AssetPath.MedicalKit, _inventoryGreed.Cells[2]);
            StarterKit(AssetPath.Jacket, _inventoryGreed.Cells[3]);
            StarterKit(AssetPath.VestBulletproof, _inventoryGreed.Cells[4]);
            StarterKit(AssetPath.AutomaticBullets, _inventoryGreed.Cells[5]);
            StarterKit(AssetPath.PistolBullet, _inventoryGreed.Cells[6]);
        }

        public void StarterKit(string name, Cell cell)
        {
            _gameFactory.CreateItem(name, cell);
        }
    }
}