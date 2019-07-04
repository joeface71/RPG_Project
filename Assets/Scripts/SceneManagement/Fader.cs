using System.Collections;
using UnityEngine;

namespace RPG.SceneManagement
{
    public class Fader : MonoBehaviour
    {
        CanvasGroup canvasGroup;

        private void Start() {
            canvasGroup = GetComponent<CanvasGroup>();            
        }

        public IEnumerator FadeOut(float time)
        {
            while (canvasGroup.alpha < 1) 
            {
                canvasGroup.alpha += Time.deltaTime / time; // increment alpha per frame
                yield return null; // resumes on next update
            }
            
        }

        public IEnumerator FadeIn(float time)
        {
            while (canvasGroup.alpha > 0) 
            {
                canvasGroup.alpha -= Time.deltaTime / time; // increment alpha per frame
                yield return null; // resumes on next update
            }
            
        }
    }
}