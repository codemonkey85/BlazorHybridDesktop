package crc64bbaf1c4776282b7a;


public class WebKitWebChromeClient
	extends android.webkit.WebChromeClient
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onShowFileChooser:(Landroid/webkit/WebView;Landroid/webkit/ValueCallback;Landroid/webkit/WebChromeClient$FileChooserParams;)Z:GetOnShowFileChooser_Landroid_webkit_WebView_Landroid_webkit_ValueCallback_Landroid_webkit_WebChromeClient_FileChooserParams_Handler\n" +
			"";
		mono.android.Runtime.register ("Microsoft.MobileBlazorBindings.WebView.Android.WebKitWebChromeClient, Microsoft.MobileBlazorBindings.WebView.Android", WebKitWebChromeClient.class, __md_methods);
	}


	public WebKitWebChromeClient ()
	{
		super ();
		if (getClass () == WebKitWebChromeClient.class)
			mono.android.TypeManager.Activate ("Microsoft.MobileBlazorBindings.WebView.Android.WebKitWebChromeClient, Microsoft.MobileBlazorBindings.WebView.Android", "", this, new java.lang.Object[] {  });
	}


	public boolean onShowFileChooser (android.webkit.WebView p0, android.webkit.ValueCallback p1, android.webkit.WebChromeClient.FileChooserParams p2)
	{
		return n_onShowFileChooser (p0, p1, p2);
	}

	private native boolean n_onShowFileChooser (android.webkit.WebView p0, android.webkit.ValueCallback p1, android.webkit.WebChromeClient.FileChooserParams p2);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
