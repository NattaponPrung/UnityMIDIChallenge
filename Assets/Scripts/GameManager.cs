using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;
    public KeyCode key;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Score",0);
    }

    // Update is called once per fram
    void Update()
    {
         if(Input.GetKeyDown(key))
         Application.LoadLevel(0);
    }
    void OnTriggerEnter2D(Collider2D col){
        Destroy(col.gameObject);
    }

    public int GetScore(){
        return score;
    }
}
