using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{

    [SerializeField] private GameObject gameOverPanal;

    [SerializeField] private TMP_Text ScoreText;
    public static GameManger instance;

    private int score = 0;//player Score

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(gameObject);
        }

    }
    public void Start()
    {
        Time.timeScale = 1f;
        gameOverPanal.SetActive(false);
    }

    public void QuitGamne()
    {
        Application.Quit();
    }


    public void RestartGame()
    {
       Time.timeScale = 1f;
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void AddPoint()
    {
        score += 1;
        ScoreText.text = score.ToString();
    }


    public void GameOver()
    {
        gameOverPanal.SetActive(true);
        Time.timeScale = 0f;

    }

   
}
