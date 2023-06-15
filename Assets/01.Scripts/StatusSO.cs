using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StatusSO : ScriptableObject
{
    [Header("이름")]
    public string name;
    [Header("체력 및 마나")]
    public int HP;
    public int MP;
    [Header("스탯")]
    public int atk;
    public int mag;
    public int def;
    public int mdef;
    public int speed;
}
