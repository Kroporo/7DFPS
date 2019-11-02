using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource), typeof(Collider))]
public class SoundEventScript : MonoBehaviour {
    public float minOffset = 15;
    public float maxOffset = 30;

    public AudioClip[] turretFire;
    public AudioClip robotAlert;
    public AudioClip robotUnalert;

    private AudioSource audioSource;
    new private Collider collider;

    void Awake() {
        audioSource = GetComponent<AudioSource>();
        collider = GetComponent<Collider>();
    }

    private void PlaySound(AudioClip clip, float volume = 0.3f) {
        audioSource.PlayOneShot(clip, volume * PlayerPrefs.GetFloat("sound_volume"));
    }

    private void PlaySound(AudioClip[] group, float volume = 0.3f) {
        if(group.Length != 0) {
            PlaySound(group[Random.Range(0, group.Length)], volume);
        }
    }

    void OnTriggerEnter(Collider other) {
        if(other.tag != "Player") // Only trigger if the player triggered it
            return;

        collider.enabled = false;

        Vector3 dir = new Vector3(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)).normalized;
        transform.Translate(dir * (Random.Range(0, maxOffset - minOffset) + minOffset));

        StartCoroutine(TurretFire());
    }

    private IEnumerator Dispose() { // Destroy this game object once the audioSource is done playing the current clip
        while(audioSource.isPlaying) {
            yield return new WaitForSecondsRealtime(0.5f); // using realtime cause timescale does not affect audio playback
        }
        Destroy(gameObject);
    }

    private IEnumerator TurretFire() {
        // Aim stage
        PlaySound(robotAlert);
        yield return new WaitForSeconds(.8f);

        // Firing stage
        for (int i = Random.Range(3, 9) - 1; i >= 0; i--) {
            PlaySound(turretFire);
            yield return new WaitForSeconds(.12f);
        }

        // Reseting stage
        yield return new WaitForSeconds(2f);
        PlaySound(robotUnalert);
        StartCoroutine(Dispose());
    }

    private IEnumerator Beep() {
        // Aim stage
        PlaySound(robotAlert);

        // Reseting stage
        yield return new WaitForSeconds(2f);
        PlaySound(robotUnalert);
        StartCoroutine(Dispose());
    }
}
