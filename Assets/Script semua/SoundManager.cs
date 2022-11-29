// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public static class SoundManager
// {
//     public enum Sound
//     {
//         BirdJump,
//         Score,
//         Lose,
//     }

//     public static void PlaySound(Sound sound)
//     {
//         GameObject gameObject = new GameObject("Sound", typeof(AudioSource));
//         AudioSource audioSource = gameObject.GetComponent<AudioSource>();
//         audioSource.PlayOneShot(GetAudioClip(sound));
//     }

//     private static AudioClip GetAudioClip(Sound sound)
//     {
//         foreach (Player.SoundAudioClip soundAudioClip in Player.GetInstance().soundAudioClipArray)
//         {
//             if (soundAudioClip.sound==sound)
//             {
//                 return soundAudioClip.audioClip;
//             }
//         }
//         Debug.LogError("Sound"+sound+"not found");
//         return null;
//     }
// }
