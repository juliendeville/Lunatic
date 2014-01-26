#if UNITY_STANDALONE_WIN || (UNITY_EDITOR_WIN && UNITY_STANDALONE_WIN) || (UNITY_EDITOR_WIN && UNITY_XBOX360) || (UNITY_EDITOR_WIN && UNITY_PS3) || (UNITY_EDITOR_WIN && UNITY_ANDROID) || (UNITY_EDITOR_WIN && UNITY_METRO) || (UNITY_EDITOR_WIN && UNITY_PSP2)
/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class AkSpeakerVolumes : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AkSpeakerVolumes(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(AkSpeakerVolumes obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~AkSpeakerVolumes() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkSpeakerVolumes(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public float fFrontLeft {
    set {
      AkSoundEnginePINVOKE.CSharp_AkSpeakerVolumes_fFrontLeft_set(swigCPtr, value);
    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkSpeakerVolumes_fFrontLeft_get(swigCPtr);
      return ret;
    } 
  }

  public float fFrontRight {
    set {
      AkSoundEnginePINVOKE.CSharp_AkSpeakerVolumes_fFrontRight_set(swigCPtr, value);
    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkSpeakerVolumes_fFrontRight_get(swigCPtr);
      return ret;
    } 
  }

  public float fCenter {
    set {
      AkSoundEnginePINVOKE.CSharp_AkSpeakerVolumes_fCenter_set(swigCPtr, value);
    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkSpeakerVolumes_fCenter_get(swigCPtr);
      return ret;
    } 
  }

  public float fRearLeft {
    set {
      AkSoundEnginePINVOKE.CSharp_AkSpeakerVolumes_fRearLeft_set(swigCPtr, value);
    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkSpeakerVolumes_fRearLeft_get(swigCPtr);
      return ret;
    } 
  }

  public float fRearRight {
    set {
      AkSoundEnginePINVOKE.CSharp_AkSpeakerVolumes_fRearRight_set(swigCPtr, value);
    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkSpeakerVolumes_fRearRight_get(swigCPtr);
      return ret;
    } 
  }

  public float fSideLeft {
    set {
      AkSoundEnginePINVOKE.CSharp_AkSpeakerVolumes_fSideLeft_set(swigCPtr, value);
    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkSpeakerVolumes_fSideLeft_get(swigCPtr);
      return ret;
    } 
  }

  public float fSideRight {
    set {
      AkSoundEnginePINVOKE.CSharp_AkSpeakerVolumes_fSideRight_set(swigCPtr, value);
    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkSpeakerVolumes_fSideRight_get(swigCPtr);
      return ret;
    } 
  }

  public float fLfe {
    set {
      AkSoundEnginePINVOKE.CSharp_AkSpeakerVolumes_fLfe_set(swigCPtr, value);
    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkSpeakerVolumes_fLfe_get(swigCPtr);
      return ret;
    } 
  }

  public AkSpeakerVolumes() : this(AkSoundEnginePINVOKE.CSharp_new_AkSpeakerVolumes(), true) {

  }

}
#endif // #if UNITY_STANDALONE_WIN || (UNITY_EDITOR_WIN && UNITY_STANDALONE_WIN) || (UNITY_EDITOR_WIN && UNITY_XBOX360) || (UNITY_EDITOR_WIN && UNITY_PS3) || (UNITY_EDITOR_WIN && UNITY_ANDROID) || (UNITY_EDITOR_WIN && UNITY_METRO) || (UNITY_EDITOR_WIN && UNITY_PSP2)
