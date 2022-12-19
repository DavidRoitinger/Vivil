using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnEnter : MonoBehaviour
{
  

    private void Awake()
    {
        FindObjectOfType<AudioManager>().StopAll();
    }
}
