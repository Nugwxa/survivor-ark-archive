using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class SoundController : MonoBehaviour {

    public AudioMixerGroup audioMixer;

	public void PlaySound (AudioSource audioS, AudioClip clip, bool randomizePitch = false, float randomPitchMin = 1, float randomPitchMax = 1) {

		audioS.clip = clip;

		if (randomizePitch == true) {
			audioS.pitch = Random.Range (randomPitchMin, randomPitchMax);
		}

		audioS.Play ();
	}

	public void InstantiateClip (Vector3 pos, AudioClip clip, float time = 2f, bool randomizePitch = false, float randomPitchMin = 1, float randomPitchMax = 1) {
		GameObject clone = new GameObject ("one shot audio");
		clone.transform.position = pos;
		AudioSource audio = clone.AddComponent<AudioSource> ();
		audio.spatialBlend = 1;
		audio.volume = 0.5f;
		audio.clip = clip;
        audio.outputAudioMixerGroup = audioMixer;

		audio.Play ();

		Destroy (clone, time);
	}
}
