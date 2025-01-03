using System;
using UnityEngine;

public class StaffWeapon : MonoBehaviour
{
    [SerializeField] float timeToAttack = 3f;
    [SerializeField] int staffDamage = 5;
    float timer;

    [SerializeField] private GameObject leftStaffStrike;
    [SerializeField] private GameObject rightStaffStrike;

    Player_Control playerControl;
    [SerializeField] Vector2 staffAttackSize = new Vector2(1, 1);

    private void Awake()
    {
        playerControl = GetComponentInParent<Player_Control>();
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Attack();
            timer = timeToAttack;
        }
    }

    void Attack()
    {
        timer = timeToAttack;

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

    private void ApplyDamage(Collider2D[] colliders)
    {
        for (int i = 0; i < colliders.Length; i++)
        {
            IDamagable e = colliders[i].GetComponent<IDamagable>();
            if (e != null)
            {
                e.TakeDamage(staffDamage);
            }
        }
    }
}
