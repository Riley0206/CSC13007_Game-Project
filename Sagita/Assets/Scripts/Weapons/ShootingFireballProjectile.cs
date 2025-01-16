using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootingFireballProjectile : MonoBehaviour
{
    Vector3 direction;
    [SerializeField] float speed;
    [SerializeField] int damage = 10;
    [SerializeField] float lifetime;

    public void SetDirection(float dir_x, float dir_y)
    {
        direction = new Vector3(dir_x, dir_y);

        if (dir_x < 0)
        {
            Vector3 scale = transform.localScale;
            scale.x *= (-1);
            transform.localScale = scale;
        }
    }

    bool hitDetection = false;

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;

        if (Time.frameCount % 4 == 0)
        {
            Collider2D[] hit = Physics2D.OverlapCircleAll(transform.position, 1f);
            foreach (Collider2D c in hit)
            {
                Enemy enemy = c.GetComponent<Enemy>();
                if (enemy != null)
                {
                    enemy.TakeDamage(damage);
                    hitDetection = true;
                    break;
                }
            }

            if (hitDetection)
            {
                Destroy(gameObject);
            }

            lifetime -= Time.deltaTime;
            if (lifetime <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
