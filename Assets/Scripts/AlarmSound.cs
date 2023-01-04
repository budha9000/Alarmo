using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmSound : MonoBehaviour
{
    public AudioSource soundPlayer;
    private bool alarmStatus = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void alarmToggle() {
        if(alarmStatus) {
            soundPlayer.Stop();
            alarmStatus = false;
        } else {
            soundPlayer.Play();
            alarmStatus = true;
        }
        
    }
}
