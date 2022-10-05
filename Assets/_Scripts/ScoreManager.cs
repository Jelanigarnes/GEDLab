using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI healthtext;
    public int score;
    public int health = 3;

    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeHealth(int healthValue) //commented coinValue
    {

        health -= healthValue;
        Debug.Log(health);
        healthtext.text = health.ToString();
    }
    public void ChangeScore(int scoreValue) //commented coinValue
    {


        if (health == 2)
        {
            score -= scoreValue;
        }
        else if(health == 1)
        {
            score -= scoreValue;
        }
        else
        {
            score += scoreValue;
        }
        Debug.Log(score);
        scoretext.text = score.ToString();
    }


   

}
