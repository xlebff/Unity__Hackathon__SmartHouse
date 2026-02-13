using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teapot : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private AudioSource boiling, boiled;

    public void Boiling()
    {
        anim.enabled = true;
        boiling.Play();
    }

    public void Boiled()
    {
        anim.Play("Boiled");
        boiled.Play();
    }

    public void Done()
    {
        anim.enabled = false;
    }
}