using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class MessageSystem : MonoBehaviour
{
    public static MessageSystem instance;

    [SerializeField] GameObject messagePrefab;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    List<TMPro.TextMeshPro> messagePool;
    int objectCount = 10;
    int currentIndex = 0;

    private void Start()
    {
        messagePool = new List<TMPro.TextMeshPro>();

        for (int i = 0; i < objectCount; i++)
        {
            Populate();
        }
    }

    public void Populate()
    {
        GameObject go = Instantiate(messagePrefab, transform);
        messagePool.Add(go.GetComponent<TMPro.TextMeshPro>());
        go.SetActive(false);
    }

    public void ShowMessage(string message, Vector3 position)
    {
        messagePool[currentIndex].gameObject.SetActive(true);
        messagePool[currentIndex].transform.position = position;
        messagePool[currentIndex].text = message;
        currentIndex++;

        if (currentIndex >= objectCount)
        {
            currentIndex = 0;
        }
    }
}
