using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //TODO: Create a IA manager
    //[SerializeField]
    //private GameObject[] ghosts;

    //TODO: Create a PlayerManager
    //[SerializeField]
    //private GameObject player;

    [SerializeField]
    private int totalFoods;

    private int score = 0;
    private int lives = 0;


    private void Awake()
    {
        totalFoods = GameObject.FindGameObjectsWithTag("Food").Length;
    }

    private void Start()
    {
        NewGame();
        //Debug.Log("Food: " + totalFoods + "Score: " + score);
    }    

    private void NewGame()
    {
        SetScore(0);
        SetLives(3);
    }

    private void GameOver()
    {
        if(lives <= 0)
        {
            Debug.Log("GameOver");
        }
    }

    public void IncreaseScore()
    {
        score += 5;
        Debug.Log("Score:" + score);
    }

    private void SetScore(int score)
    {
        this.score = score;
    }

    private void SetLives(int lives)
    {
        this.lives = lives;
    }
}
