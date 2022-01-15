using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gamehasEnded = false;
    public GameObject completeLevelUI;
    public float restartDelay = 2f;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gamehasEnded==false)
        {
            gamehasEnded = true;
            Debug.Log("GAMEOVER");
            Invoke("Restart", time: restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
