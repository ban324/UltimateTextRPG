using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StatusSO : ScriptableObject
{
    [Header("�̸�")]
    public string name;
    [Header("ü�� �� ����")]
    public int HP;
    public int MP;
    [Header("����")]
    public int atk;
    public int mag;
    public int def;
    public int mdef;
    public int speed;
}
