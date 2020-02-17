using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.Linq;
public class Enemy : MonoBehaviour
{
    GameObject Player;
    public GameObject DestroyPrefab;

    public bool player = false;

    string[] Wall = {"Wall1", "Wall2", "Wall3", "Wall4", "Walk5"};
    void Start()
    {
        Player = GameObject.Find("Player");
    }
    void OnTriggerEnter(Collider other)
    {
        //print($"{other.name} -- {other.GetComponent<Enemy>()?.player}");
        if(other.name == Player.name)
        {
            Destroy(Player);
            Destroy(gameObject);
            {
                Text text = GameObject.Find("ScoreNum").GetComponent<Text>();
                if(PlayerPrefs.GetInt("BestScore") < int.Parse(text.text))
                {
                    PlayerPrefs.SetInt("BestScore", int.Parse(text.text));
                }
            }
            Application.LoadLevel(2);
        }
        else if(other.GetComponent<Enemy>()?.player == true)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            if(DestroyPrefab != null)
            {
                GameObject obj = Instantiate(DestroyPrefab, transform.position, transform.rotation) as GameObject;
                Destroy(obj, 0.3f);
            }
        }
    }
}
 