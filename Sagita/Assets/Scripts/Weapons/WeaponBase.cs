using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    public WeaponData weaponData;

    public WeaponStats weaponStats;

    public float timeToAttack = 1.0f;
    float timer;

    public void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Attack();
            timer = timeToAttack;
        }
    }

    public abstract void Attack();

    public virtual void SetData(WeaponData wd)
    {
        weaponData = wd;
        timeToAttack = weaponData.stats.timeToAttack;

        weaponStats = new WeaponStats(wd.stats.damage, wd.stats.timeToAttack);
    }

    public virtual void PostDamage(int damage, Vector3 position)
    {
        MessageSystem.instance.ShowMessage(damage.ToString(), position);
    }
}
