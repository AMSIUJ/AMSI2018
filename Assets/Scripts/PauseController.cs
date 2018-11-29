using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{


	public Button pauseButton;
	public bool isPaused = false;
	public GameObject pausePanel;

	private CanvasGroup pausePanelCG;
	// Use this for initialization

	void Awake()
	{
		pausePanelCG = pausePanel.GetComponent<CanvasGroup>();
	}


	public void pauseGame()
	{
		if (isPaused == false && pausePanelCG != null)
		{
			Debug.Log("pause");
			Time.timeScale = 0;
			isPaused = true;

			pauseButton.interactable = false;
			pausePanelCG.alpha = 1;
			pausePanelCG.interactable = true;
			pausePanelCG.blocksRaycasts = true;
		}
	}
	
	public void reasumeGame()
	{
		if (isPaused == true && pausePanelCG != null)
		{
			Debug.Log("unpause");
			Time.timeScale = 1;
			isPaused = false;

			pauseButton.interactable = true;
			pausePanelCG.alpha = 0;
			pausePanelCG.interactable = false;
			pausePanelCG.blocksRaycasts = false;
		}
	}
}
