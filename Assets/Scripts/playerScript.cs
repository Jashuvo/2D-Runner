using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    [SerializeField]
    private Rigidbody playerRigid;
    public GameObject[] roadCreator;


    
    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        playerRigid.velocity = new Vector3(0, 0, 25);
    }



    
    private void OnTriggerEnter(Collider collsion)
    {
        int random = Random.Range(0, 5);
        if (collsion.gameObject.tag == "RoadCreator")
        {
            Instantiate(roadCreator[random], new Vector3(0, 0, 750), Quaternion.identity);
        }
    }
}
