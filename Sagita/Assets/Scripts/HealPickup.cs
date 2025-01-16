using UnityEngine;

public class HealPickup : MonoBehaviour, ICollectible
{
    [SerializeField] public int healAmount = 10;

    public void OnPickup(Character character)
    {
        character.Heal(healAmount);
    }
}
