using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManage : MonoBehaviour
{
    [SerializeField] private GameObject _doorClose;
    private const string PLAYER = "Player";
    private const string BOT = "Bot";
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(PLAYER) || other.CompareTag(BOT))
        {
            Debug.Log("Door");
            _doorClose.SetActive(false);

        }
        else
        {
            _doorClose.SetActive(true);
        }

    }
}
