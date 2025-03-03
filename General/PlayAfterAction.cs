// Handle playback of timeline animation
// Use to jump to specific point in timeline

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayAfterAction : MonoBehaviour
{
    // Start is called before the first frame update
    PlayableDirector director;
    public List<Action> actions;
    void Start()
    {
        director = GetComponent<PlayableDirector>();
    }

    [System.Serializable]
    public class Action
    {
        public string name; // Name of action
        public float time;
        public bool hasPlayed = false;
    }

   public void PlayActionIndex(int index )
    {
        Action action = actions[index];
        // To make the action not played yet
        if(!action.hasPlayed)
        {
            action.hasPlayed = true;

            director.Stop();
            director.time = action.time;
            director.Play();
        }
    }
}
