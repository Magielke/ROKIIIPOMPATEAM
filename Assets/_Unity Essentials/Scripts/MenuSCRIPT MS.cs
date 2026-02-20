using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public GameObject menu;

    public void StartGame()
    {
        menu.SetActive(false);
        Time.timeScale = 1f;
    }

    void Start()
    {
        Time.timeScale = 0f;
    }
}
