using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailTypeEffect : MonoBehaviour
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
        Invoke("increaseCharacterInterval", 0.3f);
        Invoke("DecreaseCharacterInterval", 3.4f);
        
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
        m_characterInterval += 0.03f;
    }
    private void DecreaseCharacterInterval()
    {
        m_characterInterval -= 0.01f;
    }
}
