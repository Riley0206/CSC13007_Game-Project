using System;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    [SerializeField] Image upgradeImage;

    public void Set (UpgradeData upgradeData)
    {
        upgradeImage.sprite = upgradeData.upgradeIcon;
    }

    internal void Clean()
    {
        upgradeImage.sprite = null;
    }
}
