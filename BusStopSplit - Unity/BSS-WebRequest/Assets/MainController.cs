using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class MainController : MonoBehaviour
{

    public InputField LatitudeInput;
    public InputField LongitudeInput;

    public InputField AddressInput;

    public InputField BusNumberInput;

    public float SendInterval = 3f;
    public bool ShouldSend = false;
    
    private float TimeSinceLastSend = 0f;

    private void Start()
    {
        Debug.Log("start");

        StartLocationService();

        if (LatitudeInput)
        {
            LatitudeInput.text = "43.520905";
        }
        if (LongitudeInput)
        {
            LongitudeInput.text = "16.448473";
        }
        if (AddressInput)
        {
            AddressInput.text = "http://busstop.amber-it.co";
        }
        if (BusNumberInput)
        {
            BusNumberInput.text = "18";
        }
    }

    private void Update()
    {
        TimeSinceLastSend += Time.deltaTime;

        if (ShouldSend && TimeSinceLastSend >= SendInterval)
        {
            SendCoordinates();
            TimeSinceLastSend = 0;
        }
    }

    private void StartLocationService()
    {
        print("starting location service...");

        Input.location.Start();
    }

    public void SendCoordinates()
    {
        var busId = 18;

        var address = "http://busstop.amber-it.co";
        var lat = 43.520905;
        var lng = 16.448473;

        if (LatitudeInput && LongitudeInput)
        {
            lat = float.Parse(LatitudeInput.text);
            lng = float.Parse(LongitudeInput.text);

        }

        if (Input.location.status == LocationServiceStatus.Running)
        {
            Debug.Log("Location running! Taking device location data...");
            lat = Input.location.lastData.latitude;
            lng = Input.location.lastData.longitude;
        }

        if (AddressInput)
        {
            address = AddressInput.text;
        }

        if (BusNumberInput)
        {
            busId = int.Parse(BusNumberInput.text);
        }

        StartCoroutine(GetRequest($"{address}/api/coordinates/updateForBus?busId={busId}&lat={lat}&lng={lng}"));
    }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
            }
            else
            {
                Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
            }
        }
    }

    public void StartSendingCoords() 
    {
        this.ShouldSend = true;
    }

    public void StopSendingCoords()
    {
        this.ShouldSend = false;
    }
}
