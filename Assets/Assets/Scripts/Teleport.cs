using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("TELEPORT");
        thePlayer.transform.position = teleportTarget.transform.position;
    }
}
