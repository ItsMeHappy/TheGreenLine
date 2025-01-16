using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ResourceSender : MonoBehaviour
{
    public GameObject SendMenu;
    public GameObject ResourceManager;
    public ResourceManager resourceManager;

    public GameObject ResourceBoat;

    public bool BoatSent;

    void Start()
    {
        resourceManager = ResourceManager.GetComponent<ResourceManager>();
        SendMenu.SetActive(false);
    }

    

    void FixedUpdate()
    {
        
    }

    public void OpenSend()
    {
        SendMenu.SetActive(true);
    }

    public void CloseSend()
    {
        SendMenu.SetActive(false);
    }

    public void SendBoat()
    {
            BoatSent = true;
            Debug.Log("Steel Sent");
            resourceManager.Steel -= 10;

    }
    

    //public void SendR2()
    //{
        
    //}

    //public void SendR3()
    //{

    //}

        public void RecieveResources()
        {

        }

}
