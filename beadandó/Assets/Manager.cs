using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    public GameObject Menu;

    public void Startgame()
    {
        SceneManager.LoadScene("Game");
        Menu.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
