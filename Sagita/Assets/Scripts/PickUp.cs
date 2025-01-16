using UnityEngine;

public class Heart_Collect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Character character = collision.GetComponent<Character>();
        if (character != null)
        {
            GetComponent<ICollectible>().OnPickup(character);
            Destroy(gameObject);
        }
    }
}
