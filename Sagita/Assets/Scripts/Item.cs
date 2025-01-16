using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
    public string Name;
    public int armor;

    public void equip(Character character)
    {
        character.armor += armor;
    }

    public void unequip(Character character)
    {
        character.armor -= armor;
    }
}
