using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    [SerializeField] GameObject weapons;

    public void gameOver()
    {
        GetComponent<Player_Control>().enabled = false;
        gameOverPanel.SetActive(true);
        weapons.SetActive(false);
    }
}
