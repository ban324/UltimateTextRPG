using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SKLL_TYPE
{
    PHYSIC,
    MAGIC,
    BUFF,
    DEBUFF
}
public abstract class Skill 
{
    public PHYSIC_TYPE current_PType;
    public MAGIC_TYPE current_MType;
    public int damage;
    public void SetType(PHYSIC_TYPE pType, MAGIC_TYPE mType)
    {
        current_PType = pType;
        current_MType = mType;
    }
    public abstract void OnActive(List<Character> target, int pDamage = 0, int mDamage = 0);

}
