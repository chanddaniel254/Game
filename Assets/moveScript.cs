using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class moveScript : MonoBehaviour
{
     NavMeshAgent navMeshAgent;
     
     [SerializeField] Transform carry;
       [SerializeField] Transform box;
        [SerializeField] AudioSource PickUpaudio;
     
     bool holding=false;
    
    // Start is called before the first frame update
    void Start()
    {
      navMeshAgent=  GetComponent<NavMeshAgent>();
     
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
           
           move();
        }
        if(Input.GetMouseButtonDown(1)){
             if(Vector3.Distance(transform.position,box.position)<2){
                  pickUpRayCast();
                  PickUpaudio.Play();
             }
            
           
        }

        
      walkAnimation();

      
    }

   


    private void pickUpRayCast(){
        if(holding==false){
            
                
            Ray ray;
              ray=Camera.main.ScreenPointToRay(Input.mousePosition);
              RaycastHit hit;
             Physics.Raycast(ray,out hit);
            Target target=hit.transform.GetComponent<Target>();
             if(target!=null){
                 target.GetComponent<Rigidbody>().useGravity=false;
                 
                 holding=true;
               

             }
             
        }
        else{
            holding=false;
        }
     
             
       
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

    public bool isHolding(){
        return holding;
    }



    private void walkAnimation(){

        Vector3 velocity=navMeshAgent.velocity;
        Vector3 localVelocity=transform.InverseTransformDirection(velocity);

        float speed=localVelocity.z;
        GetComponent<Animator>().SetFloat("Blend",speed);
    }
}
