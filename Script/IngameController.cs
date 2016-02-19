using UnityEngine;
using System.Collections;

public class IngameController : MonoBehaviour 
{
    private GameObject gameOverContainer;
    private GameObject winContainer;
    private GameObject pauseContainer; 

	// Use this for initialization
	void Start () 
    {
        gameOverContainer = GameObject.Find("GameOverContainer");
        winContainer = GameObject.Find("WinContainer");
        pauseContainer = GameObject.Find("PauseContainer");
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void LoserNotification(GameObject g)
    {
        if(g.tag == "Player")
        {
            ShowGameOver();
        }
        else if(g.tag == "Enemy")
        {
            ShowWin();
        }
    }

    private void ShowGameOver()
    {
        gameOverContainer.GetComponent<ContainerController>().Open();
    }

    private void ShowWin()
    {
        winContainer.GetComponent<ContainerController>().Open();
    }

    public void Pause()
    {
        pauseContainer.GetComponent<ContainerController>().Open();
    }
}
