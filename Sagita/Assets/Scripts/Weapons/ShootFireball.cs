using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootFireball : WeaponBase
{
    Player_Control playerMove;

    [SerializeField] GameObject FireballPrefab;

    private void Awake()
    {
        playerMove = GetComponentInParent<Player_Control>();
    }

    public override void Attack()
    {
        GameObject ShotFireball = Instantiate(FireballPrefab);
        ShotFireball.transform.position = transform.position;
        ShotFireball.GetComponent<ShootingFireballProjectile>().SetDirection(playerMove.lastHorizontalVector, 0f);
    }
}
