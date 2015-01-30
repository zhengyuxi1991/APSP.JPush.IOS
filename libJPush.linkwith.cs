using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libJPush.a", LinkTarget.ArmV7, SmartLink = true, ForceLoad = true, Frameworks = "CFNetwork CoreFoundation CoreTelephony SystemConfiguration CoreGraphics Foundation UIKit")]
