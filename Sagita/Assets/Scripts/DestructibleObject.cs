using UnityEngine;

public class DestructibleObject : MonoBehaviour, IDamagable
{
    public void TakeDamage(int damage)
    {
        Destroy(gameObject);
    }
}
