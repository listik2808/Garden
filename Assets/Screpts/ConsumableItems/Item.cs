using Screpts.ClickButton;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Screpts.ConsumableItems
{
    public enum TypeItem
    {
        Armor = 1,
        Projectile =2,
        Hp = 3,
    }
    public abstract class Item : MonoBehaviour
    {
        [SerializeField] private protected string _nameItem;
        [SerializeField] private protected Image _icon;
        [SerializeField] private protected float _weight;
        [SerializeField] private protected int _count;
        [SerializeField] private protected int _maxCount;
        [SerializeField] private TMP_Text _text;
        [SerializeField] private Sprite _sprite;
        [SerializeField] private  protected ButtonClick _buttonItem;
        [SerializeField] private TypeItem _typeItem;

        public event Action<Item> ClickButton;
        public event Action OnDeleted;

        public TypeItem TypeItem => _typeItem;
        public TMP_Text TextCount => _text;
        public Image Icon => _icon;
        public Sprite Spritetype => _sprite;
        public int Count => _count;
        public string NameItem => _nameItem;
        public float Weight => _weight;

        private void OnEnable()
        {
            _buttonItem.OpenScreen += OpenPopUp;
        }

        private void OnDisable()
        {
            _buttonItem.OpenScreen -= OpenPopUp;
        }

        public abstract int GetValue();

        public void DeletItem()
        {
            OnDeleted?.Invoke();
            Destroy(gameObject);
        }

        private void OpenPopUp()
        {
            ClickButton?.Invoke(this);
        }
    }
}