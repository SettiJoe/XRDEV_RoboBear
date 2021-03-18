using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingVR : GrabbableObjectVR
{
    public GameObject pelletPreFab;
    public float shootingForce;
    public Transform spawnPoint;


    void Start()
    {
        
    }


    public override void OnInteraction()
    {
        GameObject spawnedPellet = Instantiate(pelletPreFab,spawnPoint.parent.position, spawnPoint.rotation);
        spawnedPellet.GetComponent<Rigidbody>().AddForce(spawnedPellet.transform.forward * shootingForce);
        Destroy(spawnedPellet, 3);
    }
}
