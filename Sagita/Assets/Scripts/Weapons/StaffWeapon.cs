using System;
using UnityEngine;

public class StaffWeapon : WeaponBase
{
    [SerializeField] private GameObject leftStaffStrike;
    [SerializeField] private GameObject rightStaffStrike;

    Player_Control playerControl;
    [SerializeField] Vector2 staffAttackSize = new Vector2(1, 1);

    private void Awake()
    {
        playerControl = GetComponentInParent<Player_Control>();
    } 

    private void ApplyDamage(Collider2D[] colliders)
    {
        for (int i = 0; i < colliders.Length; i++)
        {
            IDamagable e = colliders[i].GetComponent<IDamagable>();
            if (e != null)
            {
                PostDamage(weaponStats.damage, colliders[i].transform.position);
                e.TakeDamage(weaponStats.damage);
            }
        }
    }

    public override void Attack()
    {
        if (playerControl.lastHorizontalVector > 0)
        {
            rightStaffStrike.SetActive(true);
            Collider2D[] colliders = Physics2D.OverlapBoxAll(rightStaffStrike.transform.position, staffAttackSize, 0f);
            ApplyDamage(colliders);
        }
        else
        {
            leftStaffStrike.SetActive(true);
            Collider2D[] colliders = Physics2D.OverlapBoxAll(leftStaffStrike.transform.position, staffAttackSize, 0f);
            ApplyDamage(colliders);
        }
    }
}
