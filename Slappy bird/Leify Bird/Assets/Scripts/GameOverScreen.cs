using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
	public Text pointsText;
	public int levelindex;
	public void Setup(int score)
	{
		gameObject.SetActive(true);
		pointsText.text = score.ToString() + " Points ";
	}
	public void Restart()
 	{
		SceneManager.LoadScene("Level "+levelindex);
	}
}
