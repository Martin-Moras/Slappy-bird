using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
	public void ToMenu()
	{
		SceneManager.LoadScene("Menu");
	}
}
