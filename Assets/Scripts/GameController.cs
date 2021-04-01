using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject enemyCar;
    public GameObject bottomBG;
    public int amountCar;
    private GameObject newCar;
    //public Text score;
    public Text gameOverText;
    public Button GameOverButton;
    public Button GoMenuButton;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnerPosition = new Vector3();

        for (int i = 0; i < amountCar; i++)
        {
            spawnerPosition.x = Random.Range(-2.5f, 2.5f);
            spawnerPosition.y += 7 + Random.Range(6f, 7f);
            
            Instantiate(enemyCar, spawnerPosition, Quaternion.Euler(0, 0, 270));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowGameOver()
    {
        gameOverText.rectTransform.anchoredPosition3D = new Vector3(40, 230, 0);
        GameOverButton.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0, 120, 0);
        GoMenuButton.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0, -70, 0);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void GoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
