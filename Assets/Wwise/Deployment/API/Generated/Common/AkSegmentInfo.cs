#if ! (UNITY_DASHBOARD_WIDGET || UNITY_STANDALONE_LINUX || UNITY_WEBPLAYER || UNITY_WII || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY || UNITY_WP8) // Disable under unsupported platforms.
/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class AkSegmentInfo : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AkSegmentInfo(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(AkSegmentInfo obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~AkSegmentInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkSegmentInfo(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public int iCurrentPosition {
    set {
      AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iCurrentPosition_set(swigCPtr, value);

    } 
    get {
      int ret = AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iCurrentPosition_get(swigCPtr);

      return ret;
    } 
  }

  public int iPreEntryDuration {
    set {
      AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iPreEntryDuration_set(swigCPtr, value);

    } 
    get {
      int ret = AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iPreEntryDuration_get(swigCPtr);

      return ret;
    } 
  }

  public int iActiveDuration {
    set {
      AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iActiveDuration_set(swigCPtr, value);

    } 
    get {
      int ret = AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iActiveDuration_get(swigCPtr);

      return ret;
    } 
  }

  public int iPostExitDuration {
    set {
      AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iPostExitDuration_set(swigCPtr, value);

    } 
    get {
      int ret = AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iPostExitDuration_get(swigCPtr);

      return ret;
    } 
  }

  public int iRemainingLookAheadTime {
    set {
      AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iRemainingLookAheadTime_set(swigCPtr, value);

    } 
    get {
      int ret = AkSoundEnginePINVOKE.CSharp_AkSegmentInfo_iRemainingLookAheadTime_get(swigCPtr);

      return ret;
    } 
  }

  public AkSegmentInfo() : this(AkSoundEnginePINVOKE.CSharp_new_AkSegmentInfo(), true) {

  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_STANDALONE_LINUX || UNITY_WEBPLAYER || UNITY_WII || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY || UNITY_WP8) // Disable under unsupported platforms.
