using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using System;

using Vuforia;



public class ARManager : MonoBehaviour

{

    public PlaneFinderBehaviour finder;




    ContentPositioningBehaviour contentPositioningBehaviour;

    AnchorBehaviour planeAnchor, midAirAnchor, placementAnchor;

    StateManager stateManager;

    float touchesPrePosDifference, touchesCurPosDifference, zoomModifier;

    Vector2 Test, firstTouchPrevPos, secondTouchPrevPos;

    public GameObject obj; // The 3d model that we want to show on the position

    public bool ShowModelState = false;

    public bool CanSupport = false;

    private string consoleString; // Current value of message in console



    public void LaunchModel()

    {

        finder.PerformHitTest(Test);

        ShowModel();

    }

    public void ShowModel()

    {

        obj.SetActive(true);

        ShowModelState = true;

    }

    public void HideModel()

    {

        obj.SetActive(false);

        ShowModelState = false;

    }



    public void ResetTrackers()

    {

        VuforiaBehaviour.Instance.DevicePoseBehaviour.Reset();

    }



    private void OnEnable()

    {

        Application.logMessageReceived += HandleLog;

    }



    private void OnDisable()

    {

        Application.logMessageReceived -= HandleLog;

    }



    void HandleLog(string message, string stacktrace, LogType type)

    {

        consoleString = consoleString + "\n" + message;

        if (VuforiaBehaviour.Instance.World.AnchorsSupported == false)

        {

            Debug.Log("GroundPlane not supported on this device.");

        }

        else

        {

            CanSupport = true;

            print("Yes, This device can support the surface tracking");

        }

    }



}