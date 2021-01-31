public static class AdUtils 
{
    public  static string publisherAddress = "MeruemGames";// publisher_id
    public static string pluginName = "com.grailads.unitygrailadsplugin.PrintUtils";
    public  static string publisherAppID = "MeruemGames_1"; //app_id  

    public  static string env= "TEST"; 
    public  static GrailAdsRewarded grailAdsRewarded;

    public static void RequestAndLoadRewarded() {
        rewarded_loaded = false;
        grailAdsRewarded = new GrailAdsRewarded(publisherAddress , publisherAppID , env);
        javaclass = new AndroidJavaObject(pluginName);
        javaclass.Call("LogUnityInfo", "**************************************created interstitial ");
        grailAdsRewarded.OnAdLoaded += HandleRewardedOnAdLoaded;
        grailAdsRewarded.OnAdClicked += HandleRewardedOnAdClicked;
        grailAdsRewarded.OnFailure += HandleRewardedOnFailure;
        grailAdsRewarded.OnAdClosed += HandleRewardedOnAdClosed;
        grailAdsRewarded.OnAdOpened += HandleRewardedOnAdOpened;
        grailAdsRewarded.OnPaidListener += HandleRewardedOnPaid;
        grailAdsRewarded.OnAdRewarded += HandleRewardedOnRewarded;

        grailAdsRewarded.LoadAd();
    }

    public static void  HandleRewardedOnAdLoaded(object sender, EventArgs args)
    {
        javaclass.Call("LogUnityInfo", "loaded in game code");
        rewarded_loaded = true;
    }

    public static void  HandleRewardedOnAdClicked(object sender, EventArgs args)
    {
        javaclass.Call("LogUnityInfo", "clicked in game code");
    }

    public static void  HandleRewardedOnFailure(object sender, EventArgs args)
    {
        rewarded_loaded = false;
        javaclass.Call("LogUnityInfo", "failed in game code");
    }

    public static void  HandleRewardedOnAdClosed(object sender, EventArgs args)
    {
        javaclass.Call("LogUnityInfo", "closed in game code");
    }

    public static void  HandleRewardedOnAdOpened(object sender, EventArgs args)
    {
        javaclass.Call("LogUnityInfo", "ad opened in game code");
    }

    public static void  HandleRewardedOnPaid(object sender, EventArgs args)
    {
        javaclass.Call("LogUnityInfo", "paid.. in game code");
    }

    public static void  HandleRewardedOnRewarded(object sender, EventArgs args)
    {
        javaclass.Call("LogUnityInfo", "rewarded.. in game code");
    }

    public static void ShowRewarded(){
        if (grailAdsRewarded.IsLoaded()){
            grailAdsRewarded.Show();
        }
        else{
            Debug.Log("Ad Not Loaded");
            javaclass.Call("LogUnityInfo", "not loaded");
        }
    }
}
