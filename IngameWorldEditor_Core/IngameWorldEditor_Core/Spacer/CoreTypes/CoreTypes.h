// Supported with union (c) 2020 Union team
// Union HEADER file

namespace GOTHIC_ENGINE {
	static char* IngameWorldEditor_UI = "IngameWorldEditor_UI.dll";

	// Initialize functions
	HMODULE LoadLibraryUI();
	void* LoadSymbolUI( const string& symName );

	// Interface types
	typedef void(*UIINITIALIZEPROC)();
	typedef HWND( *UICREATEWINDOWPROC )();

	// Interface library imported functions
	static UIINITIALIZEPROC		UI_Initialize		= (UIINITIALIZEPROC)  LoadSymbolUI( "UI_Initialize"   );
	static UICREATEWINDOWPROC UI_CreateWindow = (UICREATEWINDOWPROC)LoadSymbolUI( "UI_CreateWindow" );

	// TODO
}