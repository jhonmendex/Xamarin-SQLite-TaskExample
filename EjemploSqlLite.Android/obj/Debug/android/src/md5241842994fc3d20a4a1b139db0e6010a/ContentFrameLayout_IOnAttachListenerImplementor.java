package md5241842994fc3d20a4a1b139db0e6010a;


public class ContentFrameLayout_IOnAttachListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		md5241842994fc3d20a4a1b139db0e6010a.ContentFrameLayout_IOnAttachListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAttachedFromWindow:()V:GetOnAttachedFromWindowHandler:Android.Support.V7.Widget.ContentFrameLayout/IOnAttachListenerInvoker, Xamarin.Android.Support.v7.AppCompat\n" +
			"n_onDetachedFromWindow:()V:GetOnDetachedFromWindowHandler:Android.Support.V7.Widget.ContentFrameLayout/IOnAttachListenerInvoker, Xamarin.Android.Support.v7.AppCompat\n" +
			"";
		mono.android.Runtime.register ("Android.Support.V7.Widget.ContentFrameLayout+IOnAttachListenerImplementor, Xamarin.Android.Support.v7.AppCompat", ContentFrameLayout_IOnAttachListenerImplementor.class, __md_methods);
	}


	public ContentFrameLayout_IOnAttachListenerImplementor ()
	{
		super ();
		if (getClass () == ContentFrameLayout_IOnAttachListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.V7.Widget.ContentFrameLayout+IOnAttachListenerImplementor, Xamarin.Android.Support.v7.AppCompat", "", this, new java.lang.Object[] {  });
	}


	public void onAttachedFromWindow ()
	{
		n_onAttachedFromWindow ();
	}

	private native void n_onAttachedFromWindow ();


	public void onDetachedFromWindow ()
	{
		n_onDetachedFromWindow ();
	}

	private native void n_onDetachedFromWindow ();

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
