﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class UpdateAchivePoints : MonoBehaviour
    {
        [SerializeField]
        private PlayerScore currentScore;
        [SerializeField]
        private PlayerScore maxScore;

        public void UpdatePoints()
        {
            if (currentScore.score > maxScore.score) 
            {
                maxScore.score = currentScore.score;
            }
        }
    }
}