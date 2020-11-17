using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

bool gameEnded = false;
public GameObject LevelCompleteUI;

public void LevelComplete(){

	//Debug.Log("You Won Level");
	LevelCompleteUI.SetActive(true);
}

//create game over function

public void GameOver(){

	if(gameEnded == false)
	{
		gameEnded = true;
		Debug.Log("Game Over");
		Invoke("Restart",2f);
	}
	
}

void Restart(){

	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}

}
