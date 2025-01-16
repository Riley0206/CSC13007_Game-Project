using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectClick : MonoBehaviour
{
    public void selectLevel(string selectedStage)
    {
        SceneManager.LoadScene("Essential", LoadSceneMode.Single);
        SceneManager.LoadScene(selectedStage, LoadSceneMode.Additive);
    }
}
