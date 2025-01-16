using System;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP = 100;
    [SerializeField] StatusBar hpBar;
    public int armor = 0;

    [HideInInspector] public Level level;
    [HideInInspector] public Coins coins;

    private void Awake()
    {
        level = GetComponent<Level>();
        coins = GetComponent<Coins>();
    }

    private void Start()
    {
        hpBar.SetState(currentHP, maxHP);
    }

    public void TakeDamage(int damage)
    {
        ApplyArmor(ref damage);

        currentHP -= damage;
        if (currentHP <= 0)
        {
            Die();
        }
        hpBar.SetState(currentHP, maxHP);
    }

    private void ApplyArmor(ref int damage)
    {
        damage -= armor;
        if (damage <= 0)
        {
            damage = 1;
        }
    }

    public void Die()
    {
        Debug.Log("Character died");
    }

    public void Heal(int amount)
    {
        if (currentHP == 0) { return; }

        currentHP += amount;
        if (currentHP > maxHP)
        {
            currentHP = maxHP;
        }
        hpBar.SetState(currentHP, maxHP);
    }
}
