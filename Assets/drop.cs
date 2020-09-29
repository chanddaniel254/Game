using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    [SerializeField] Inventory inventory;
    [SerializeField] GameObject laptop;
    [SerializeField] Transform playerCarrier;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ifPressed(){
        GameObject obj = Instantiate(prefab) as GameObject;
        obj.transform.position=playerCarrier.position;
 
    }
}

