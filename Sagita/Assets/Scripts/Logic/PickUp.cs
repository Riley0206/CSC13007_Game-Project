using UnityEngine;

public class Heart_Collect : MonoBehaviour
{
    [SerializeField] private int HealAmount;
    private Object obj;

    private void Start()
    {
        obj = GetComponent<Object>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Character character = collision.GetComponent<Character>();
        if (character != null)
        {
            character.Heal(HealAmount);
            Destroy(gameObject);
        }
    }
}
