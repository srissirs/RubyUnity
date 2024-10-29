using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public float displayTime = 4.0f;
    public GameObject dialogBox;
    public GameObject dialogBox2;
    float timerDisplay;
    
    void Start()
    {
        dialogBox.SetActive(false);
        dialogBox2.SetActive(false);
        timerDisplay = -1.0f;
    }
    
    void Update()
    {
        if (timerDisplay >= 0)
        {
            timerDisplay -= Time.deltaTime;
            if (timerDisplay < 0)
            {
                dialogBox.SetActive(false);
                dialogBox2.SetActive(false);
            }
        }
    }
    
    public void DisplayDialog()
    {
        GameObject playerObject = GameObject.FindWithTag("Character");
        if(playerObject!= null){
            RubyController player = playerObject.GetComponent<RubyController>();
            timerDisplay = displayTime;
            if(player.fixedEnemies==2){
                dialogBox2.SetActive(true);
            }else{
                dialogBox.SetActive(true);
            }
        }
    }
}