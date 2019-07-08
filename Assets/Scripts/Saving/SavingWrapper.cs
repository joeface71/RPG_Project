using System.Collections;
using RPG.SceneManagement;
using UnityEngine;

namespace RPG.Saving
{
    public class SavingWrapper : MonoBehaviour
    {
        const string defaultSaveFile = "save";

        private IEnumerator Start() {
            Fader fader = FindObjectOfType<Fader>();
            fader.FadeOutImmediatley();
           yield return GetComponent<SavingSystem>().LoadLastScene(defaultSaveFile);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                Save();
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                Load();
            }
        }

        public void Load()
        {
            GetComponent<SavingSystem>().Load(defaultSaveFile);
        }

        public void Save()
        {
            GetComponent<SavingSystem>().Save(defaultSaveFile);
        }
    }
}