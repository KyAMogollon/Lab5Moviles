using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypePath { none,nave1, nave2, nave3 }
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CreateNave", order = 1)]
public class KindNaves : ScriptableObject
{
    public TypePath name;
    public Sprite sprite;
    public Color colorNave;
    public int live;
    public int velocityVertical;
    public int velocityHorizontal;

    public TypePath Nombre()
    {
        return name;
    }
    public Sprite LoadSprite()
    {
        return sprite;
    }
    public Color ColorNave()
    {
        return colorNave;
    }
    public int VelocityVertical()
    {
        return velocityVertical;
    }
    public int VelocityHorizontal()
    {
        return velocityHorizontal;
    }
    public int Live()
    {
        return live;
    }

}
