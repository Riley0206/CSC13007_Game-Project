using UnityEngine;

public class DisapearAfterTime : MonoBehaviour
{
    float timer;
    [SerializeField] float timeToDisapear = 0.8f;

    private void OnEnable()
    {
        timer = timeToDisapear;
    }

    private void LateUpdate()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
