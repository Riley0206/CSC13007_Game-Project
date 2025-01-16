using UnityEngine;
using UnityEngine.UI;

public class ExperienceBar : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] TMPro.TextMeshProUGUI levelText;

    public void UpdateExperienceSlider(int current, int target)
    {
        slider.value = current;
        slider.maxValue = target;
    }

    public void UpdateLevelText(int level)
    {
        levelText.text = "Level " + level.ToString();
    }
}