using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Screpts.Inventory
{
    public class Cell : MonoBehaviour
    {
        [SerializeField] private Image _icon;
        [SerializeField] private TMP_Text _count;
        private int _id;
        private bool _isOccupied = false;

        public void SetId(int id)
        {
            _id = id;
        }
    }
}