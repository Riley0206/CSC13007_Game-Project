using UnityEngine;

public class DamageMessage : MonoBehaviour
{
    [SerializeField]float ttl = 2f;
    float curr;

    private void OnEnable()
    {
        curr = ttl;
    }

    private void Update()
    {
        curr -= Time.deltaTime;
        if (curr <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
