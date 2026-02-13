using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opening : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private AudioSource sound;

    [SerializeField] private bool open = false;

    public void Check()
    {
        if (open)
        {
            anim.Play("Close");
            open = false;
        }
        else
        {
            if (!anim.enabled) anim.enabled = true;
            anim.Play("Open");
            open = true;
        }
        sound.Play();
    }
}