using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeToBlack : MonoBehaviour
{
    public Animator animator;

    public delegate void onFadedOut();
    
    public static FadeToBlack Instance { get; private set; }
    private onFadedOut ofo;

    public void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void Fade(onFadedOut ofo)
    {
        this.ofo = ofo;
        animator.SetTrigger("FadeOut");
    }

    // This is triggered by the FadeOut animation when the animation completed
    void OnFadeComplete()
    {
        ofo();
        animator.SetTrigger("FadeIN");
    }

}
