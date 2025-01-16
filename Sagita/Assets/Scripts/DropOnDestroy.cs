using UnityEngine;

public class DropOnDestroy : MonoBehaviour
{
    [SerializeField] GameObject DroppedItem;
    [SerializeField]
    [Range(0, 1)]
    float DropChance = 1;

    private void OnDestroy()
    {
        if (Random.value < DropChance)
        {
            Transform t = Instantiate(DroppedItem).transform;
            t.position = transform.position;
        }
    }
}
