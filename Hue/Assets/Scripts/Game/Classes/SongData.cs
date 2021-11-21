using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace Hue.Game
{

    [System.Serializable]
    public class SongData
    {
        public string Name;
        public string Artist;
        public string Difficulty;

        public Note[] Notes;
        public Rest[] Rests;

        public string BGPath;
        public string MusicPath;
        public bool IsVideo;
        public bool HasFlashWarning;

        public int BPM;
        public string Id;

        public SongData(string songName, string songArtist, string difficulty, string bgFile, string msFile)
        {
            Name = songName;
            Artist = songArtist;
            Difficulty = difficulty;
            MusicPath = msFile;
            BGPath = bgFile;

            string bgExtension = Path.GetExtension(BGPath);

            if (bgExtension == ".mp4" || bgExtension == ".mov" || bgExtension == ".3gp") IsVideo = true;
        }
    }
}