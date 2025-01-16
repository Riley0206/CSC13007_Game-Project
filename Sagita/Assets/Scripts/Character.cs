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

    [HideInInspector]public bool isDead = false;
    public void TakeDamage(int damage)
    {
        if (isDead) { return; }
        ApplyArmor(ref damage);

        currentHP -= damage;
        hpBar.SetState(currentHP, maxHP);
        if (currentHP <= 0)
        {
            isDead = true;
            Die();
        }
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
        GetComponent<GameOver>().gameOver();
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
