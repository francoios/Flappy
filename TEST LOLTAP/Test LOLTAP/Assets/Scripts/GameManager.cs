using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;         
    public UILabel ScoreText;               
    public GameObject GameOvertext;            

    private int _score = 0;                     
    public bool GameOver = false;                                                                        

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);
    }

    void Update()
    {
        if (GameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }
    }

    public void BirdScored()
    {
        if (GameOver)
            return;
        _score++;
        ScoreText.text = "Score: " + _score.ToString();
    }

    public void BirdDied()
    {
        GameOvertext.SetActive(true);
        Time.timeScale = 0;
        GameOver = true;
    }
}
