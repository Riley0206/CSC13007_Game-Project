using UnityEngine;
using System.Collections.Generic;

public class PassiveItems : MonoBehaviour
{
    [SerializeField] List<Item> items;
    Character character;
    [SerializeField] Item ArmorTest; 

    private void Start()
    {
        equip(ArmorTest);
    }

    private void Awake()
    {
        character = GetComponent<Character>();
    }

    public void equip(Item item)
    {
        if (items == null)
            items = new List<Item>();
        items.Add(item);
        item.equip(character);
    }

    public void unequip(Item item)
    {
        if (items == null)
            return;
        items.Remove(item);
    }
}
