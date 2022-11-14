using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class PickUp : MonoBehaviour
{
    protected int score;
    protected int heal;
    protected GameObject clone;

    public abstract GameObject Spawn();
    public abstract PickUp Clone();
}

public class Coin: PickUp
{
   

    public Coin(GameObject clone, int score)
    {
        this.score = score;
        this.clone = clone;
    }

    public override GameObject Spawn()
    {
        if (!clone.GetComponent<Collectable>())
        {
            clone.AddComponent<Collectable>();
        }

        clone.GetComponent<Collectable>().score = score;
        return clone;
    }

    public override PickUp Clone()
    {
        return new Coin(Instantiate(clone), score);
    }
}

public class FullHeart : PickUp
{

    public FullHeart(GameObject clone, int heal)
    {
        this.heal = heal;
        this.clone = clone;
    }

    public override GameObject Spawn()
    {
        if (!clone.GetComponent<Collectable>())
        {
            clone.AddComponent<Collectable>();
        }

        clone.GetComponent<Collectable>().heal = heal;
        return clone;
    }

    public override PickUp Clone()
    {
        return new FullHeart(Instantiate(clone), heal);
    }
}


