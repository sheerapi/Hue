using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hue.Game
{
    [System.Serializable]
    public class Note
    {
        public float Time;
        public float Length;

        public Note(float time, float length)
        {
            Time = time;
            Length = length;
        }
    }
}