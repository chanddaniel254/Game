using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openBagScript : MonoBehaviour
{
    [SerializeField] GameObject inventory;
    bool bagOpened=false;
    [SerializeField] GameObject closebutton;
        [SerializeField] GameObject openbutton;
    // Start is called before the first frame update
    void Start()
    {
        inventory.SetActive(false);

     closebutton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openBag(){
        
                  inventory.SetActive(true);
        Time.timeScale=0f;
        bagOpened=true;
        closebutton.SetActive(true);
        openbutton.SetActive(false);
        print("enabled");
        
        
       
    }
    public void closeBag(){
    
            bagOpened=false;
            Time.timeScale=1f;
            inventory.SetActive(false);
             closebutton.SetActive(false);
        openbutton.SetActive(true);
            print("disabled");
        
      
    }
}
