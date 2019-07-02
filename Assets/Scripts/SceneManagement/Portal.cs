using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RPG.SceneManagement
{
    public class Portal : MonoBehaviour
    {
        [SerializeField] int sceneIndex = -1;

        private void OnTriggerEnter(Collider other) {
            if (other.tag == "Player") 
            {
                StartCoroutine(Transition());
            }           
        }

        private IEnumerator Transition()
        {
            DontDestroyOnLoad(gameObject);  //gameObject must be at root
            yield return SceneManager.LoadSceneAsync(sceneIndex);
            print("Scene Loaded");
            Destroy(gameObject);
        }
    }
}