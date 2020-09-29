using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
  
    
    [SerializeField] moveScript move;
    [SerializeField] Transform target;
    Vector3 lastLocation;
    [SerializeField] Transform player;
 
   
    public AudioClip clip;
    float volume=5f;
     
    // Start is called before the first frame update
    void Start()
    {
     
        
    }

    // Update is called once per frame
    void Update()
    {
       if(move.isHolding()==true){
           if(Vector3.Distance(transform.position,player.position)<2){
               transform.position=target.position;
               
           }
           
           
       }else{
          GetComponent<Rigidbody>().useGravity=true;
             
       }
    }
}
