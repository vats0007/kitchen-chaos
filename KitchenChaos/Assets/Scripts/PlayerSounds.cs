using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    [SerializeField] private float volume = 1f;
    private Player player;
    private float footStepTimer;
    private float footStepTimerMax = 0.1f;

    private void Awake()
    {
        player = GetComponent<Player>();
    }

    private void Update()
    {
        footStepTimer -= Time.deltaTime;
        if(footStepTimer < 0f)
        {
            footStepTimer = footStepTimerMax;

            if (player.IsWalking())
            {
                SoundManager.Instance.PlayFootStepsSound(player.transform.position, volume);
            }
        }
    }
}
