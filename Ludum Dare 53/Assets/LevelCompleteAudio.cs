using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteAudio : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
    
    void OnEnable()
    {
        AudioManager.Instance.PlaySound(_clip);
    }
}
