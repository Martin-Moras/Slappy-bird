using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
	public int levelindex;
	public void SelectLevel(int levelindex)
	{
		SceneManager.LoadScene("Level " + levelindex);
	}
}
