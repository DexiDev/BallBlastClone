using DexiDev.Game.Data;
using UnityEngine;

namespace DexiDev.Game.Items
{
    [CreateAssetMenu(menuName = "Data/Items/Item Data", fileName = "Item Data")]
    public class ItemData : DataScriptable
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public virtual int StackLimit { get; private set; } = -1;
        [field: SerializeField] public Sprite Icon { get; private set; }
        [field: SerializeField] public bool IsSystem { get; private set; }
    }
}