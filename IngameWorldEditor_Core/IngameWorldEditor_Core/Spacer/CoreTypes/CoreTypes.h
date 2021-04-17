// Supported with union (c) 2020 Union team
// Union HEADER file

namespace GOTHIC_ENGINE {
  static char* IngameWorldEditor_UI = "IngameWorldEditor_UI.dll";

  // Initialize functions
  HMODULE LoadLibraryUI();
  void* LoadSymbolUI( const string& symName );

  // Interface types
  typedef void( *UIINITIALIZEPROC )();
  typedef HWND( *UICREATEWINDOWPROC )();
  typedef HWND( *UICRETRENDERVIEWPROC )();
  typedef void( *UISHOWWINDOWPROC )();
  typedef void(*UISETWINDOWTEXTPROC)(char*);
  typedef void(*UIVOBTREEADDPROC)(zCVob*, zCVob*);
  typedef void(*UIVOBTREEMOVEPROC)(zCVob*, zCVob*);
  typedef void(*UIVOBTREEREMOVEPROC)(zCVob*);
  typedef void(*UILOCKREDRAWPROC)();
  typedef void(*UIUNLOCKREDRAWPROC)();

  // Interface library imported functions
  static UIINITIALIZEPROC     UI_Initialize           = (UIINITIALIZEPROC)    LoadSymbolUI( "UI_Initialize"           );
  static UICREATEWINDOWPROC   UI_CreateWindow         = (UICREATEWINDOWPROC)  LoadSymbolUI( "UI_CreateWindow"         );
  static UICRETRENDERVIEWPROC UI_GetRenderView        = (UICRETRENDERVIEWPROC)LoadSymbolUI( "UI_GetRenderView"        );
  static UISHOWWINDOWPROC     UI_ShowWindow           = (UISHOWWINDOWPROC)    LoadSymbolUI( "UI_ShowWindow"           );
  static UISETWINDOWTEXTPROC  UI_SetWindowText        = (UISETWINDOWTEXTPROC) LoadSymbolUI( "UI_SetWindowText"        );
  static UIVOBTREEADDPROC     UI_VobTree_Add          = (UIVOBTREEADDPROC)    LoadSymbolUI( "UI_VobTree_Add"          );
  static UIVOBTREEMOVEPROC    UI_VobTree_Move         = (UIVOBTREEMOVEPROC)   LoadSymbolUI( "UI_VobTree_Move"         );
  static UIVOBTREEREMOVEPROC  UI_VobTree_Remove       = (UIVOBTREEREMOVEPROC) LoadSymbolUI( "UI_VobTree_Remove"       );
  static UILOCKREDRAWPROC     UI_VobTree_LockRedraw   = (UILOCKREDRAWPROC)    LoadSymbolUI( "UI_VobTree_LockRedraw"   );
  static UIUNLOCKREDRAWPROC   UI_VobTree_UnlockRedraw = (UIUNLOCKREDRAWPROC)  LoadSymbolUI( "UI_VobTree_UnlockRedraw" );

  // TODO

  void Core_StopInput();
  void Core_StartInput();
  const char* Core_GetVobName( void* vob );
  const char* Core_GetVobType( void* vob );
}