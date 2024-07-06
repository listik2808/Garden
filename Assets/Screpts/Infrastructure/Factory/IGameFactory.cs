using Screpts.ConsumableItems;
using Screpts.Inventory;
using UnityEngine;

namespace Screpts.Infrastructure.Factory
{
    public interface IGameFactory
    {
        void CreateItem(string name, Cell cell);
    }
}