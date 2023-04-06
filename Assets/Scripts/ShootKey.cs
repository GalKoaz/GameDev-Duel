using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootKey: MonoBehaviour {
    [SerializeField] protected KeyCode keyToPress;
    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] protected Vector3 velocityOfSpawnedObject;
    public bool flag = true;

    // ReSharper disable Unity.PerformanceAnalysis
    protected virtual GameObject spawnObject() {
        // Step 1: spawn the new object.
        
        Vector3 positionOfSpawnedObject = transform.position;  // span at the containing object position.
        Quaternion rotationOfSpawnedObject = Quaternion.identity;  // no rotation.
        GameObject newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, rotationOfSpawnedObject);

        // Step 2: modify the velocity of the new object.
        Mover newObjectMover = newObject.GetComponent<Mover>();
        if (newObjectMover) {
            newObjectMover.SetVelocity(velocityOfSpawnedObject);
        }

        return newObject;
    }
    void Start()
    {
        //this.StartCoroutine(delay());       
    }
    private IEnumerator delay(){
        //while(true){
            
        if (Input.GetKeyDown(keyToPress)) spawnObject();
        //flag = false;
        //if (Input.GetKeyDown(keyToPress) && flag) spawnObject();
        yield return new WaitForSeconds(1f);
        //if (Input.GetKeyDown(keyToPress)&& flag) spawnObject();
        //flag = true;
        //if (Input.GetKeyDown(keyToPress)) spawnObject();
        // }
            
    }
    private void Update() {
        //if (Input.GetKeyDown(keyToPress) && flag) spawnObject();
        this.StartCoroutine(delay());
        //}
    }
}