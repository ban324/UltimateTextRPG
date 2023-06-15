using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public enum STATUS_DEBUFF
{
    NONE,//������
    HANGNAIL,//�Ž����̰� ���� �Ű澲�δ�. ���ݷ� ����
    HEADACHE,//���� / 2, ���������ϴ� ����?
    WET,//����/2
    MYALGIA,//������
    DRUNK,//���ؼ� �ӵ��� ����, =���ڰ���
    POISON,//�˵�
    STUN,//����!�� 1ȸ �ѱ�
    DEAD//���� ����. ��ü�� �� ����.
}
public enum STATUS_BUFF
{
    NONE,
    ATK_UP,
    MAG_UP,
    DEF_UP,
    MDEF_UP,
    SPEED_UP
    
}

public enum PHYSIC_TYPE
{
    SLASH,
    SMASH,
    STING,
    BERSERK
}

public enum MAGIC_TYPE
{
    A,
    B,
    C,
    MBERSERK
}

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

    public PHYSIC_TYPE current_PType;
    public MAGIC_TYPE current_MType;

    public PHYSIC_TYPE physics_Weakness;
    public MAGIC_TYPE magic_Weakness;
    
    public PHYSIC_TYPE physics_Strength;
    public MAGIC_TYPE magic_Strength;

    

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

    public void  TakeDamage(PHYSIC_TYPE pType, MAGIC_TYPE mType,SKLL_TYPE sType, int damage)
    {
        damage *= 1 - (Def / (1 + Def));
        switch (sType)
        {
            case SKLL_TYPE.PHYSIC:
                if(pType == physics_Weakness)
                {
                    damage *= 2;
                }else if(pType == physics_Strength)
                {
                    if (Random.Range(0, 100) <= (HP / MaxHP) * 100)
                    {
                        damage *= 3;
                    }
                    else damage /= 2;
                }
                break;
            case SKLL_TYPE.MAGIC:
                if (mType == magic_Weakness)
                {
                    damage *= 2;
                }
                else if (mType == magic_Strength)
                {
                    if (Random.Range(0, 100) <= (HP / MaxHP) * 100)
                    {
                        damage *= 3;
                    }
                    else damage /= 2;
                }
                break;
            case SKLL_TYPE.BUFF:
                break;
            case SKLL_TYPE.DEBUFF:
                break;
        }
        HP -= damage;
    }

    public Skill selectedSkill;
}