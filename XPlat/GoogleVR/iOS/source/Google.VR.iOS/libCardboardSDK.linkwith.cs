using ObjCRuntime;

[assembly: LinkWith ("libCardboardSDK.a", LinkTarget.ArmV7|LinkTarget.ArmV6|LinkTarget.Arm64|LinkTarget.Simulator|LinkTarget.Simulator64,LinkerFlags="-ObjC -lc++", Frameworks="AVFoundation AudioToolbox CoreGraphics CoreMedia CoreMotion CoreText CoreVideo Security GLKit MediaPlayer OpenGLES QuartzCore", SmartLink = true, ForceLoad = false, IsCxx = true)]
