﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FaceSwapperExample
{
    /// <summary>
    /// Show License
    /// </summary>
    public class ShowLicense : MonoBehaviour
    {
        // Use this for initialization
        void Start ()
        {

        }

        // Update is called once per frame
        void Update ()
        {

        }

        public void OnBackButtonClick ()
        {
            SceneManager.LoadScene ("FaceSwapperExample");
        }
    }
}
