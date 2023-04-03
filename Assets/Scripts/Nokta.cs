using System;
using UnityEngine;

public class Nokta : MonoBehaviour
{
    public Color color;
    public NoktaOlusturucusu parent;


    void OnMouseDown()
    {
        parent.OnClick(this);
    }

    
}
