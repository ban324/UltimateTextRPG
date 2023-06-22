using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shy_UIManager : MonoBehaviour
{
    GameObject BtManager;
    int SkillSign = 0;

    private void Awake()
    {
        BtManager = GameObject.Find("Bt");
    }

    private void Update()
    {
        SkillSign = Mathf.Clamp(SkillSign, 0, BtManager.transform.GetChild(2).transform.childCount -1);

        if (Input.GetMouseButtonDown(1))
        {
            BtReset();
            BtManager.transform.GetChild(0).gameObject.SetActive(true);
        }

        float x = Input.GetAxis("Mouse ScrollWheel") * 10;
        if(BtManager.transform.GetChild(2).gameObject.activeSelf == true)
        {
            if (x < 0)
            {
                Scroll("Up");
            }

            else if(x > 0)
            {
                Scroll("Down");
            }
        }
    }

    void Scroll(string dir)
    {
        if (dir == "Up" && SkillSign != BtManager.transform.GetChild(2).transform.childCount - 2)
        {
            SkillSign += 1;
        }

        else if (dir == "Down" && SkillSign != 0)
        {
            SkillSign -= 1;
        }

        SkillIcon();
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
                SkillSign = 0;
                SkillIcon();
                break;

            default:
                break;

        }
    }

    void SkillIcon()
    {
        for(int i = 0; i < BtManager.transform.GetChild(2).transform.childCount; i++)
        {
            BtManager.transform.GetChild(2).transform.GetChild(i).gameObject.SetActive(false);
        }
       
        BtManager.transform.GetChild(2).transform.GetChild(SkillSign).gameObject.SetActive(true);
        BtManager.transform.GetChild(2).transform.GetChild(SkillSign + 1).gameObject.SetActive(true);
    }

    void BtReset()
    {
        for (int i = 0; i < BtManager.transform.childCount; i++)
        {
            BtManager.transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
