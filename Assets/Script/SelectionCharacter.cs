using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.SceneManagement;

public class SelectionCharacter : SingletonGenericPersist<SelectionCharacter>
{
    [SerializeField] KindNaves[] nave;
    public Sprite sprite;
    public int live;
    public int velocityVertical;
    public int velocityHorizontal;
    public TypePath name;
    public Color colornNavE;
    public override void Awake()
    {
        base.Awake();
    }
    public void Start()
    {
        name = TypePath.none;
    }
    public void ChooseNave1()
    {
        sprite = nave[0].LoadSprite();
        colornNavE = nave[0].ColorNave();
        velocityHorizontal = nave[0].VelocityHorizontal();
        velocityVertical = nave[0].VelocityVertical();
        name = nave[0].Nombre();
        live = nave[0].Live();
    }
    public void ChooseNave2()
    {
        sprite = nave[1].LoadSprite();
        colornNavE = nave[1].ColorNave();
        velocityHorizontal = nave[1].VelocityHorizontal();
        velocityVertical = nave[1].VelocityVertical();
        name = nave[1].Nombre();
        live = nave[1].Live();

    }
    public void ChooseNave3()
    {
        sprite = nave[2].LoadSprite();
        colornNavE = nave[2].ColorNave();
        velocityHorizontal = nave[2].VelocityHorizontal();
        velocityVertical = nave[2].VelocityVertical();
        name = nave[2].Nombre();
        live = nave[2].Live();
    }
    public void VerifyCharacter()
    {
        if (name != TypePath.none)
        {
            SceneManager.LoadScene("SelecctionGame");
        }
    }
}
