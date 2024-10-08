using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SequentialAudioPlayer : MonoBehaviour
{
    public List<AudioSource> audioSources;
    private int currentIndex = 0;
    private bool isPlaying = false;

    void Start()
    {
        // Ensure all audio sources are initially stopped
        foreach (AudioSource source in audioSources)
        {
            source.playOnAwake = false;
            source.Stop();
        }

        // Start the sequence
        StartCoroutine(PlayAudioSequentially());
    }

    IEnumerator PlayAudioSequentially()
    {
        while (true)
        {
            if (audioSources.Count > 0 && !isPlaying)
            {
                isPlaying = true;
                AudioSource currentSource = audioSources[currentIndex];

                currentSource.Play();
                yield return new WaitForSeconds(currentSource.clip.length);
                currentSource.Stop();

                currentIndex = (currentIndex + 1) % audioSources.Count;
                isPlaying = false;
            }
            yield return null;
        }
    }
}