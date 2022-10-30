using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
	void Start()
	{

	}

	void Update()
	{

	}

	public static void GameOver()
	{
		GameObject.FindWithTag("GameOver").GetComponent<TextMeshProUGUI>().enabled = true;
	}

    public void RestartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		ScoreHolder.score = 0f;
	}
}
