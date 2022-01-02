using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySFX : MonoBehaviour
{

    public void PlayButtonSFX()
    {
        
        // son bouton menu
        SoundPlayer.instance.PlaySFX(Resources.Load<AudioClip>("Sound/SFX/FitCrack"), 1f);
        
    }
    
}