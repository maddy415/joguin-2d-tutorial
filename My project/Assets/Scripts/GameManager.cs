using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int totalScore;
    public static GameManager instance;
    public GameObject gameOver;
    public GameObject button;
    private AudioSource aSource;

    public Text scoreText;
    void Start()
    {
        instance = this;
        aSource = GetComponent<AudioSource>();
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
        button.SetActive(true);
        aSource.Play();
        
    }
    public void ReloadScene(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }
}

