using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Platform : MonoBehaviour
{
    protected int width;
    protected int height;
    protected GameObject clone;

    public abstract GameObject Spawn();
    public abstract Platform Clone();

    public class CustomizablePlatform : Platform
    {
        public CustomizablePlatform(int width, int height, GameObject clone)
        {
            this.width = width;
            this.height = height;
            this.clone = clone;
        }

        public override GameObject Spawn()
        {
            clone.transform.localScale = new Vector3(width, height, clone.transform.localScale.z);
            return clone;
        }

        public override Platform Clone()
        {
            return new CustomizablePlatform(width, height, Instantiate(clone));
        }

    }

}
