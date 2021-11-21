using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hue.Game
{
    [System.Serializable]
    public class Rest
    {
        public float Time;
        public int Duration;

        public Rest(float time, int length)
        {
            Time = time;
            Duration = length;
        }
    }
}
