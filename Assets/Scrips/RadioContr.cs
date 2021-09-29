using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioContr : MonoBehaviour
{
    public AudioClip[] allmusic;

    private AudioSource audioS;

    public float leghtnowclip;
    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();
        SetRandomclip();
        Startplay();
        
    }

    public void SetRandomclip()
    {
        AudioClip c = allmusic[Random.Range(0, allmusic.Length)];
        if (c != audioS.clip)
        {
                leghtnowclip = c.length;
                audioS.clip = c;
                audioS.Play();
        }
    }
    public void Startplay()
    {
        audioS.Play();
    }

    // Update is called once per frame
    void Update()
    {
        leghtnowclip -= Time.deltaTime;
        if (leghtnowclip < 0)
        {
            SetRandomclip();
            
        }
    }
}
