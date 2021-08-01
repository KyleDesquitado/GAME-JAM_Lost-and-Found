using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    [SerializeField] AudioClip walkingSound;
    [SerializeField] AudioClip runningSound;
    [SerializeField] AudioClip buttonSound;
<<<<<<< HEAD
=======
    [SerializeField] AudioClip jumpStartSound;
    [SerializeField] AudioClip jumpEndSound;
    [SerializeField] AudioClip caughtSound;
>>>>>>> parent of 215cc06 (Delete SFXManager.cs)

    [SerializeField] private AudioSource audioSourceSFX;
    // Start is called before the first frame update
    void Start()
    {
        audioSourceSFX = this.gameObject.GetComponent<AudioSource>();
<<<<<<< HEAD
        EventBroadcaster.Instance.AddObserver(EventNames.ON_PLAYER_WALK_SFX, playWalkingSound);
        EventBroadcaster.Instance.AddObserver(EventNames.ON_PLAYER_WALK_STOP_SFX, stopWalkingSound);

        EventBroadcaster.Instance.AddObserver(EventNames.ON_PLAY_BUTTON_SFX, playButtonSound);

        EventBroadcaster.Instance.AddObserver(EventNames.ON_PLAYER_CAUGHT, stopWalkingSound);
        EventBroadcaster.Instance.AddObserver(EventNames.ON_STOP_ALL_SFX, stopAllSounds);

=======

        EventBroadcaster.Instance.AddObserver(EventNames.ON_PLAYER_WALK_SFX, playWalkingSound);
        EventBroadcaster.Instance.AddObserver(EventNames.ON_PLAYER_JUMP_START_SFX, playJumpStartSound);
        EventBroadcaster.Instance.AddObserver(EventNames.ON_PLAYER_JUMP_END_SFX, playJumpEndSound);
        EventBroadcaster.Instance.AddObserver(EventNames.ON_PLAYER_CAUGHT, playCaughtSound);


        //ui button clicks
        EventBroadcaster.Instance.AddObserver(EventNames.ON_OPTIONS_MENU, playButtonSound);
        EventBroadcaster.Instance.AddObserver(EventNames.ON_PAUSE_GAME, playButtonSound);
        EventBroadcaster.Instance.AddObserver(EventNames.ON_RESUME_GAME, playButtonSound);
        EventBroadcaster.Instance.AddObserver(EventNames.ON_QUIT_TO_MENU, playButtonSound);
        EventBroadcaster.Instance.AddObserver(EventNames.ON_QUIT_GAME, playButtonSound);
        EventBroadcaster.Instance.AddObserver(EventNames.ON_START_GAME, playButtonSound);


        EventBroadcaster.Instance.AddObserver(EventNames.ON_PLAYER_WALK_STOP_SFX, stopWalkingSound);
        EventBroadcaster.Instance.AddObserver(EventNames.ON_PLAYER_CAUGHT, stopWalkingSound);

        EventBroadcaster.Instance.AddObserver(EventNames.ON_STOP_ALL_SFX, stopAllSounds);



>>>>>>> parent of 215cc06 (Delete SFXManager.cs)
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(EventNames.ON_PLAYER_WALK_SFX);
        EventBroadcaster.Instance.RemoveObserver(EventNames.ON_PLAYER_WALK_STOP_SFX);

<<<<<<< HEAD
        EventBroadcaster.Instance.RemoveObserver(EventNames.ON_PLAY_BUTTON_SFX);
=======
        EventBroadcaster.Instance.RemoveObserver(EventNames.ON_OPTIONS_MENU);
        EventBroadcaster.Instance.RemoveObserver(EventNames.ON_PAUSE_GAME);
        EventBroadcaster.Instance.RemoveObserver(EventNames.ON_RESUME_GAME);
        EventBroadcaster.Instance.RemoveObserver(EventNames.ON_QUIT_TO_MENU);
        EventBroadcaster.Instance.RemoveObserver(EventNames.ON_QUIT_GAME);
        EventBroadcaster.Instance.RemoveObserver(EventNames.ON_START_GAME);
>>>>>>> parent of 215cc06 (Delete SFXManager.cs)

    }
    private void playWalkingSound(Parameters parameters)
    {
        bool isWalking = parameters.GetBoolExtra("isWalking", false);

        if (isWalking)
            audioSourceSFX.clip = walkingSound;

        else
            audioSourceSFX.clip = runningSound;
        if (!audioSourceSFX.isPlaying)
            audioSourceSFX.Play();
<<<<<<< HEAD
=======

        //Debug.Log("play walking sound");
>>>>>>> parent of 215cc06 (Delete SFXManager.cs)
    }

    private void stopWalkingSound()
    {
        if (audioSourceSFX != null)
        {
<<<<<<< HEAD
            if (audioSourceSFX.clip == walkingSound || audioSourceSFX.clip == runningSound)
                audioSourceSFX.Stop();
        }
        
=======
            if ((audioSourceSFX.clip == walkingSound || audioSourceSFX.clip == runningSound) && audioSourceSFX.isPlaying == true)
                audioSourceSFX.Stop();
        }
        Debug.Log("Stop walking sound");
        
    }

    private void playJumpStartSound()
    {
        //audioSourceSFX.clip = jumpStartSound;
        AudioSource.PlayClipAtPoint(jumpStartSound, transform.position, audioSourceSFX.volume);
        
        {
            Debug.Log("playing jump start sound");
        }
    }

    private void playJumpEndSound()
    {
        AudioSource.PlayClipAtPoint(jumpEndSound, transform.position, audioSourceSFX.volume);
        {
            Debug.Log("playing jump end sound");
        }
    }

    private void playCaughtSound()
    {
        //audioSourceSFX.clip = jumpStartSound;
        AudioSource.PlayClipAtPoint(caughtSound, transform.position, audioSourceSFX.volume);

        {
            Debug.Log("playing caught sound");
        }
>>>>>>> parent of 215cc06 (Delete SFXManager.cs)
    }

    private void playButtonSound()
    {
        audioSourceSFX.PlayOneShot(buttonSound);
    }
    
    private void stopAllSounds()
    {
        if (audioSourceSFX != null)
        {
            if (audioSourceSFX.isPlaying)
                audioSourceSFX.Stop();
        }
        
    }
}
