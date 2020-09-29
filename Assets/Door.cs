using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float range=3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     bool isCorrect=   Vector3.Distance(transform.position,target.position)<range;
     if(isCorrect){
         GetComponent<Animator>().SetBool("open",true);
     }
     else{
         GetComponent<Animator>().SetBool("open",false);
     }
    }
}
