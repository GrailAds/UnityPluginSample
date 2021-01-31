public static class AdUtils 
{
    public  static string publisherAddress = "MeruemGames";// publisher_id
    public  static string publisherAppID = "MeruemGames_1"; //app_id  

    public  static string env= "TEST"; 
    public  static GrailAdsBanner grailAdsBanner;
    private static GrailAdsPlugin.Api.AdSize adSize;


    public static void LoadBanner(){
        banner_loaded = false;
        adSize = new GrailAdsPlugin.Api.AdSize(-1f  , 200f ) ; 
        grailAdsBanner = new GrailAdsBanner(publisherAddress , 
                                            publisherAppID , 
                                            env, adSize , GrailAdsPlugin.Api.AdPosition.Bottom);
       

        grailAdsBanner.OnAdLoaded += HandleBannerOnAdLoaded;
        grailAdsBanner.OnAdClicked += HandleBannerOnAdClicked;
        grailAdsBanner.OnFailure += HandleBannerOnFailure;
        grailAdsBanner.OnAdClosed += HandleBannerOnAdClosed;
        grailAdsBanner.OnAdOpened += HandleBannerOnAdOpened;
        grailAdsBanner.OnPaidListener += HandleBannerOnPaid;
        grailAdsBanner.LoadAd();
    }

    public static void  HandleBannerOnAdLoaded(object sender, EventArgs args)
    {
       
    }

    public static void  HandleBannerOnAdClicked(object sender, EventArgs args)
    {
        
    }

    public static void  HandleBannerOnFailure(object sender, EventArgs args)
    {
        
    }

    public static void  HandleBannerOnAdClosed(object sender, EventArgs args)
    {
        
    }

    public static void  HandleBannerOnAdOpened(object sender, EventArgs args)
    {
        
    }

    public static void  HandleBannerOnPaid(object sender, EventArgs args)
    {
    
    }

    public static void  HandleOnRewarded(object sender, EventArgs args)
    {
       
    }

    public static void ShowBanner(){
        if (grailAdsBanner.IsLoaded()){
            grailAdsBanner.Show();
        }
        else{
            Debug.Log("Ad Not Loaded");
        }
    }
    
    public static void Destroy_Banner(){
        grailAdsBanner.Destroy();
    }

}
