
using Screpts.ConsumableItems;
using Screpts.Inventory;
using UnityEngine;

namespace Screpts.Infrastructure.AssetManagment
{
    public class AssetProvider : IAssetProvider
    {
        public Item InstantiateItem(string path, Transform at)
        {
            Item prefab = Resources.Load<Item>(path);

            return Object.Instantiate(prefab, at);
        }
    }
}