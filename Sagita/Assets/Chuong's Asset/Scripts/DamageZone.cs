using UnityEngine;

public class DamageZone : MonoBehaviour
{
    private Object thisObject;

    private void Start()
    {
        thisObject = GetComponent<Object>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Damage zone triggered");
        }
    }
}
