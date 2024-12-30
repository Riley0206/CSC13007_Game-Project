using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootFireball : MonoBehaviour
{

    Player_Control playerMove;

    [SerializeField] float timetoAttack;
    float timer;

    [SerializeField] GameObject FireballPrefab;

    private void Awake()
    {
        playerMove = GetComponentInParent<Player_Control>();
    }

    private void Update()
    {
        if (timer < timetoAttack)
        {
            timer += Time.deltaTime;
            return;
        }
        timer = 0;
        SpawnFireball();
    }

    private void SpawnFireball()
    {
        GameObject ShotFireball = Instantiate(FireballPrefab);
        ShotFireball.transform.position = transform.position;
        ShotFireball.GetComponent<ShootingFireballProjectile>().SetDirection(playerMove.lastHorizontalVector, 0f);
    }
}
