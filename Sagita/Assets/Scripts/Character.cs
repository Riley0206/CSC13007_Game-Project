using UnityEngine;

public class Character : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP = 100;
    [SerializeField] StatusBar hpBar;

    private void Start()
    {
        hpBar.SetState(currentHP, maxHP);
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        if (currentHP <= 0)
        {
            Die();
        }
        hpBar.SetState(currentHP, maxHP);
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
