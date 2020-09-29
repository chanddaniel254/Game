using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifTouched : MonoBehaviour
{
  
    [SerializeField] Inventory inventory;
    public GameObject item;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
           
            print("keyPressed");
        }
    }

     private void OnTriggerEnter(Collider other) {

         
        if(other.gameObject.tag=="Player"){
            
             for(int i=0;i<inventory.slots.Length;i++){
                 if(inventory.isFull[i]==false){
                     inventory.isFull[i]=true;
                     Instantiate(item,inventory.slots[i].transform,false);
                    gameObject.SetActive(false);
                     break;
                 }
                 print("touched");
             }
        
        }
      
    }
}
