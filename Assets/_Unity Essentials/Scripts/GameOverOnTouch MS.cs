using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverOnTouch : MonoBehaviour
{
    public GameObject gameOverMenu;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameOverMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
