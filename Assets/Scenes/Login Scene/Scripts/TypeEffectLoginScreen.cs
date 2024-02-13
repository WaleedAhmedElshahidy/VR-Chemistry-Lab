using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeEffectLoginScreen : MonoBehaviour
{
   [TextArea]
    public string m_text;
    public float m_characterInterval;

    private string m_partialText;
    private float m_cumulativeDeltaTime;

    public Text m_label;


//      private void Awake()
  //  {
    //   m_label = GetComponents<Text>();
    //}
    // Start is called before the first frame update
    void Start()
    {
        Invoke("increaseCharacterInterval", 1);
        Invoke("decreaseCharacterInterval2", 2);
        Invoke("increaseCharacterInterval", 7);
        Invoke("decreaseCharacterInterval1", 10);
        Invoke("increaseCharacterInterval",16);
        Invoke("decreaseCharacterInterval2", 16.3f);
        Invoke("decreaseCharacterInterval2", 17);
        m_label.text = m_text;
        m_partialText = "";
        m_cumulativeDeltaTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        m_cumulativeDeltaTime += Time.deltaTime;
        while(m_cumulativeDeltaTime >= m_characterInterval && m_partialText.Length < m_text.Length)
        {
            m_partialText += m_text[m_partialText.Length];
            m_cumulativeDeltaTime -= m_characterInterval;
        }
        m_label.text = m_partialText;
    }
    private void increaseCharacterInterval()
    {
        m_characterInterval += 0.04f;
    }
    private void decreaseCharacterInterval1()
    {
        m_characterInterval -= 0.01f;
    }
    private void decreaseCharacterInterval2()
    {
        m_characterInterval -= 0.04f;
    }
}
