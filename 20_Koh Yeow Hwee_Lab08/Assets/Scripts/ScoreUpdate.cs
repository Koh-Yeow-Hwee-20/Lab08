using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreUpdate : MonoBehaviour
{
    public GameObject Score;
    private int score;

    //ScoreUpdate
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            score++;
            Score.GetComponent<Text>().text = "Score: " + score;
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
