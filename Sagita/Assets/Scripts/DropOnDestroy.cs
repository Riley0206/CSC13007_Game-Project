using UnityEngine;

public class DropOnDestroy : MonoBehaviour
{
    [SerializeField] GameObject DroppedItem;
    [SerializeField]
    [Range(0, 1)]
    float DropChance = 1;

    bool isQuitting;

    private void OnApplicationQuit()
    {
        isQuitting = true;
    }

    private void OnDestroy()
    {
        if (isQuitting)
        {
            return;
        }
        if (Random.value < DropChance)
        {
            Transform t = Instantiate(DroppedItem).transform;
            t.position = transform.position;
        }
    }
}
