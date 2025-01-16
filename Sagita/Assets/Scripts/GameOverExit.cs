using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverExit : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
