using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Hue/Game/Note Path")]
public class NotePath : MonoBehaviour
{
    public KeyCode key;
    public Image path;
    public Text keyText;

    public Sprite active;
    public Sprite unactive;

    // Update is called once per frame
    void Update()
    {
        keyText.text = key.ToString().ToLower();

        if (Input.GetKey(key))
        {
            path.sprite = active;
        }
        else if (Input.GetKeyUp(key))
        {
            path.sprite = unactive;
        }
    }
}
