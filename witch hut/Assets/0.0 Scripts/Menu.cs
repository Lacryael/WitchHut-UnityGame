using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

	public static bool isOpened = false;
	public float timer;
	private static float time = 0;
	public GameObject obj;
	public GameObject canvas;



	void Start()
	{

	}


	void Update()
	{
		Time.timeScale = timer;

		if (Input.GetKeyDown(KeyCode.Escape) && time <= 0 && BookFQ.isOpened2 == false)
		{
			isOpened = !isOpened;
			time = 20f;
		}

		if (isOpened == true && BookFQ.isOpened2 == false)
		{
			obj.GetComponent<HS_CameraController>().enabled = false;
			canvas.SetActive(false);
			GetComponent<Canvas>().enabled = isOpened;
			Cursor.lockState = CursorLockMode.None;
			timer = 0;
			time -= 1f;
			Cursor.visible = true;
		}
		else if (isOpened == false && BookFQ.isOpened2 == false)
		{
			GetComponent<Canvas>().enabled = isOpened;
			obj.GetComponent<HS_CameraController>().enabled = true;
			canvas.SetActive(true);
			time -= 1f;
			timer = 1f;
			Cursor.visible = false;
		}
	}

	public void ShowHideMenu()
	{
		isOpened = !isOpened;
		GetComponent<Canvas>().enabled = !isOpened;
	}


	public void QuitGame()
	{
		Application.Quit();
	}

	//New
	public void NewGame()
	{
		isOpened = false;
		Application.LoadLevel(Application.loadedLevel);
		//SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		BookFQ.isOpened2 = false;

	}

}
