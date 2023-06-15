using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    List<Character> characters= new List<Character>();

    public void TurnProcesses()
    {
        foreach(Character character in characters)
        {
            character.selectedSkill.OnActive(character.target, character.Atk, character.Mag);
        }
    }
}
