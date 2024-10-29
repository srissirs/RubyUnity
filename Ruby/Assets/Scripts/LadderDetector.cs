using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderDetector : MonoBehaviour
{
    [SerializeField] 
    private RubyController player;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision) {
        
        if(collision.GetComponent<Ladder>())
        {
            player.ClimbingAllowed = true;
        }
       
    }


   private void OnTriggerExit2D(Collider2D collision) {
    
    if(collision.GetComponent<Ladder>())
        {
            player.ClimbingAllowed = false;
        }
   }
    
}
