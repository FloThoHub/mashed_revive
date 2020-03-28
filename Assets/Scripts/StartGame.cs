using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
	public GameObject ButtonStart;

	void Start()
	{
		Button btn = ButtonStart.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!");
		SceneManager.LoadScene("GameScene");
	}
}
