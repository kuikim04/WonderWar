using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManger : MonoBehaviour
{
    public static AudioClip HitSound, ExplosionSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        HitSound = Resources.Load<AudioClip>("hitsound");
        ExplosionSound = Resources.Load<AudioClip>("ExplosionSound");

        audioSrc = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "hitsound":
                audioSrc.PlayOneShot(HitSound);
                break;

            case "ExplosionSound":
                audioSrc.PlayOneShot(ExplosionSound);
                break;
        }
    }
}
