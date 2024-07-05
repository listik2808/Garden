using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] private protected float _weight;
    [SerializeField] private protected int _count;
    [SerializeField] private protected int _maxCount;
}
