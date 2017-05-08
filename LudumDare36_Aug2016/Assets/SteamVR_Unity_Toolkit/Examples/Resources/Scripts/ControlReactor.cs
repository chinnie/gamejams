using UnityEngine;
using System.Collections;
using VRTK;

public class ControlReactor : MonoBehaviour
{
    public TextMesh go;
    public GameObject spawner;
    public GameObject ToCopy;
    public AudioClip ballSound;

    private AudioSource source;
    private bool ballFlag = false;
 
   private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    private void Start()
    {
        GetComponent<VRTK_Control>().defaultEvents.OnValueChanged.AddListener(HandleChange);
        HandleChange(GetComponent<VRTK_Control>().GetValue(), GetComponent<VRTK_Control>().GetNormalizedValue());
    }

    private void HandleChange(float value, float normalizedValue)
    {
        go.text = value.ToString() + "(" + normalizedValue.ToString() + "%)";

        if ((normalizedValue == 100) && (ballFlag == false))
        {
            GameObject newGo = GameObject.Instantiate(ToCopy);
            newGo.transform.position = spawner.transform.position + new Vector3(0, 1, 0);
           source.PlayOneShot(ballSound, 1.0f);
            ballFlag = true;

            GameObject tempcat = GameObject.Find("KittenNPC");

            catMoveTo otherScript = tempcat.GetComponent<catMoveTo>();
            otherScript.goal = newGo.transform;
        }
        else if ((normalizedValue == 0) && (ballFlag == true)) {
            ballFlag = false;
            }
    }
}