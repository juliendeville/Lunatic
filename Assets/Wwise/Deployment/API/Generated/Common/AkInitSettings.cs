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

public class AkInitSettings : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AkInitSettings(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(AkInitSettings obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~AkInitSettings() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkInitSettings(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public int pfnAssertHook { set { } get { return 0; }
  }

  public uint uMaxNumPaths {
    set {
      AkSoundEnginePINVOKE.CSharp_AkInitSettings_uMaxNumPaths_set(swigCPtr, value);

    } 
    get {
      uint ret = AkSoundEnginePINVOKE.CSharp_AkInitSettings_uMaxNumPaths_get(swigCPtr);

      return ret;
    } 
  }

  public uint uMaxNumTransitions {
    set {
      AkSoundEnginePINVOKE.CSharp_AkInitSettings_uMaxNumTransitions_set(swigCPtr, value);

    } 
    get {
      uint ret = AkSoundEnginePINVOKE.CSharp_AkInitSettings_uMaxNumTransitions_get(swigCPtr);

      return ret;
    } 
  }

  public uint uDefaultPoolSize {
    set {
      AkSoundEnginePINVOKE.CSharp_AkInitSettings_uDefaultPoolSize_set(swigCPtr, value);

    } 
    get {
      uint ret = AkSoundEnginePINVOKE.CSharp_AkInitSettings_uDefaultPoolSize_get(swigCPtr);

      return ret;
    } 
  }

  public float fDefaultPoolRatioThreshold {
    set {
      AkSoundEnginePINVOKE.CSharp_AkInitSettings_fDefaultPoolRatioThreshold_set(swigCPtr, value);

    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkInitSettings_fDefaultPoolRatioThreshold_get(swigCPtr);

      return ret;
    } 
  }

  public uint uCommandQueueSize {
    set {
      AkSoundEnginePINVOKE.CSharp_AkInitSettings_uCommandQueueSize_set(swigCPtr, value);

    } 
    get {
      uint ret = AkSoundEnginePINVOKE.CSharp_AkInitSettings_uCommandQueueSize_get(swigCPtr);

      return ret;
    } 
  }

  public int uPrepareEventMemoryPoolID {
    set {
      AkSoundEnginePINVOKE.CSharp_AkInitSettings_uPrepareEventMemoryPoolID_set(swigCPtr, value);

    } 
    get {
      int ret = AkSoundEnginePINVOKE.CSharp_AkInitSettings_uPrepareEventMemoryPoolID_get(swigCPtr);

      return ret;
    } 
  }

  public bool bEnableGameSyncPreparation {
    set {
      AkSoundEnginePINVOKE.CSharp_AkInitSettings_bEnableGameSyncPreparation_set(swigCPtr, value);

    } 
    get {
      bool ret = AkSoundEnginePINVOKE.CSharp_AkInitSettings_bEnableGameSyncPreparation_get(swigCPtr);

      return ret;
    } 
  }

  public uint uContinuousPlaybackLookAhead {
    set {
      AkSoundEnginePINVOKE.CSharp_AkInitSettings_uContinuousPlaybackLookAhead_set(swigCPtr, value);

    } 
    get {
      uint ret = AkSoundEnginePINVOKE.CSharp_AkInitSettings_uContinuousPlaybackLookAhead_get(swigCPtr);

      return ret;
    } 
  }

  public uint uMonitorPoolSize {
    set {
      AkSoundEnginePINVOKE.CSharp_AkInitSettings_uMonitorPoolSize_set(swigCPtr, value);

    } 
    get {
      uint ret = AkSoundEnginePINVOKE.CSharp_AkInitSettings_uMonitorPoolSize_get(swigCPtr);

      return ret;
    } 
  }

  public uint uMonitorQueuePoolSize {
    set {
      AkSoundEnginePINVOKE.CSharp_AkInitSettings_uMonitorQueuePoolSize_set(swigCPtr, value);

    } 
    get {
      uint ret = AkSoundEnginePINVOKE.CSharp_AkInitSettings_uMonitorQueuePoolSize_get(swigCPtr);

      return ret;
    } 
  }

  public AkSinkType eMainOutputType {
    set {
      AkSoundEnginePINVOKE.CSharp_AkInitSettings_eMainOutputType_set(swigCPtr, (int)value);

    } 
    get {
      AkSinkType ret = (AkSinkType)AkSoundEnginePINVOKE.CSharp_AkInitSettings_eMainOutputType_get(swigCPtr);

      return ret;
    } 
  }

  public AkOutputSettings settingsMainOutput {
    set {
      AkSoundEnginePINVOKE.CSharp_AkInitSettings_settingsMainOutput_set(swigCPtr, AkOutputSettings.getCPtr(value));

    } 
    get {
      IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkInitSettings_settingsMainOutput_get(swigCPtr);
      AkOutputSettings ret = (cPtr == IntPtr.Zero) ? null : new AkOutputSettings(cPtr, false);

      return ret;
    } 
  }

  public AkInitSettings() : this(AkSoundEnginePINVOKE.CSharp_new_AkInitSettings(), true) {

  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_STANDALONE_LINUX || UNITY_WEBPLAYER || UNITY_WII || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY || UNITY_WP8) // Disable under unsupported platforms.
