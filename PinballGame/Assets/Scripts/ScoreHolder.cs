using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreHolder : MonoBehaviour
{
    public static float score = 0f;
    public TMP_Text displayText;
    public TMP_Text highScoreText;
    public float highScore;

    // Start is called before the first frame update
    void Start()
    {
        if (displayText == null)
        {
            displayText = GameObject.FindWithTag("ScoreDisplay").GetComponent<TMP_Text>();
        }
        if (highScoreText == null)
        {
            highScoreText = GameObject.FindWithTag("HighScoreDisplay").GetComponent<TMP_Text>();
        }
        if (GetFloat("HighScore") == null)
        {
            SetFloat("HighScore", 0f);
        } else {
            highScore = GetFloat("HighScore");
            highScoreText.text = "High Score: " + highScore;
        }
    }

    // Update is called once per frame
    void Update()
    {
        displayText.text = "Score: " + score;
        if (score > highScore)
        {
            highScoreText.text = "High Score: " + score;
        }
        
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            score = 0f;
        }
    }

    public static void SetFloat(string KeyName, float Value)
    {
        PlayerPrefs.SetFloat(KeyName, Value);
    }

    public static float GetFloat(string KeyName)
    {
        return PlayerPrefs.GetFloat(KeyName);
    }
}
