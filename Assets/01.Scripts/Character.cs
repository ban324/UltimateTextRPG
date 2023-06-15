using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character 
{
    public string name;

    public int MaxHP;
    public int MaxMP;
    public int HP;
    public int MP;

    private int _atk;
    private int _mag;
    private int _def;
    private int _mdef;
    private int _speed;

    public StatusSO status;

    public int Atk
    {
        get { return _atk; }
        set { _atk = value; }
    }
    public int Int
    {
        get { return _mag; }
        set { _mag = value; }
    }
    public int Def
    {
        get { return _def; }
        set { _def = value; }
    }
    public int MDef
    {
        get { return _mdef; }
        set { _mdef = value; }
    }
    public int Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }
    public void SetStatus()
    {
        HP = status.HP;
        MP = status.MP;
        _atk = status.atk;
        _mag = status.mag;
        _def = status.def;
        _mdef = status.mdef;
        _speed = status.speed;
    }
}