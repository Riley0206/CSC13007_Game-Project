using System.Collections;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] AudioClip MusicOnStart;

    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        Play(MusicOnStart, true);
    }


    AudioClip switchToMusic;
    public void Play(AudioClip music, bool interrupt = false)
    {
        if (interrupt)
        {
            audioSource.Stop();
            audioSource.clip = music;
            audioSource.Play();
            return;
        }
        else
        {
            switchToMusic = music;
            StartCoroutine(FadeOut());
        }
    }

    float volume;
    [SerializeField] float timeToSwitch;
    IEnumerator FadeOut()
    {
        volume = 1f;
        while (volume > 0)
        {
            volume -= Time.deltaTime / timeToSwitch;
            if (volume < 0)
            {
                volume = 0;
            }
            audioSource.volume = volume;
            yield return new WaitForEndOfFrame();
        }
        Play(switchToMusic, true);
    }
}
