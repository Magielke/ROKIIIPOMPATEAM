using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject startMenu;

    void Start()
    {
        Time.timeScale = 0f; // zatrzymaj grę
    }

    public void StartButton()
    {
        startMenu.SetActive(false); // ukryj menu
        Time.timeScale = 1f; // uruchom grę
    }
}

