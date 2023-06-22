using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defense : Skill
{
    public override void OnActive(List<Character> target, int damage = 0)
    {
        target[0].onDefend = true;
    }
}
