using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAndFinish : MonoBehaviour
{
    [SerializeField] LevelTimer targetObject;

    private void OnTriggerExit(Collider other)
    {
        if (this.gameObject.CompareTag("Start") && other.gameObject.CompareTag("Player"))
            this.targetObject.SendMessage("StartTimer");
    }

    private void OnTriggerStay(Collider other)
    {
        if (this.gameObject.CompareTag("End") && other.gameObject.CompareTag("Player"))
            this.StartCoroutine(this.FinishGame());
    }

    private IEnumerator FinishGame()
    {
        yield return new WaitForSeconds(0.2f);

        this.targetObject.SendMessage("StopTimer");
    }
}
