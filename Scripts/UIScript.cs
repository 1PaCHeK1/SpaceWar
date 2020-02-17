using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    // Start is called before the first frame update
	
	void Start()
	{
		Text text = GameObject.Find("Score").GetComponent<Text>();
		text.text = PlayerPrefs.GetInt("BestScore").ToString();
	}
    public void StartButton() 
	{
	 Application.LoadLevel(1);
	}
	
	// Update is called once per frame
	public void ExitButton () {
	    Application.Quit();
	}
    
}
