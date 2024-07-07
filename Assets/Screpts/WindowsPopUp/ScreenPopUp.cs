using Screpts.ClickButton;
using Screpts.ConsumableItems;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Screpts.WindowsPopUp
{
    public class ScreenPopUp : MonoBehaviour
    {
        public const string Armor = "Экипировать";
        public const string Projectile = "Купить";
        public const string Hp = "Лечить";
        [SerializeField] private TMP_Text _nameItem;
        [SerializeField] private TMP_Text _weightItem;
        [SerializeField] private TMP_Text _text;
        [SerializeField] private Image _imageMini;
        [SerializeField] private Image _icon;
        [SerializeField] private Button _button;
        [SerializeField] private TMP_Text _textButton;
        [SerializeField] private Button _buttonDel;
        [SerializeField] private ButtonClick _buttonClick;

        private Item _item;

        private void OnEnable()
        {
            _buttonClick.OpenScreen += CloseScreen;
            OpenButtonType(_item.TypeItem);
            Show();
            SubscribeType();
            _buttonDel.onClick.AddListener(Deleted);
        }

        private void OnDisable()
        {
            _buttonClick.OpenScreen -= CloseScreen;
            UnsubscribeType();
            _buttonDel.onClick.RemoveListener(Deleted);
        }

        public void SetItem(Item item)
        {
            _item = item;
        }

        public void Show()
        {
            _nameItem.text = _item.NameItem;
            _weightItem.text = _item.Weight.ToString() + " КГ";
            _text.text = "+ " + _item.GetValue().ToString();
            _icon.sprite = _item.Icon.sprite;
            _imageMini.sprite = _item.Spritetype;
        }

        private void CloseScreen()
        {
            gameObject.SetActive(false);
        }

        private void SubscribeType()
        {
            if(_item.TypeItem == TypeItem.Armor)
                _button.onClick.AddListener(Clothe);
            else if (_item.TypeItem == TypeItem.Projectile)
                _button.onClick.AddListener(PayProjectile);
            else if (_item.TypeItem == TypeItem.Hp)
                _button.onClick.AddListener(UseMedicament);
        }

        private void UnsubscribeType()
        {
            if (_item.TypeItem == TypeItem.Armor)
                _button.onClick.RemoveListener(Clothe);
            else if (_item.TypeItem == TypeItem.Projectile)
                _button.onClick.RemoveListener(PayProjectile);
            else if (_item.TypeItem == TypeItem.Hp)
                _button.onClick.RemoveListener(UseMedicament);
        }

        private void OpenButtonType(TypeItem typeItem)
        {
            if (typeItem == TypeItem.Armor)
                _textButton.text = Armor;
            else if (typeItem == TypeItem.Projectile)
                _textButton.text = Projectile;
            else
                _textButton.text = Hp;
        }

        private void Deleted()
        {
            _item.DeletItem();
        }

        private void UseMedicament()
        {
            Debug.Log("Лечим");
        }

        private void PayProjectile()
        {
            Debug.Log("Купил патроны");
        }

        private void Clothe()
        {
            Debug.Log("Надеть броню");
        }
    }
}