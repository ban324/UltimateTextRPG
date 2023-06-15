using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill 
{
    public abstract void OnActive(List<Character> target, int damage = 0);

}
