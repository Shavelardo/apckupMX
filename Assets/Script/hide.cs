using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("PiedraMala"))
        {

            gameObject.SetActive(false);
        }

    }

}
