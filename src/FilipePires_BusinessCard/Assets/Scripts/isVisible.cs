
/**
* Script belonging to the project: FilipePires_BusinessCard
* Author: Filipe Pires
* Date: 25/10/2019
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Checks if Virtual Layer is visible and, once it is, triggers all animations */
public class isVisible : MonoBehaviour {

    /* Variables */

    // trigger:
    bool triggered = false;
    // icons:
    public GameObject linkedInIcon;
    public GameObject instagramIcon;
    public GameObject gitHubIcon;
    public GameObject phoneIcon;
    public GameObject emailIcon;
    public GameObject vimeoIcon; // extra
    // text:
    public GameObject textInfo;
    // video:
    public GameObject videoIntro;

    /* Methods */

    // Used to initialize variables
    void Start() {
        linkedInIcon = GameObject.Find("LinkedInIcon");
        instagramIcon = GameObject.Find("InstagramIcon");
        gitHubIcon = GameObject.Find("GitHubIcon");
        phoneIcon = GameObject.Find("PhoneIcon");
        emailIcon = GameObject.Find("EmailIcon");
        vimeoIcon = GameObject.Find("VimeoIcon");
        textInfo = GameObject.Find("TextInfo"); textInfo.SetActive(false);
        //videoIntro = GameObject.Find("");
    }

    // Detects Virtual Elements and triggers animations and video
    void Update() {
        if(GetComponent<Renderer>().isVisible && triggered == false) {
            print ("Found!"); // for debug
            triggered = true;

            // icon animations
            linkedInIcon.GetComponent<Animator>().Play("LinkedIn_IconAnimation");
            instagramIcon.GetComponent<Animator>().Play("Instagram_IconAnimation");
            gitHubIcon.GetComponent<Animator>().Play("GitHub_IconAnimation");
            phoneIcon.GetComponent<Animator>().Play("Phone_IconAnimation");
            emailIcon.GetComponent<Animator>().Play("Email_IconAnimation");
            vimeoIcon.GetComponent<Animator>().Play("Vimeo_IconAnimation");

            // text animation
            textInfo.SetActive(true);
            textInfo.GetComponent<Animator>().Play("TextInfo_ZoomIn");

            // video play
            //videoIntro.GetComponent<Animator>().Play("");
        }
    }
}
