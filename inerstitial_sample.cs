public static class AdUtils 
{
    public  static string publisherAddress = "MeruemGames";// publisher_id
    public static string pluginName = "com.grailads.unitygrailadsplugin.PrintUtils";
    public  static string publisherAppID = "MeruemGames_1"; //app_id  
    
    public  static string env= "TEST"; 
    // Start is called before the first frame update
    public  static GrailAdsInterstitial grailAdsInterstitial;

    
    public static void RequestAndLoadInterstitial() {
        interstitial_loaded = false;
        grailAdsInterstitial = new GrailAdsInterstitial(publisherAddress , publisherAppID , env);
        
        grailAdsInterstitial.OnAdLoaded += HandleInterstitialOnAdLoaded;
        grailAdsInterstitial.OnAdClicked += HandleInterstitialOnAdClicked;
        grailAdsInterstitial.OnFailure += HandleInterstitialOnFailure;
        grailAdsInterstitial.OnAdClosed += HandleInterstitialOnAdClosed;
        grailAdsInterstitial.OnAdOpened += HandleInterstitialOnAdOpened;
        grailAdsInterstitial.OnPaidListener += HandleInterstitialOnPaid;
        grailAdsInterstitial.LoadAd();
    }

    public static void  HandleInterstitialOnAdLoaded(object sender, EventArgs args)
    {
        
    }

    public static void  HandleInterstitialOnAdClicked(object sender, EventArgs args)
    {
        
    }

    public static void  HandleInterstitialOnFailure(object sender, EventArgs args)
    {
        
    }

    public static void  HandleInterstitialOnAdClosed(object sender, EventArgs args)
    {
        
    }

    public static void  HandleInterstitialOnAdOpened(object sender, EventArgs args)
    {
        
    }

    public static void  HandleInterstitialOnPaid(object sender, EventArgs args)
    {
        
    }

    public static void  HandleInterstitialOnRewarded(object sender, EventArgs args)
    {
        
    }

    public static void ShowInterstitial(){
        if (grailAdsInterstitial.IsLoaded()){
            grailAdsInterstitial.Show();
        }
        else{
            Debug.Log("Ad Not Loaded");
        }
    }
}
