﻿/*
 * class PackConfig -- Store the information of chart collection of a single song.
 *
 *      This class includes the speed, level, beats and notes property.
 *      songName: string, song name.
 *      composer: string, the composer of this song.
 *      charts: List<GameChart>, charts in the project
 *
 * Function
 *
 *
 * History
 *      2021.03.31  CREATE.
 */

using System.Collections.Generic;

namespace Assets.Scripts.Game.Plutono
{
    [System.Serializable]
    public class PackInfo
    {
        public string songName = "";
        public string composer = "";
        public List<GameChart> charts = new List<GameChart>();
    }
}
