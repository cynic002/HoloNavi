using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class DestinationPlacement : MonoBehaviour, IInputClickHandler
{
    void Start()
    {
        InputManager.Instance.PushFallbackInputHandler(gameObject);
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (GazeManager.Instance.IsGazingAtObject)
        {
            var hitInfo = GazeManager.Instance.HitInfo;
            transform.position = hitInfo.point + transform.localScale.y * Vector3.up;
            print(transform.position);
        }
    }
}