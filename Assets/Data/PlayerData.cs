using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "MyScriptable/Create PlayerData")]
public class PlayerData : ScriptableObject
{
    [SerializeField] private int life;
    [SerializeField] private int water;
    [SerializeField] private int food;
    [SerializeField] private int injury;
    [SerializeField] private int survival;
    [SerializeField] private int escape;

    public int Life
    {
        get { return life; }
        set { life = value; }
    }
    public int Water
    {
        get { return water; }
        set { water = value; }
    }
    public int Food
    {
        get { return food; }
        set { food = value; }
    }
    public int Injury
    {
        get { return injury; }
        set { injury = value; }
    }
    public int Survival
    {
        get { return survival; }
        set { survival = value; }
    }
    public int Escape
    {
        get { return escape; }
        set { escape = value; }
    }
}
