using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogue : MonoBehaviour
{
    public TextMeshProUGUI textcomponent;
    [SerializeField] GameObject panel;
    public string[] lines;
    public float textspeed;

    private int index;
    // Start is called before the first frame update
    void Start()
    {

        textcomponent.text = string.Empty;
        panel.SetActive(false); //Hides dialouge UI
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (textcomponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textcomponent.text = lines[index];
            }
        }
    }
    

        public void StartDialogue()
        {
            panel.SetActive(true); //Shows Gameobj
            index = 0;
            StartCoroutine(TypeLine());
        }
    
    

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
                textcomponent.text += c;
                yield return new WaitForSeconds(textspeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textcomponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            panel.SetActive(false);
        }
    }
}
