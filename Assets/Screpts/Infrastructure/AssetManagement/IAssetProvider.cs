using Screpts.ConsumableItems;
using Screpts.Inventory;
using UnityEngine;

namespace Screpts.Infrastructure.AssetManagment
{
    public interface IAssetProvider
    {
        Item InstantiateItem(string path, Transform at);
    }
}