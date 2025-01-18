using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void startGame()
    {
        //SceneManager.LoadScene("LevelSelector", LoadSceneMode.Single);

        SceneManager.LoadScene("Essential", LoadSceneMode.Single);
        SceneManager.LoadScene("TestingScene", LoadSceneMode.Additive);
    }
}
