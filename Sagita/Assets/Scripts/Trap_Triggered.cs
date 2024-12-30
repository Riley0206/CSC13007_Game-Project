using UnityEngine;

public class Trap_Triggered : MonoBehaviour
{
    private Object obj;

    private void Start()
    {
        obj = GetComponent<Object>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerCollider"))
        {
            Debug.Log("Trap triggered by player");
        }
    }
}
