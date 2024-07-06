using UnityEngine;

namespace Screpts.ConsumableItems
{
    [CreateAssetMenu(fileName = "Item", menuName = "CreteObject/ New Item")]
    public class ItemScriptableObject : ScriptableObject
    {
        [SerializeField] private Item _itemPrefab;
    }
}