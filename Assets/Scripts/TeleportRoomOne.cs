using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportRoomOne : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider Col){
        Col.transform.position = new Vector3(505,0,160);
    }
}
