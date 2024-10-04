using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControls : MonoBehaviour
{
    public GameObject player;

    public float[] positions = { -1.8f, 0, 1.8f };
    int CurrentPosition = 1;
    float _Position = 0;

    public void RightClick()
    {
        CurrentPosition++;
        CurrentPosition = Mathf.Clamp(CurrentPosition, 0, 2);
        _Position = positions[CurrentPosition];
        player.transform.position = new Vector3(_Position, player.transform.position.y, player.transform.position.z);
    }

    public void LeftClick()
    {
        CurrentPosition--;
        CurrentPosition = Mathf.Clamp(CurrentPosition, 0, 2);
        _Position = positions[CurrentPosition];
        player.transform.position = new Vector3(_Position, player.transform.position.y, player.transform.position.z);
    }
}
