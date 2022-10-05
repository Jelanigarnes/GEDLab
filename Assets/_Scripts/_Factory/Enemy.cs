using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
  public abstract string Name { get; }

  public abstract GameObject Create(GameObject prefab);


}


public class crab : Enemy
{
    public override string Name => "crab";
    public override GameObject Create(GameObject prefab)
    {
        GameObject enemy = Instantiate(prefab);
        Debug.Log("crab enemy is created");
        return enemy;
    }
}

public class Monster : Enemy
{
    public override string Name => "monster";
    public override GameObject Create(GameObject prefab)
    {
        GameObject enemy = Instantiate(prefab);
        Debug.Log("monster enemy is created");
        return enemy;
    }
}