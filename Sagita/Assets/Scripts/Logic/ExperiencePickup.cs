using UnityEngine;

public class ExperiencePickup : MonoBehaviour, ICollectible
{
    [SerializeField]public int experienceAmount = 10;

    public void OnPickup(Character character)
    {
        character.level.AddExperience(experienceAmount);
    }
}

