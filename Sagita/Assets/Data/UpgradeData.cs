using UnityEngine;
using UnityEngine.UI;

public enum UpgradeType
{
    WeaponUpgrade,
    ItemUpgrade,
    WeaponUnlock,
    ItemUnlock
}

[CreateAssetMenu]
public class UpgradeData : ScriptableObject
{
    public UpgradeType upgradeType;
    public string upgradeName;
    public Sprite upgradeIcon;
}
