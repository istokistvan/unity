using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject End;
    public float timer = 0f;
    public Text textBox;

    void Update()
    {
        timer += Time.deltaTime;
    }

    public void Complete()
    {
        End.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        textBox.text = timer.ToString()+" Sec";
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
