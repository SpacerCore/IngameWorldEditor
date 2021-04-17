#include "UnionAfx.h"
// Check executed engine with current source code
#define CHECK_THIS_ENGINE (Union.GetEngineVersion() == ENGINE)
#define Engine_G1  1
#define Engine_G1A 2
#define Engine_G2  3
#define Engine_G2A 4

// Include source files (with same as header parameters)
#ifdef __G1
#define GOTHIC_ENGINE Gothic_I_Classic
#define ENGINE Engine_G1
#include "Headers.h"
#endif
#ifdef __G1A
#define GOTHIC_ENGINE Gothic_I_Addon
#define ENGINE Engine_G1A
#include "Headers.h"
#endif
#ifdef __G2
#define GOTHIC_ENGINE Gothic_II_Classic
#define ENGINE Engine_G2
#include "Headers.h"
#endif
#ifdef __G2A
#define GOTHIC_ENGINE Gothic_II_Addon
#define ENGINE Engine_G2A
#include "Headers.h"
#endif

#define DllExport extern "C" __declspec(dllexport)

DllExport void Core_StopInput() {
#ifdef __G1
  if( Union.GetEngineVersion() == Engine_G1 )
    return Gothic_I_Classic::Core_StopInput();
#endif
#ifdef __G1A
  if( Union.GetEngineVersion() == Engine_G1A )
    return Gothic_I_Addon::Core_StopInput();
#endif
#ifdef __G2
  if( Union.GetEngineVersion() == Engine_G2 )
    return Gothic_II_Classic::Core_StopInput();
#endif
#ifdef __G2A
  if( Union.GetEngineVersion() == Engine_G2A )
    return Gothic_II_Addon::Core_StopInput();
#endif
}

DllExport void Core_StartInput() {
#ifdef __G1
  if( Union.GetEngineVersion() == Engine_G1 )
    return Gothic_I_Classic::Core_StartInput();
#endif
#ifdef __G1A
  if( Union.GetEngineVersion() == Engine_G1A )
    return Gothic_I_Addon::Core_StartInput();
#endif
#ifdef __G2
  if( Union.GetEngineVersion() == Engine_G2 )
    return Gothic_II_Classic::Core_StartInput();
#endif
#ifdef __G2A
  if( Union.GetEngineVersion() == Engine_G2A )
    return Gothic_II_Addon::Core_StartInput();
#endif
}

DllExport const char* Core_GetVobNamePtr(void* vob) {
#ifdef __G1
  if( Union.GetEngineVersion() == Engine_G1 )
    return Gothic_I_Classic::Core_GetVobName( vob );
#endif
#ifdef __G1A
  if( Union.GetEngineVersion() == Engine_G1A )
    return Gothic_I_Addon::Core_GetVobName( vob );
#endif
#ifdef __G2
  if( Union.GetEngineVersion() == Engine_G2 )
    return Gothic_II_Classic::Core_GetVobName( vob );
#endif
#ifdef __G2A
  if( Union.GetEngineVersion() == Engine_G2A )
    return Gothic_II_Addon::Core_GetVobName( vob );
#endif
}

DllExport const char* Core_GetVobTypePtr( void* vob ) {
#ifdef __G1
  if( Union.GetEngineVersion() == Engine_G1 )
    return Gothic_I_Classic::Core_GetVobType( vob );
#endif
#ifdef __G1A
  if( Union.GetEngineVersion() == Engine_G1A )
    return Gothic_I_Addon::Core_GetVobType( vob );
#endif
#ifdef __G2
  if( Union.GetEngineVersion() == Engine_G2 )
    return Gothic_II_Classic::Core_GetVobType( vob );
#endif
#ifdef __G2A
  if( Union.GetEngineVersion() == Engine_G2A )
    return Gothic_II_Addon::Core_GetVobType( vob );
#endif
}