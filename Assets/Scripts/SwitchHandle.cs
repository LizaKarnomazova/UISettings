using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SwitchHandle : MonoBehaviour
{
    public GameObject On;
    public GameObject Off;
    private bool isEnable;

    private void Start()
    {
        ChangeState();
    }

    public void ChangeState()
    {
        isEnable = !isEnable;
        On.SetActive(isEnable);
        Off.SetActive(!isEnable);
    }

}

