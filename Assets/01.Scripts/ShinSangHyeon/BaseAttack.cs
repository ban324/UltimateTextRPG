using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAttack : Skill
{
    SKLL_TYPE current_skilltype;
    override public void OnActive(List<Character> target, int pDamage = 0, int mDamage = 0)
    {
        if (current_skilltype == SKLL_TYPE.PHYSIC) damage = pDamage;
        else damage = mDamage;
        for (int i=0; i < target.Count; i++)
        {
            target[i].TakeDamage(current_PType, current_MType, current_skilltype, damage);
        }
    }
}
