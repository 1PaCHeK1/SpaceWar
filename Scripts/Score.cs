using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    Text ScoreNum;
    public int Price = 1;
    void Start()
    {
        ScoreNum = GameObject.Find("ScoreNum").GetComponent<Text>();
    }

    void OnTriggerEnter(Collider obj)
	{
		if(obj.GetComponent<Enemy>().player == true)
		{
			ScoreNum.text = (int.Parse(ScoreNum.text)+Price).ToString();
		}
	}
}
