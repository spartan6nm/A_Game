using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    public Transform player;
    public Text level;
    
    void Awake()
    {
        level.text = "LEVEL: " + SceneManager.GetActiveScene().buildIndex;
    }
    void Update()
    {
        GetComponent<Text>().text = Mathf.Round(player.position.z).ToString();
    }

}
