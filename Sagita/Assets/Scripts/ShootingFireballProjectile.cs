using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootingFireballProjectile : MonoBehaviour
{
    Vector3 direction;
    [SerializeField] float speed;

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

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;

        Collider2D[] hit = Physics2D.OverlapCircleAll(transform.position, 0.3f);
        foreach (Collider2D c in hit)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

}
