using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMover2 : MonoBehaviour
{
    [SerializeField] protected KeyCode wKeyCode;
    [SerializeField] protected KeyCode sKeyCode;
    [SerializeField] protected KeyCode aKeyCode;
    [SerializeField] protected KeyCode dKeyCode;
    [SerializeField] protected float stepsize = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKey(wKeyCode)){
            transform.position+= new Vector3(0,stepsize * Time.deltaTime,0);
        }
        if(Input.GetKey(sKeyCode)){
            transform.position+= new Vector3(0,-stepsize * Time.deltaTime,0);
        }
        if(Input.GetKey(aKeyCode)){
            transform.position+= new Vector3(-stepsize * Time.deltaTime,0,0);
        }
        if(Input.GetKey(dKeyCode)){
            transform.position+= new Vector3(stepsize * Time.deltaTime,0,0);
        }
    }
}
