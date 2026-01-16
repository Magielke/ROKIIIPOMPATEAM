using TMPro;
using UnityEngine;

public class TriggerText : MonoBehaviour
{
    public TextMeshProUGUI text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Roomba"))
        {
            Debug.Log("HALO");
            text.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Roomba"))
        {
            Debug.Log("OLAH");
            text.gameObject.SetActive(false);
        }
    }
}
