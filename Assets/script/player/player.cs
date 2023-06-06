using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Forcemultiplier;
    public int vidaPlayer;
 
    protected virtual void Movilidad() { }
    protected virtual void vida() { }
    protected virtual void Dead() { }
    
}
