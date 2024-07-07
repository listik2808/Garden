using Screpts.Infrastructure.Factory;
using Screpts.Inventory;

namespace Screpts
{
    public class ItemInstaller
    {
        private InventoryGreed _inventoryGreed;
        private GameFactory _gameFactory;

        public ItemInstaller(InventoryGreed inventoryGreed, GameFactory gameFactory)
        {
            _inventoryGreed = inventoryGreed;
            _gameFactory = gameFactory;
        }

        public void SetItemInventory(string name, Cell cell)
        {
            _gameFactory.CreateItem(name, cell);
        }

        public void StarterKit()
        {
            SetItemInventory(AssetPath.Cap, _inventoryGreed.Cells[0]);
            SetItemInventory(AssetPath.Helmet, _inventoryGreed.Cells[1]);
            SetItemInventory(AssetPath.MedicalKit, _inventoryGreed.Cells[2]);
            SetItemInventory(AssetPath.Jacket, _inventoryGreed.Cells[3]);
            SetItemInventory(AssetPath.VestBulletproof, _inventoryGreed.Cells[4]);
            SetItemInventory(AssetPath.AutomaticBullets, _inventoryGreed.Cells[5]);
            SetItemInventory(AssetPath.PistolBullet, _inventoryGreed.Cells[6]);
        }
    }
}