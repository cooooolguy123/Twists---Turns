using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AssemblyCSharp;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tds_GameManager : MonoBehaviour {
	private bool PlayerIsDead = false;
	public Image vHpImage;
	public void RefreshPlayerHP(float vPerc)
	{
		//show different color for HP value for player
		if (vPerc >= 0.7f)
			vHpImage.color = Color.green;
		else if (vPerc >= 0.3f)
			vHpImage.color = Color.yellow;
		else
			vHpImage.color = Color.red;

		//update HP
		vHpImage.fillAmount = vPerc;
	}

	public void SetPlayerDead()
	{
		IsReady = false;
		//remove main camera from player to prevent it from being destroyed when dying.
		Camera.main.transform.parent = null;
		vGameOverObj.SetActive (true);

		//player losing music
		PlaySound("Losing");
		PlayerIsDead = true;
	}
