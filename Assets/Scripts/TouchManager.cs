using System;
using System.Collections;
using System.Collections.Generic;
using TouchScript.Gestures;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    public FlickGesture flickGesture;

    private void OnEnable()
    {
        flickGesture.Flicked += OnFlicked;
    }

    private void OnDisable()
    {
        flickGesture.Flicked -= OnFlicked;
    }

    private void OnFlicked( object sender, EventArgs e )
    {
        Debug.Log( "ƒtƒŠƒbƒN‚³‚ê‚½: " + flickGesture.ScreenFlickVector );
    }
}
