using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shy_UIManager : MonoBehaviour
{
    GameObject BtManager;

    private void Awake()
    {
        BtManager = GameObject.Find("Bt");
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            BtReset();
            BtManager.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    public void OnClick(string name)
    {
        switch (name)
        {
            case "Attack":
                BtReset();
                BtManager.transform.GetChild(1).gameObject.SetActive(true);
                break;

            case "Skill":
                BtReset();
                BtManager.transform.GetChild(2).gameObject.SetActive(true);
                break;

            default:
                break;

        }
    }


    void BtReset()
    {
        for (int i = 0; i < BtManager.transform.childCount; i++)
        {
            BtManager.transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
