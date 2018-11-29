using UnityEngine;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{

	public Button pauseButton;
	public bool isPaused = false;
	public GameObject pausePanel;

	CanvasGroup pausePanelCG;
	// Use this for initialization

	void Awake()
	{
		pausePanelCG = pausePanel.GetComponent<CanvasGroup>();
		
		Debug.Log("Awake pause");
	}

	public void pauseGame()
	{
		Debug.Log("pause is preset");
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
	
	public void resumeGame()
	{
		Debug.Log("resume is preset");
		
		if (isPaused == true && pausePanelCG != null)
		{
			Debug.Log("resume");
			Time.timeScale = 1;
			isPaused = false;

			pauseButton.interactable = true;
			pausePanelCG.alpha = 0;
			pausePanelCG.interactable = false;
			pausePanelCG.blocksRaycasts = false;
		}
	}
}
