using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript instance;

    private void Awake()
    {
        instance = this;
    }

    public Transform playerTransform;
}
