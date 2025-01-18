using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Level : MonoBehaviour
{
    int level = 1;
    int experience = 0;
    [SerializeField] ExperienceBar experienceBar;
    [SerializeField] UpgradePanelManager upgradePanelManager;

    [SerializeField] List<UpgradeData> upgradeData;
    List<UpgradeData> selectedUpgrades;
    List<UpgradeData> acquiredUpgrades;

    int TO_LEVEL_UP
    {
        get { return (level) * 100; }
    }

    private void Start()
    {
        experienceBar.UpdateExperienceSlider(experience, TO_LEVEL_UP);
        experienceBar.UpdateLevelText(level);
    }

    public void AddExperience(int amount)
    {
        experience += amount;
        CheckLevelUp();
        experienceBar.UpdateExperienceSlider(experience, TO_LEVEL_UP);
    }

    public void CheckLevelUp()
    {
        if (experience >= TO_LEVEL_UP)
        {
            LevelUp();
        }

    }

    void LevelUp()
    {
        if (selectedUpgrades == null)
        {
            selectedUpgrades = new List<UpgradeData>();
        }
        selectedUpgrades.Clear();
        selectedUpgrades.AddRange(GetUpgradeData(3));
        upgradePanelManager.OpenPanel(selectedUpgrades);
        experience -= TO_LEVEL_UP;
        level++;
        experienceBar.UpdateLevelText(level);
    }

    public List<UpgradeData> GetUpgradeData(int count)
    {
        List<UpgradeData> upgradeList = new List<UpgradeData>();
        if (count > upgradeData.Count)
        {
            count = upgradeData.Count;
        }

        for (int i = 0; i < count; i++)
        {
            upgradeList.Add(upgradeData[Random.Range(0, upgradeData.Count)]);
        }
        return upgradeList;
    }

    public void Upgrade(int selectedUpgradeID)
    {
        UpgradeData upgrade = selectedUpgrades[selectedUpgradeID];

        if (acquiredUpgrades == null)
        {
            acquiredUpgrades = new List<UpgradeData>();
        }
        acquiredUpgrades.Add(upgrade);
        //upgradeData.Remove(upgrade);
    }
}
