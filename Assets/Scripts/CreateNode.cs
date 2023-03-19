using UnityEngine;

using UnityEngine.Events;

public class CreateNode : MonoBehaviour
{
  UnityEvent m_MyEvent;
      public GameObject myPrefab;
      public GameObject canvas;
      void Start()
      {
        if (m_MyEvent == null)
            m_MyEvent = new UnityEvent();

        // m_MyEvent.AddListener();
    }

      void Update()
      {
        //   if (Input.anyKeyDown && m_MyEvent != null)
        //  {
        //     createNewPrefab();
        //  }
     }

      public void createNewPrefab(){
       Debug.Log("[CREATE NODE]: creating new Prefab");
      Instantiate(myPrefab, new Vector3((float)0.151,(float) 1.104, (float)-0.984), Quaternion.identity);
     }
     public void toggleCanvas(){
       Debug.Log("[CREATE NODE]: Showing Canvas");
       canvas.SetActive(!canvas.activeSelf);
     }

     public void SelectedInput(){
       Debug.Log("[CREATE NODE]: Seleted Input");
       
     }
}