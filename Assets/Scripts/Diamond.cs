using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{

    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (other.gameObject.tag == "Player")
        {
            playerInventory.DiamondCollected();
            Destroy(this.gameObject);
        }
    }
}
