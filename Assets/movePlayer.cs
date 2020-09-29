using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class movePlayer : MonoBehaviour
{
     NavMeshAgent navMeshAgent;
     Target target;
    // Start is called before the first frame update
    void Start()
    {
      navMeshAgent=  GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
          //  move();
      pickUpRayCast();
        }

    }

   private void pickUpRayCast(){
     
      Ray ray;
              ray=Camera.main.ScreenPointToRay(Input.mousePosition);
              RaycastHit hit;
             Physics.Raycast(ray,out hit);
             bool hasHitBox=hit.transform.GetComponent<Target>();
             if(hasHitBox){
                 target.GetComponent<Rigidbody>().useGravity=false;
                 

             }
             print(hit.transform.name);
             
       
   }


    private void move(){
              
              Ray ray;
              ray=Camera.main.ScreenPointToRay(Input.mousePosition);
              RaycastHit hit;
             bool hasHit=  Physics.Raycast(ray,out hit);
             if(hasHit){
                 navMeshAgent.SetDestination(hit.point);
             }


    }
}
