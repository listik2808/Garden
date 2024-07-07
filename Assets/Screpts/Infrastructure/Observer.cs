using Screpts.ConsumableItems;
using Screpts.WindowsPopUp;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Screpts.Infrastructure
{
    public class Observer : MonoBehaviour
    {
        [SerializeField] private ScreenPopUp _screenPopUp;
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
            item.ClickButton += OpenPopUp;
        }

        private void OpenPopUp(Item item)
        {
            _screenPopUp.SetItem(item);
            _screenPopUp.gameObject.SetActive(true);
        }
    }
}
