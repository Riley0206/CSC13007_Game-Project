using System;
using System.Threading;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable
{
    [HideInInspector]
    public Transform targetDestination;
    GameObject targetGameObject;
    Character targetCharacter;
    [SerializeField] float speed;

    Rigidbody2D rb;

    [SerializeField] int hp = 10;
    [SerializeField] int attackDamage = 1;
    [SerializeField] int timeBetweenAttacks = 1;
    [SerializeField] int exp_reward = 10;

    float timer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetTarget(GameObject target) 
    {
        targetGameObject = target;
        targetDestination = target.transform;
    }

    private void FixedUpdate()
    {
        Vector2 direction = (targetDestination.position - transform.position).normalized;
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == targetGameObject)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Attack();
                timer = timeBetweenAttacks;
            }
        }
    }

    private void Attack()
    {
        timer = timeBetweenAttacks;
        if (targetCharacter == null)
        {
            targetCharacter = targetGameObject.GetComponent<Character>();
        }

        targetCharacter.TakeDamage(attackDamage);
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        targetCharacter.GetComponent<Level>().AddExperience(exp_reward);
        GetComponent<DropOnDestroy>().CheckDrop();
        Destroy(gameObject);
    }
}
