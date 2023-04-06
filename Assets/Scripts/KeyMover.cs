using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMover : MonoBehaviour{

    [SerializeField] protected KeyCode up;
    [SerializeField] protected KeyCode down;
    [SerializeField] protected KeyCode left;
    [SerializeField] protected KeyCode right;
    [SerializeField] protected float stepsize = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKey(up)){
            transform.position+= new Vector3(0,stepsize * Time.deltaTime,0);
        }
        if(Input.GetKey(down)){
            transform.position+= new Vector3(0,-stepsize * Time.deltaTime,0);
        }
        if(Input.GetKey(left)){
            transform.position+= new Vector3(-stepsize * Time.deltaTime,0,0);
        }
        if(Input.GetKey(right)){
            transform.position+= new Vector3(stepsize * Time.deltaTime,0,0);
        }
    }
}
