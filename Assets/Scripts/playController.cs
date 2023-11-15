using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System;



public class playController : MonoBehaviour {

    public VideoPlayer videoPlayer;
    public VideoClip[] videoClips;
    private int videoClipIdx = 0;

    private void Start()
    {

        StartCoroutine(waitForVideo());
        
    }

    IEnumerator waitForVideo()
    {
        videoPlayer.clip = videoClips[videoClipIdx];
        videoPlayer.Play();
        yield return new WaitUntil(()=> videoPlayer.isPrepared);
        Debug.Log("video Length"+ videoPlayer.clip.length);
        Invoke(nameof(ChangeVideo), (float)videoPlayer.clip.length-2);
    }
    
    
    void ChangeVideo()
    {
        Debug.Log("End of Clip " + videoPlayer.clip.name);
        FadeToBlack.Instance.Fade(SetNextClip);
        Debug.Log("New clip "+ videoPlayer.clip.name);
        
    }



    public void SetNextClip()
    {
        var clip = GetNextClip();
        videoPlayer.clip = clip;
        videoPlayer.Play();
        Invoke(nameof(ChangeVideo), (float)clip.length-2);
    }
    
    private VideoClip GetNextClip()
    {
        videoClipIdx++;
        if (videoClipIdx >= videoClips.Length)
        {
            videoClipIdx = 0;
        }
        return videoClips[videoClipIdx];
    }
    
}
