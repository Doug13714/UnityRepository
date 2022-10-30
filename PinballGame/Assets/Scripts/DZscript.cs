using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DZscript : MonoBehaviour
{
    public GameObject newBall;
    private int balls;

    // Start is called before the first frame update
    void Start()
    {
        balls = 3;
    }
 
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<Rigidbody>().CompareTag("Ball"))
        {
            Destroy(collision.gameObject);
            balls--;
            switch(balls)
            {
                case 2:
                    GameObject.FindWithTag("ImgBall3").GetComponent<Image>().color = new Color32(133, 133, 133, 225);
                    Instantiate(newBall);
                    break;
                case 1:
                    GameObject.FindWithTag("ImgBall2").GetComponent<Image>().color = new Color32(133, 133, 133, 225);
                    Instantiate(newBall);
                    break;
                case 0:
                    GameObject.FindWithTag("ImgBall").GetComponent<Image>().color = new Color32(133, 133, 133, 225);
                    ScoreHolder.SetFloat("HighScore", ScoreHolder.score);
                    GameManager.GameOver();
                    break;
                default:
                    break;
            }            
        }
    }
}
