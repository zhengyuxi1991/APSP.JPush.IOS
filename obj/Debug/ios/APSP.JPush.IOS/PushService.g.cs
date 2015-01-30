//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using MonoTouch.UIKit;
using MonoTouch.GLKit;
using MonoTouch.MapKit;
using MonoTouch.Security;
using MonoTouch.SceneKit;
using MonoTouch.CoreVideo;
using MonoTouch.CoreMedia;
using MonoTouch.QuickLook;
using MonoTouch.Foundation;
using MonoTouch.CoreMotion;
using MonoTouch.ObjCRuntime;
using MonoTouch.AddressBook;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreLocation;
using MonoTouch.NewsstandKit;
using MonoTouch.AVFoundation;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreFoundation;

namespace APSP.JPush.IOS {
	[Register("PushService", true)]
	public unsafe partial class PushService : NSObject {
		[CompilerGenerated]
		const string selHandleRemoteNotification_ = "handleRemoteNotification:";
		static readonly IntPtr selHandleRemoteNotification_Handle = Selector.GetHandle ("handleRemoteNotification:");
		[CompilerGenerated]
		const string selOpenUDID = "openUDID";
		static readonly IntPtr selOpenUDIDHandle = Selector.GetHandle ("openUDID");
		[CompilerGenerated]
		const string selRegisterDeviceToken_ = "registerDeviceToken:";
		static readonly IntPtr selRegisterDeviceToken_Handle = Selector.GetHandle ("registerDeviceToken:");
		[CompilerGenerated]
		const string selRegisterForRemoteNotificationTypesCategories_ = "registerForRemoteNotificationTypes:categories:";
		static readonly IntPtr selRegisterForRemoteNotificationTypesCategories_Handle = Selector.GetHandle ("registerForRemoteNotificationTypes:categories:");
		[CompilerGenerated]
		const string selRegistrationID = "registrationID";
		static readonly IntPtr selRegistrationIDHandle = Selector.GetHandle ("registrationID");
		[CompilerGenerated]
		const string selSetupWithOption_ = "setupWithOption:";
		static readonly IntPtr selSetupWithOption_Handle = Selector.GetHandle ("setupWithOption:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PushService");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PushService () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::MonoTouch.ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::MonoTouch.ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PushService (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PushService (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PushService (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("handleRemoteNotification:")]
		[CompilerGenerated]
		public static void HandleRemoteNotification (NSDictionary remoteInfo)
		{
			if (remoteInfo == null)
				throw new ArgumentNullException ("remoteInfo");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, selHandleRemoteNotification_Handle, remoteInfo.Handle);
		}
		
		[Export ("openUDID")]
		[CompilerGenerated]
		public static string OpenUDID ()
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, selOpenUDIDHandle));
		}
		
		[Export ("registerDeviceToken:")]
		[CompilerGenerated]
		public static void RegisterDeviceToken (NSData deviceToken)
		{
			if (deviceToken == null)
				throw new ArgumentNullException ("deviceToken");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, selRegisterDeviceToken_Handle, deviceToken.Handle);
		}
		
		[Export ("registerForRemoteNotificationTypes:categories:")]
		[CompilerGenerated]
		public static void RegisterForRemoteNotificationTypes (int types, NSSet categories)
		{
			ApiDefinition.Messaging.void_objc_msgSend_int_IntPtr (class_ptr, selRegisterForRemoteNotificationTypesCategories_Handle, types, categories == null ? IntPtr.Zero : categories.Handle);
		}
		
		[Export ("registrationID")]
		[CompilerGenerated]
		public static string RegistrationID ()
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, selRegistrationIDHandle));
		}
		
		[Export ("setupWithOption:")]
		[CompilerGenerated]
		public static void SetupWithOption (NSDictionary launchingOption)
		{
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetupWithOption_Handle, launchingOption == null ? IntPtr.Zero : launchingOption.Handle);
		}
		
	} /* class PushService */
}
