public static class AdUtils 
{
    public  static string publisherAddress = "";// publisher_id
    public  static string publisherAppID = ""; //app_id  

    public  static string env= "TEST"; 
    public  static GrailAdsRewarded grailAdsRewarded;

    public static void RequestAndLoadRewarded() {
        grailAdsRewarded = new GrailAdsRewarded(publisherAddress , publisherAppID , env);
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
    }

    public static void  HandleRewardedOnAdClicked(object sender, EventArgs args)
    {
    }

    public static void  HandleRewardedOnFailure(object sender, EventArgs args)
    {
    }

    public static void  HandleRewardedOnAdClosed(object sender, EventArgs args)
    {
    }

    public static void  HandleRewardedOnAdOpened(object sender, EventArgs args)
    {
    }

    public static void  HandleRewardedOnPaid(object sender, EventArgs args)
    {
    }

    public static void  HandleRewardedOnRewarded(object sender, EventArgs args)
    {
    }

    public static void ShowRewarded(){
        if (grailAdsRewarded.IsLoaded()){
            grailAdsRewarded.Show();
        }
        else{
            Debug.Log("Ad Not Loaded");
        }
    }
}
